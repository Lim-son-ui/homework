using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打招呼
{
    public partial class work1 : Form
    {
        public work1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void click_helo(object sender, EventArgs e)
        {
            string name1 = txt1.Text;
            string name2 = txt2.Text;
            string name3 = txt3.Text;
            string name4 = txt4.Text;

            MessageBox.Show("hello, 我是" + name1 + "\n"+
                            "英文名字是" + name2 + "\n"+
                            "性別是" + name3 + "\n"+
                            "星座是" + name4 + "\n"+
                            "很高興認識你"
            );
 
        }

        private void click_hi(object sender, EventArgs e)
        {
            string name1 = txt1.Text;
            string name2 = txt2.Text;
            string name3 = txt3.Text;
            string name4 = txt4.Text;

            MessageBox.Show("hi, 我是" + name1 + "\n" +
                            "英文名字是" + name2 + "\n" +
                            "性別是" + name3 + "\n" +
                            "星座是" + name4 + "\n" +
                            "很高興認識你"
            );

        }
    }
}
