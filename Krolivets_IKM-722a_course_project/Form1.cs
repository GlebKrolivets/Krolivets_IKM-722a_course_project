﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krolivets_IKM_722a_course_project
{
    public partial class Form1 : Form
    {
        private bool Mode;//Режим дозвілу або заборони
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
            }
            else
            {
                tbInput.Enabled = false;//режим заборони введення
                tClock.Stop();
                bStart.Text="Пуск";////зміна тексту на кнопці на Пуск
                this.Mode=true;
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
    }
}
