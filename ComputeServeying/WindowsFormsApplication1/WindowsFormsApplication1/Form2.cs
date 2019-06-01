using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        
        
        
        public class Change1
        {
            
            
            public double getDu(double angle)                         //十进制度向度分秒函数
            {
                double a;
                a = (int)angle;
                return a;
            }
            public double getFen(double angle)
            {
                double b;
                b = (int)((angle - (int)angle) * 60);
                return b;
            }
            public double getMiao(double angle)
            {
                double c;
                c = (int)(((angle - (int)angle) * 60 - (int)((angle - (int)angle) * 60)) * 60);
                return c;
            }




            public double dfmToD(double a, double b, double c)       //度分秒向十进制度函数
            {
                double d = a + b / 60 + c / 3600;
                return d;
            }



            public double HdToSjz(double angle)                       //弧度到十进制度函数
            {
                double x = angle * 180 / Math.PI;
                return x;
            }
            public double SjzToHd(double angle)                      //十进制度到弧度函数
            {
                double x = angle * Math.PI / 180;
                return x;
            }




            public double HdToDfm(double angle)                      //弧度到度分秒函数
            {
                double a = angle * 180 / Math.PI;
                double c = (int)(((a - (int)a) * 60 - (int)((a - (int)a) * 60)) * 60);
                return c;
            }

            public double DfmToHd(double a, double b, double c)       //度分秒到弧度
            {
                double d = a + b / 60 + c / 3600;
                double e = d * Math.PI / 180;
                return e;
            }
        }

        
        public Form2()
        {
            InitializeComponent();
        }



        Change1 m = new Change1();
        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            double angle00 = Convert.ToDouble(x);
            double a1 = m.HdToSjz(angle00);
            double a = m.getDu(a1);
            double b = m.getFen(a1);
            double c = m.getMiao(a1);
            textBox20.Text = Convert.ToString(a);
            textBox19.Text = Convert.ToString(b);
            textBox2.Text = Convert.ToString(c);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox3.Text;
                string y = textBox13.Text;
                string z = textBox14.Text;
                double n = m.DfmToHd(Convert.ToDouble(x), Convert.ToDouble(y), Convert.ToDouble(z));
                textBox4.Text = Convert.ToString(n);
            }
            catch {
                MessageBox.Show("输入格式不正确！");
            
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(textBox5.Text);
            string x, y, z;
            x = Convert.ToString(m.getDu(angle))+"度";
            y = Convert.ToString(m.getFen(angle))+"分";
            z = Convert.ToString(m.getMiao(angle))+"秒";
            textBox15.Text = x;
            textBox16.Text = y;
            textBox17.Text = z;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string x = textBox6.Text;
            string y = textBox7.Text;
            string z = textBox18.Text;
            try
            {
                double d = m.dfmToD(Convert.ToDouble(x), Convert.ToDouble(y), Convert.ToDouble(z));
                textBox8.Text = Convert.ToString(d);
            }
            catch 
            {
                MessageBox.Show("输入格式不正确！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = textBox10.Text;
            double b = m.HdToSjz(Convert.ToDouble(a));
            textBox9.Text = Convert.ToString(b);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            string a = textBox12.Text;
            double b = m.SjzToHd(Convert.ToDouble(a));
            textBox11.Text = Convert.ToString(b);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
   
    }
}
