using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鬧鐘
{
    public partial class work16 : Form
    {
        public work16()
        {
            InitializeComponent();
        }

        //private void initializeTimer()
        //{
        //    timer1.Interval
        //}
        private void label1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        bool b = false , a = false;
        int h, m, s;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //timer1.Interval = 1000;
            //timer1.Tick += new EventHandler(timer1_Tick);

            //timer1.Enabled = true;
            //button1.Text = "stop";
            //button1.Click += new EventHandler(timer1_Tick);

            label3.Text = DateTime.Now.ToString("hh-mm-ss");



            if (a)
            {
                if (!b)
                {
                    label3.BackColor = Color.Yellow;
                    label3.ForeColor = Color.Red;
                }

                else if (b)
                {
                    label3.BackColor = Color.Red;
                    label3.ForeColor = Color.Yellow;
                }
            }




            if (!b)
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            a = true;
                            label3.BackColor = Color.Yellow;
                            label3.ForeColor = Color.Red;
                        }
                    }
                }
            }

            else if(b)
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            a = true;
                            label3.BackColor = Color.Red;
                            label3.ForeColor = Color.Yellow;
                        }
                    }
                }
            }

            
            b = !b;
            //label3.BackColor = Color.Yellow;
            //label3.ForeColor = Color.Red;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                //label3.Text = "你有按下按鈕";
                
                b = false;
                //h = int.Parse(textBox2.Text);
                //m = int.Parse(textBox3.Text);
                //s = int.Parse(textBox4.Text);

                h = int.Parse(maskedTextBox1.Text.Substring(0, 2));
                m = int.Parse(maskedTextBox1.Text.Substring(3, 2));
                s = int.Parse(maskedTextBox1.Text.Substring(6, 2));
            }

            
            timer1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //textBox1.Text = string.Format(textBox1.Text, "###時###分###秒");
            timer1.Enabled = false;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;

            MessageBox.Show(maskedTextBox1.Text.Substring(0,2));
            MessageBox.Show(maskedTextBox1.Text.Substring(3, 2));
            MessageBox.Show(maskedTextBox1.Text.Substring(6, 2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
    }
}
