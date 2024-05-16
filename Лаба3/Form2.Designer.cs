namespace IntSys3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Конфликты и общий доступ");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Ввод-вывод");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Прерывания (IRQ)");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Память");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Аппаратные ресурсы", new System.Windows.Forms.TreeNode[] {
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Звуковые устройства");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Дисплей");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Ввод");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Указывающее устройство");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Ввод", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Запоминающие устройства");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Порты");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Компоненты", new System.Windows.Forms.TreeNode[] {
            treeNode66,
            treeNode67,
            treeNode70,
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Переменные среды");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Выполянемые задачи");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Авто загружаемые программы");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Программная среда", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Документация языка С#");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Документация по VS 2022");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Сведение о системе", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode73,
            treeNode77,
            treeNode78,
            treeNode79});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode61.Name = "tv_1_1";
            treeNode61.Text = "Конфликты и общий доступ";
            treeNode62.Name = "tv_1_2";
            treeNode62.Text = "Ввод-вывод";
            treeNode63.Name = "tv_1_3";
            treeNode63.Text = "Прерывания (IRQ)";
            treeNode64.Name = "tv_1_4";
            treeNode64.Text = "Память";
            treeNode65.Name = "fst";
            treeNode65.Text = "Аппаратные ресурсы";
            treeNode66.Name = "tv_2_1";
            treeNode66.Text = "Звуковые устройства";
            treeNode67.Name = "tv_2_2";
            treeNode67.Text = "Дисплей";
            treeNode68.Name = "tv_2_3_1";
            treeNode68.Text = "Ввод";
            treeNode69.Name = "tv_2_3_2";
            treeNode69.Text = "Указывающее устройство";
            treeNode70.Name = "tv_2_3";
            treeNode70.Text = "Ввод";
            treeNode71.Name = "tv_2_4";
            treeNode71.Text = "Запоминающие устройства";
            treeNode72.Name = "tv_2_5";
            treeNode72.Text = "Порты";
            treeNode73.Name = "snd";
            treeNode73.Text = "Компоненты";
            treeNode74.Name = "tv_3_1";
            treeNode74.Text = "Переменные среды";
            treeNode75.Name = "tv_3_2";
            treeNode75.Text = "Выполянемые задачи";
            treeNode76.Name = "tv_3_3";
            treeNode76.Text = "Авто загружаемые программы";
            treeNode77.Name = "thr";
            treeNode77.Text = "Программная среда";
            treeNode78.Name = "url1";
            treeNode78.Text = "Документация языка С#";
            treeNode79.Name = "url2";
            treeNode79.Text = "Документация по VS 2022";
            treeNode80.Checked = true;
            treeNode80.Name = "Start";
            treeNode80.Text = "Сведение о системе";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode80});
            this.treeView1.Size = new System.Drawing.Size(245, 391);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(263, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(413, 391);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Искать:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(136, 438);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Посимвольный поиск";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(445, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(688, 461);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form2";
            this.Text = "Справочник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}