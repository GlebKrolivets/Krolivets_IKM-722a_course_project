using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Krolivets_IKM_722a_course_project
{
    public partial class Form1 : Form
    {
        private bool Mode;//Режим дозвілу або заборони
        private MajorWork MajorObject;//Створення об'єкта классу MajorWork 
        public Form1()
        {
            InitializeComponent();
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Минуло 25 секунд", "Увага!");//Виведення повідомлення на екран
            tClock.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            About A = new About(); // створення форми About
            A.tAbout.Start();
            A.ShowDialog(); // відображення діалогового вікна About
            MajorObject =new MajorWork();
            MajorObject.SetTime();
            MajorObject.Modify =false;// заборона запису
            this.Mode = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if(Mode)
            {
                tbInput.Enabled = true;//режим дозволу введення
                tbInput.Focus();
                tClock.Start();
                bStart.Text="Стоп";//зміна тексту на кнопці на Стоп
                this.Mode = false;
                пускToolStripMenuItem.Text = "Стоп";
            }
            else
            {
                tbInput.Enabled = false;//режим заборони введення
                tClock.Stop();
                bStart.Text="Пуск";//зміна тексту на кнопці на Пуск
                this.Mode=true;

                MajorObject.Write(tbInput.Text);// Запис даних у об'єкт
                MajorObject.Task();// Обробка даних
                label1.Text = MajorObject.Read();// Відображення результату
                пускToolStripMenuItem.Text = "Старт";
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar>='0') &(e.KeyChar <= '9') |(e.KeyChar ==(char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("Некоректний символ", "Помилка");
                tClock.Start();
                e.KeyChar=(char)0;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "Час роботи програми"); // Виведення часу роботи програми і повідомлення "Час роботи програми" на екран
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.ShowDialog();
        }

        private void зберегтіЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK) // Виклик діалогу збереження файлу
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName); // Запис імені файлу для збереження
                MajorObject.Generator();
                MajorObject.SaveToFile(); // метод збереження в файл
            }
        }

            private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK) // Виклик діалогового вікна відкриття файлу
            {
                MajorObject.WriteOpenFileName(ofdOpen.FileName); // відкриття файлу 
                MajorObject.ReadFromFile(dgwOpen); // читання даних з файлу
            }
        }

        private void проНакопичувачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] disks = System.IO.Directory.GetLogicalDrives();
            string disk = "";

            for (int i = 0; i < disks.Length; i++)
            {
                try
                {
                    System.IO.DriveInfo D = new System.IO.DriveInfo(disks[i]);
                    long totalSizeInBytes = D.TotalSize;
                    long totalFreeSpaceInBytes = D.TotalFreeSpace;

                    double totalSizeInGB = (double)totalSizeInBytes / 1073741824; // Переведення в гігабайти
                    double totalFreeSpaceInGB = (double)totalFreeSpaceInBytes / 1073741824; // Переведення в гігабайти

                    disk += D.Name  + totalSizeInGB.ToString("0.00") + " ГБ" + "-" + totalFreeSpaceInGB.ToString("0.00") + " ГБ" + (char)13;// змінній присвоюється ім’я диска, загальна кількість місця и вільне місце на диску
                }
                catch
                {
                    disk += disks[i] + "- не готовий" + (char)13;// якщо пристрій не готовий,то виведення на екран ім’я пристрою і повідомлення «не готовий»
                }
            }
            MessageBox.Show(disk, "Накопичувачі");
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MajorObject.SaveFileNameExists()) // задане ім’я файлу існує?
                MajorObject.SaveToFile(); // зберегти дані в файл
            else
                зберегтіЯкToolStripMenuItem_Click(sender, e); //зберегти дані в "ім'я файлу", яке буде введене у форму для збереження
        }

        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajorObject.NewRec();
            tbInput.Clear();// очистити вміст тексту
            label1.Text = "";
            tbSearch.Clear();
            dgwOpen.Columns.Clear();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MajorObject.Modify)
                if (MessageBox.Show("Дані не були збережені. Продовжити вихід?", "УВАГА",
                MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true; // припинити закриття
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            MajorObject.Find(tbSearch.Text); //пошук
        }

        private void dgwOpen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
