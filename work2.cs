using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 貸款試算
{


    public partial class work2 : Form
    {


        public work2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double loanamount = 0, year = 0, rate = 0, firstincome = 0, a = 0, month = 0;
        int avg_pay = 0,sum = 0 ,flag = 0;
        bool num1, num2, num3, num4;


        private void formclose(object sender,FormClosingEventArgs e)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.AppendFormat("{0}  =  {1}", "you are wrong", e.CloseReason);
            str.AppendLine();
            MessageBox.Show(str.ToString(), "form close event");
        }
        void calcu()
        {
            num1 = double.TryParse(txt1.Text, out loanamount);
            num2 = double.TryParse(txt2.Text,out year);
            num3 = double.TryParse(txt3.Text, out rate);
            num4 = double.TryParse(txt4.Text, out firstincome);     //頭期款


            if (num1 && num2 && num3 && num4)
            {
                year *= 12;
                rate /= 12;
                rate /= 100;

                a = Math.Pow(1 + rate, year);

                month = a * rate / (a - 1);
                avg_pay = Convert.ToInt32((loanamount - firstincome) * month);    //平攤
                sum = Convert.ToInt32(avg_pay * year);                   //總還款
            }

            else
            {
                flag = 1;
                DialogResult result = MessageBox.Show("輸入格式錯誤!!", "Warning",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                //if (result == DialogResult.Abort)    
                //{
                //    return;

                //}

            }
        }

        
        private void click1(object sender, EventArgs e)
        {
            calcu();
            if (flag == 0)    MessageBox.Show("月付款數:" + avg_pay + "元");
                
     
            else
            {

            }
        }

        private void click2(object sender, EventArgs e)
        {
            calcu();
            if (flag == 0)     MessageBox.Show("總付款數" + sum + "元");
        
            else { 
            
            }
           
        }

        private void click3(object sender, EventArgs e)
        {
            calcu();
            if (flag == 0)
            {
                work2out form = new work2out();
                form.label1.Text = loanamount.ToString();
                form.label2.Text = year.ToString();
                form.label3.Text = rate.ToString();
                form.label4.Text = avg_pay.ToString();
                form.label5.Text = sum.ToString();
                
                form.Show();
            }
            else
            {

            }
            
        }
    }
}
