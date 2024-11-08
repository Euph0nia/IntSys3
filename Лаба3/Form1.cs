﻿using IntSys3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба3
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem firstLevel;
        private ToolStripMenuItem secondLevel;
        private ToolStripMenuItem thirdLevel;

        private readonly Random random;
        private DateTime startTime;

        private string path = "";
        private int count = 0;
        private int _count = 0;
        private int _level = 0;

        public Form1()
        {
            InitializeComponent();

            random = new Random();

            menuStrip1.Visible = false;
            button2.Enabled = false;

            label1.Text = "Нажмите на кнопку Начать.";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {;
            menuStrip1.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;

            GetRandomMenuItem();
            count++;
            label1.Text = path;
            _count = 0;

            startTime = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Чтобы начать, нажмите на кнопку 'Начать'.";

            menuStrip1 .Visible = false;
            button1.Enabled = true;
            button2.Enabled = false;

            path = "";
            firstLevel = null;
            secondLevel = null;
            thirdLevel = null;
        }

        private void GetRandomMenuItem()
        {
            int level = new Random().Next(1, 10);
            if (level <= 3)
                _level = 1;
            else if (level >= 7)
                _level = 3;
            else if (level > 3 && level < 7)
                _level = 2;
            int menuIndex = random.Next(menuStrip1.Items.Count);

            firstLevel = menuStrip1.Items[menuIndex] as ToolStripMenuItem;

            path += $"{firstLevel.Text} ";

            if (firstLevel != null && firstLevel.DropDownItems.Count > 0 && _level >= 2)
            {
                menuIndex = random.Next(firstLevel.DropDownItems.Count);

                secondLevel = firstLevel.DropDownItems[menuIndex] as ToolStripMenuItem;

                path += $"-> {secondLevel.Text} ";

                if (secondLevel != null && secondLevel.DropDownItems.Count > 0 && _level >= 3)
                {
                    menuIndex = random.Next(secondLevel.DropDownItems.Count);

                    thirdLevel = secondLevel.DropDownItems[menuIndex] as ToolStripMenuItem;

                    path += $"-> {thirdLevel.Text}";
                }
            }
        }

        private float Hick()
        {
            return 50 + 150 * (float)Math.Log(_level + 1);
        }

        private void CheckingElement(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;

            if (_count == 10)
            {
                textBox1.Text += $"\r\n\r\n10 тестов прошло, тест завершен!";

                label1.Text = "Чтобы начать, нажмите на кнопку 'Начать'.";

                menuStrip1.Visible = false;
                button1.Enabled = true;
                button2.Enabled = false;

                count = 0;
                _count = 0;

                path = "";
                firstLevel = null;
                secondLevel = null;
                thirdLevel = null;
            }
            else if (_level == 1)
            {
                if (item.Text == firstLevel.Text)
                {
                    var stopTime = DateTime.Now;
                    var reactions = (stopTime - startTime).TotalMilliseconds;
                    if (count == 1)
                    {
                        textBox1.Text += $"{count}. Время реакции: {(int)reactions} мс. \r\n    Время по формуле Хика: {Hick()}";
                    }
                    else
                    {
                        textBox1.Text += $"\r\n\r\n{count}. Время реакции: {(int)reactions} мс. \r\n    Время по формуле Хика: {Hick()}";
                    }

                    _count++;
                    path = "";
                    label1.Text = "";
                    firstLevel = null;
                    secondLevel = null;
                    thirdLevel = null;

                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Неверный элемент меню!");
                }
            }
            else if (_level == 2 && secondLevel.Text != null)
            {
                if (item.Text == secondLevel.Text)
                {
                    var stopTime = DateTime.Now;
                    var reactions = (stopTime - startTime).TotalMilliseconds;
                    if (count == 1)
                    {
                        textBox1.Text += $"{count}. Время реакции: {(int)reactions} мс. \r\n    Время по формуле Хика: {Hick()}";
                    }
                    else
                    {
                        textBox1.Text += $"\r\n\r\n{count}. Время реакции: {(int)reactions} мс. \r\n    Время по формуле Хика: {Hick()}";
                    }

                    _count++;
                    path = "";
                    label1.Text = "";
                    firstLevel = null;
                    secondLevel = null;
                    thirdLevel = null;

                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Неверный элемент меню!");
                }
            }
            else if (_level == 3 && thirdLevel.Text != null)
            {
                if (item.Text == thirdLevel.Text)
                {
                    var stopTime = DateTime.Now;
                    var reactions = (stopTime - startTime).TotalMilliseconds;
                    if (count == 1)
                    {
                        textBox1.Text += $"{count}. Время реакции: {(int)reactions} мс. \r\n    Время по формуле Хика: {Hick()}";
                    }
                    else
                    {
                        textBox1.Text += $"\r\n\r\n{count}. Время реакции: {(int)reactions} мс. \r\n    Время по формуле Хика: {Hick()}";
                    }

                    _count++;
                    path = "";
                    label1.Text = "";
                    firstLevel = null;
                    secondLevel = null;
                    thirdLevel = null;

                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Неверный элемент меню!");
                }
            }
            else
            {
                MessageBox.Show("Неверный элемент меню!");
            }

            
        }

        private void i9_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i10_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i11_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i12_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i20_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i21_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i5_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i6_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i7_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i13_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i14_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i17_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i18_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i19_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i22_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i23_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i1_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i2_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i3_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }

        private void i4_Click(object sender, EventArgs e)
        {
            CheckingElement(sender, e);
        }
    }
}
