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
    public partial class Form3 : Form
    { 
        class Change2{
        
        public double distance(double x1, double x2, double y1, double y2)       //求距离的函数
        {
            double x3, y3, z;
            x3 = x2 - x1;
            y3 = y2 - y1;
            z = Math.Sqrt(x3 * x3 + y3 * y3);
            return z;
        }


        public string angle0( double x1,double x2,double y1,double y2)         //求方位角函数
        {
            double deltax, deltay,r;
            double angle = 0;
            double angle1 = 0;
            int d, f, m;
            string x;
            deltax = x2 - x1;
            deltay = y2 - y1;
            r = Math.Atan(deltay / deltax);
            if (deltax == 0 && deltay == 0)
                MessageBox.Show("输入错误！");
            else if (deltax == 0 && deltay < 0)
                angle = 3 * Math.PI / 2;
            else if (deltax == 0 && deltay > 0)
                angle = Math.PI / 2;
            else if (deltax <= 0)
                angle = r + Math.PI;
            else if (deltay <= 0)
                angle = r + 2 * Math.PI;
            else
                angle = r;
            angle1 = angle * 180 / Math.PI;
            d = (int)angle1;
            f = (int)((angle1 - d) * 60);
            m = (int)(((angle1 - d) * 60 - f) * 60);
            x = Convert.ToString(d) + "°" + Convert.ToString(f) + "′" + Convert.ToString(m) + "″";
            return x;
        }

        public double outx(double x1,double s,double angle)                     //求坐标函数
        {
            double x;
            x = x1 + s * Math.Cos(angle);
            return x;
        }
        public double outy(double y1, double s, double angle)
        {
            double y;
            y = y1 + s * Math.Cos(angle);
            return y;
        }


    }


           
        public Form3()
        {
            InitializeComponent();
        }

        Change2 s = new Change2();  

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)                         //点击求距离
        {
            double m;
            string x1 = textBox7.Text;
            string x2 = textBox9.Text;
            string y1 = textBox6.Text;
            string y2 = textBox8.Text;
            m=s.distance(Convert.ToDouble(x1),Convert.ToDouble(x2),Convert.ToDouble(y1),Convert.ToDouble(y2));
            textBox10.Text = Convert.ToString(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)                         //点击求方位角
        {
            string x1 = textBox1.Text;
            string x2 = textBox4.Text;
            string y1 = textBox2.Text;
            string y2 = textBox3.Text;
            textBox5.Text =s.angle0(Convert.ToDouble(x1), Convert.ToDouble(x2), Convert.ToDouble(y1), Convert.ToDouble(y2));
        }

        private void button6_Click(object sender, EventArgs e)                         //点击求坐标
        {
            string x1 = textBox15.Text;
            string y1 = textBox14.Text;
            string s5= textBox16.Text;
            string angle = textBox11.Text;
            double x2 = s.outx(Convert.ToDouble(x1), Convert.ToDouble(s5), Convert.ToDouble(angle));
            double y2 = s.outy(Convert.ToDouble(y1), Convert.ToDouble(s5), Convert.ToDouble(angle));
            textBox13.Text = Convert.ToString(x2);
            textBox12.Text = Convert.ToString(y2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

    }
}
