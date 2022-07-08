using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 買酒類;
using work8

namespace 打開視窗
{
    public partial class work0 : Form
    {
        public work0()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           work8.計算機 frm = new 計算機



            買酒類.Form1 frm = new 買酒類.Form1() {
                Size = new Size(1042, 586),
                StartPosition = FormStartPosition.Manual,
                Location = new Point(90, 120),
               // TopLevel = true
                
            };
            splitContainer1.Panel2.Controls.Add(frm);
            frm.MdiParent = this;
            frm.Show();
        }

    

        //public static extern int setParent(int hwchild, int hwnnew) { 
        //}

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
         
            買酒類.Form1 frm = new 買酒類.Form1();
            frm.Top = 0;
            frm.Left = 0;

            //Size = new Size(1042, 586);
            //StartPosition = FormStartPosition.Manual;
            //Location = new Point(90, 120);
            //TopMost = true;


            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);

            //frm.MdiParent = this;

            //splitContainer1_Panel2
            //splitContainer1_Panel2.Add(frm);
            frm.Show();
            //setParent()
            //frm.BringToFront();
        }
    }
}
