﻿namespace Krolivets_IKM_722a_course_project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.проНакопичувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.текстовіФайлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StackText = new System.Windows.Forms.Label();
            this.LabelStack = new System.Windows.Forms.Label();
            this.Stacktb = new System.Windows.Forms.TextBox();
            this.Peek = new System.Windows.Forms.Button();
            this.Pop = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Queuetb = new System.Windows.Forms.TextBox();
            this.LabelQueue = new System.Windows.Forms.Label();
            this.QueueText = new System.Windows.Forms.Label();
            this.Peek_q = new System.Windows.Forms.Button();
            this.Dequeue = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgwOpen = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // tClock
            // 
            this.tClock.Enabled = true;
            this.tClock.Interval = 25000;
            this.tClock.Tick += new System.EventHandler(this.tClock_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.роботаToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.toolStripSeparator1,
            this.відкритиToolStripMenuItem,
            this.toolStripSeparator2,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.toolStripSeparator3,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтіЯкToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // роботаToolStripMenuItem
            // 
            this.роботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пускToolStripMenuItem,
            this.toolStripSeparator4,
            this.проНакопичувачіToolStripMenuItem,
            this.toolStripSeparator5,
            this.текстовіФайлиToolStripMenuItem});
            this.роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            this.роботаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.роботаToolStripMenuItem.Text = "Робота";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.bStart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // проНакопичувачіToolStripMenuItem
            // 
            this.проНакопичувачіToolStripMenuItem.Name = "проНакопичувачіToolStripMenuItem";
            this.проНакопичувачіToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.проНакопичувачіToolStripMenuItem.Text = "Про накопичувачі";
            this.проНакопичувачіToolStripMenuItem.Click += new System.EventHandler(this.проНакопичувачіToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // текстовіФайлиToolStripMenuItem
            // 
            this.текстовіФайлиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem1,
            this.зберегтиЯкToolStripMenuItem1,
            this.відкритиToolStripMenuItem1});
            this.текстовіФайлиToolStripMenuItem.Name = "текстовіФайлиToolStripMenuItem";
            this.текстовіФайлиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.текстовіФайлиToolStripMenuItem.Text = "Текстові файли";
            // 
            // зберегтиToolStripMenuItem1
            // 
            this.зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            this.зберегтиToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.зберегтиToolStripMenuItem1.Text = "Зберегти";
            this.зберегтиToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // зберегтиЯкToolStripMenuItem1
            // 
            this.зберегтиЯкToolStripMenuItem1.Name = "зберегтиЯкToolStripMenuItem1";
            this.зберегтиЯкToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.зберегтиЯкToolStripMenuItem1.Text = "Зберегти як...";
            this.зберегтиЯкToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem1_Click);
            // 
            // відкритиToolStripMenuItem1
            // 
            this.відкритиToolStripMenuItem1.Name = "відкритиToolStripMenuItem1";
            this.відкритиToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.відкритиToolStripMenuItem1.Text = "Відкрити";
            this.відкритиToolStripMenuItem1.Click += new System.EventHandler(this.відкритиToolStripMenuItem1_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "vici";
            this.sfdSave.Filter = "робочі файли | *.vici | Усі файли | *.*";
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "vici";
            this.ofdOpen.FileName = "openFileDialog1";
            this.ofdOpen.Filter = "робочі файли | *.vici | Усі файли | *.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 473);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Стек/Черга";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.StackText);
            this.splitContainer1.Panel1.Controls.Add(this.LabelStack);
            this.splitContainer1.Panel1.Controls.Add(this.Stacktb);
            this.splitContainer1.Panel1.Controls.Add(this.Peek);
            this.splitContainer1.Panel1.Controls.Add(this.Pop);
            this.splitContainer1.Panel1.Controls.Add(this.Push);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.Queuetb);
            this.splitContainer1.Panel2.Controls.Add(this.LabelQueue);
            this.splitContainer1.Panel2.Controls.Add(this.QueueText);
            this.splitContainer1.Panel2.Controls.Add(this.Peek_q);
            this.splitContainer1.Panel2.Controls.Add(this.Dequeue);
            this.splitContainer1.Panel2.Controls.Add(this.Enqueue);
            this.splitContainer1.Size = new System.Drawing.Size(893, 447);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 0;
            // 
            // StackText
            // 
            this.StackText.AutoSize = true;
            this.StackText.Location = new System.Drawing.Point(205, 71);
            this.StackText.Name = "StackText";
            this.StackText.Size = new System.Drawing.Size(31, 13);
            this.StackText.TabIndex = 5;
            this.StackText.Text = "Стек";
            // 
            // LabelStack
            // 
            this.LabelStack.AutoSize = true;
            this.LabelStack.Location = new System.Drawing.Point(184, 317);
            this.LabelStack.Name = "LabelStack";
            this.LabelStack.Size = new System.Drawing.Size(61, 13);
            this.LabelStack.TabIndex = 4;
            this.LabelStack.Text = "LabelStack";
            // 
            // Stacktb
            // 
            this.Stacktb.Location = new System.Drawing.Point(168, 152);
            this.Stacktb.Name = "Stacktb";
            this.Stacktb.Size = new System.Drawing.Size(100, 20);
            this.Stacktb.TabIndex = 3;
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(262, 219);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(75, 23);
            this.Peek.TabIndex = 2;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // Pop
            // 
            this.Pop.Location = new System.Drawing.Point(180, 219);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(75, 23);
            this.Pop.TabIndex = 1;
            this.Pop.Text = "Pop";
            this.Pop.UseVisualStyleBackColor = true;
            this.Pop.Click += new System.EventHandler(this.Pop_Click);
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(98, 220);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 0;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Queuetb
            // 
            this.Queuetb.Location = new System.Drawing.Point(167, 152);
            this.Queuetb.Name = "Queuetb";
            this.Queuetb.Size = new System.Drawing.Size(100, 20);
            this.Queuetb.TabIndex = 5;
            // 
            // LabelQueue
            // 
            this.LabelQueue.AutoSize = true;
            this.LabelQueue.Location = new System.Drawing.Point(186, 317);
            this.LabelQueue.Name = "LabelQueue";
            this.LabelQueue.Size = new System.Drawing.Size(65, 13);
            this.LabelQueue.TabIndex = 4;
            this.LabelQueue.Text = "LabelQueue";
            // 
            // QueueText
            // 
            this.QueueText.AutoSize = true;
            this.QueueText.Location = new System.Drawing.Point(201, 71);
            this.QueueText.Name = "QueueText";
            this.QueueText.Size = new System.Drawing.Size(38, 13);
            this.QueueText.TabIndex = 3;
            this.QueueText.Text = "Черга";
            this.QueueText.Click += new System.EventHandler(this.label2_Click);
            // 
            // Peek_q
            // 
            this.Peek_q.Location = new System.Drawing.Point(258, 220);
            this.Peek_q.Name = "Peek_q";
            this.Peek_q.Size = new System.Drawing.Size(75, 23);
            this.Peek_q.TabIndex = 2;
            this.Peek_q.Text = "Peek_q";
            this.Peek_q.UseVisualStyleBackColor = true;
            this.Peek_q.Click += new System.EventHandler(this.Peek_q_Click);
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(176, 220);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(75, 23);
            this.Dequeue.TabIndex = 1;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(94, 220);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(75, 23);
            this.Enqueue.TabIndex = 0;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(893, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Com Port";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 433);
            this.listBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 448);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(4, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 348);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Налаштування порту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Керування потоком";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(52, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Швидкість (біт/с)";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Біти даних";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Парність";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Xon/Xoff",
            "Аппаратное",
            "Нет"});
            this.comboBox6.Location = new System.Drawing.Point(6, 245);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 5;
            this.comboBox6.Text = "Нет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Стопові біти";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "Нет"});
            this.comboBox5.Location = new System.Drawing.Point(6, 196);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 4;
            this.comboBox5.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.comboBox2.Location = new System.Drawing.Point(6, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "115200";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Чет",
            "Нечет",
            "Нет",
            "Маркер",
            "Пробел"});
            this.comboBox4.Location = new System.Drawing.Point(6, 147);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.Text = "Нет";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(6, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Оберить поле";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(910, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Krolivets_IKM_722a_course_project.Properties.Resources._1682231261_kartinki_pibig_info_p_neitralnaya_fonovaya_kartinka_arti_krasivo_2;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbInput);
            this.tabPage1.Controls.Add(this.bStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Введення даних";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(435, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Location = new System.Drawing.Point(321, 141);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(268, 20);
            this.tbInput.TabIndex = 2;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(413, 193);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Пуск";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Krolivets_IKM_722a_course_project.Properties.Resources._1682231261_kartinki_pibig_info_p_neitralnaya_fonovaya_kartinka_arti_krasivo_2;
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.dgwOpen);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Controls.Add(this.bSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Робота з файлами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(525, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 174);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // dgwOpen
            // 
            this.dgwOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOpen.Location = new System.Drawing.Point(6, 21);
            this.dgwOpen.Name = "dgwOpen";
            this.dgwOpen.Size = new System.Drawing.Size(452, 214);
            this.dgwOpen.TabIndex = 4;
            this.dgwOpen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOpen_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(566, 128);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(223, 20);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(636, 66);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 8;
            this.bSearch.Text = "Пошук";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 525);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проНакопичувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.DataGridView dgwOpen;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Peek;
        private System.Windows.Forms.Button Pop;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.Label StackText;
        private System.Windows.Forms.Label LabelStack;
        private System.Windows.Forms.TextBox Stacktb;
        private System.Windows.Forms.TextBox Queuetb;
        private System.Windows.Forms.Label LabelQueue;
        private System.Windows.Forms.Label QueueText;
        private System.Windows.Forms.Button Peek_q;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem текстовіФайлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Label label7;
    }
}

