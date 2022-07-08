using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_成績
{
    public partial class work6 : Form
    {
        public work6()
        {
            InitializeComponent();

            textBox7.Text += $"{"姓名",-5}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";
        }

        struct student
        {
            public string name;
            public int chinese,englsih,math,sum,avg,min,max;
        } student st;

        List<student> studen = new List<student>();

        void showstudent() {

            textBox7.Text = null;
            textBox7.Text += $"{"姓名",-5}{"國文",6}{"英文",6}{"數學",6}{"總分",6}{"平均",6}{"最低",6}{"最高",6}{"",-5}";
            foreach (student st in studen)
            {
                textBox7.Text += $"\r\n{st.name,-7}{st.chinese,8}{st.englsih,8}{st.math,8}" +
                    $"{st.sum,8}{st.avg,8}{st.min,8}{st.max,8}{"",-5}";
            }
        }

        void calcu()
        {
            st.name = textBox1.Text;
            st.chinese = int.Parse(textBox2.Text);
            st.englsih = int.Parse(textBox3.Text);
            st.math = int.Parse(textBox4.Text);
            st.sum = st.chinese + st.englsih + st.math;
            st.avg = st.sum / 3;


            if (st.chinese == st.englsih && st.englsih == st.math)   
            if (st.englsih < st.min) st.min = st.englsih;
 
            if (st.math > st.max) st.max = st.math;
            if(st.englsih > st.max) st.max = st.englsih;
       
        }


        private void button1_Click(object sender, EventArgs e)
        {

            calcu();

            //studen.

            studen.Add(st);

            showstudent();
        }

        private void button6_Click(object sender, EventArgs e)      //各科目統計 後面再做
        {

        }
        /*

         */
        private void button2_Click(object sender, EventArgs e)
        {
            st.name = textBox1.Text;
            st.chinese = int.Parse(textBox2.Text);
            st.englsih = int.Parse(textBox3.Text);
            st.math = int.Parse(textBox4.Text);

            studen.Insert(0, st);

            showstudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studen.RemoveAt(0);

            showstudent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studen.Clear();

            showstudent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
