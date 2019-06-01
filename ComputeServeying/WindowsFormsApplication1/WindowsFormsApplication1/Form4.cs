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
    public partial class Form4 : Form
    {

   class Change3 {   
       
       
       public double dis1(double x1,double y1,double x2,double y2,double a,double b)                             //前方交会函数
        {
            double a1 = a * Math.PI / 180;
            double b1 = b * Math.PI / 180;
            double x = (x1 / Math.Tan(b1) + x2 / Math.Tan(a1) - y1 + y2) / (1 / Math.Tan(a1) + 1 / Math.Tan(b1));
            return x;
        }
        public double dis2(double x1, double y1, double x2, double y2, double a, double b)
        {
            double a1 = a * Math.PI / 180;
            double b1 = b * Math.PI / 180;
            double y = (y1/ Math.Tan(b1) + y2 / Math.Tan(a1) + x1 -x2) / (1 / Math.Tan(a1) + 1 / Math.Tan(b1));
            return -y;
        }



        public double angle01(double x1, double x2, double y1, double y2,double Dap,double Dbp)               //求方位角函数+求距离交会函数
        {
            double deltax, deltay, r,Dab,bap,abp,ap,bp,Xp;
            double angle = 0;
            double angle1 = 0;
            deltax = x2 - x1;
            deltay = y2 - y1;
            Dab = Math.Sqrt(deltax * deltax + deltay * deltay);
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
            double m1 = Math.Pow(Dab, 2) + Math.Pow(Dap, 2) - Math.Pow(Dbp, 2);
            double m2 = 2 * Dab * Dap;
            double n1 = Math.Pow(Dab, 2) + Math.Pow(Dbp, 2) - Math.Pow(Dap, 2);
            double n2=2*Dab*Dbp;
            bap = Math.Acos(m1/m2);
            abp = Math.Acos(n1/n2);
            ap = angle - bap;
            bp = ap - abp;
            Xp = x1 + Dap * Math.Cos(ap);
            return Xp;

        }

        public double angle02(double x1, double x2, double y1, double y2, double Dap, double Dbp)               //求方位角函数+求距离交会函数
        {
            double deltax, deltay, r, Dab, bap, abp, ap, bp, Yp;
            double angle = 0;
            double angle1 = 0;
            deltax = x2 - x1;
            deltay = y2 - y1;
            Dab = Math.Sqrt(deltax * deltax + deltay * deltay);
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
            double m1 = Math.Pow(Dab, 2) + Math.Pow(Dap, 2) - Math.Pow(Dbp,2);
            double m2 = 2 * Dab * Dap;
            double n1 = Math.Pow(Dab, 2) + Math.Pow(Dbp, 2) - Math.Pow(Dap, 2);
            double n2 = 2 * Dab * Dbp;
            bap = Math.Acos(m1/m2);
            abp = Math.Acos(n1/n2);
            ap = angle - bap;
            bp = ap - abp;
            Yp = y1 + Dap * Math.Sin(ap);
            return Yp;

        }




        public double hf01(double pa, double pb, double pc,double xa,double xb,double xc,double ya,double yb,double yc)    //后方交会函数
        {
            double β = pa - pc;
            double γ = pb - pa;
            double m1 = xa + xb + (ya - yb) / Math.Tan(γ * Math.PI / 180);
            double m2 = xa + xc + (ya - yc) / Math.Tan(β * Math.PI / 180);
            double m3 = xa + xc + (ya - yc) / Math.Tan(β * Math.PI / 180);
            double m4 = ya + yc + (xc - xa) / Math.Tan(β * Math.PI / 180);

            double x1 = m1/2;
            double y1 = m2/2;
            double x2 = m3/2;
            double y2 = m4/2;
            double k = (2 * ya * (x2 - x1) - xa * (y2 - y1) + x1 * y2 - x2 * y1)/(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
            double xp = xa + k * (y2 - y1);
            double yp = ya + k*(x1 - x2);
            return xp;

        }
        public double hf02(double pa, double pb, double pc, double xa, double xb, double xc, double ya, double yb, double yc)
        {
            double β = pa - pc;
            double γ = pb - pa;
            double m1 = xa + xb + (ya - yb) / Math.Tan(γ * Math.PI / 180);
            double m2 = xa + xc + (ya - yc) / Math.Tan(β * Math.PI / 180);
            double m3 = xa + xc + (ya - yc) / Math.Tan(β * Math.PI / 180);
            double m4 = ya + yc + (xc - xa) / Math.Tan(β * Math.PI / 180);

            double x1 = m1 / 2;
            double y1 = m2 / 2;
            double x2 = m3 / 2;
            double y2 = m4 / 2;
            double k = (2 * ya * (x2 - x1) - xa * (y2 - y1) + x1 * y2 - x2 * y1) / (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            double xp = xa + k * (y2 - y1);
            double yp = ya + k * (x1 - x2);
            return yp;

        }

    }
   
        
       


        public Form4()
        {
            InitializeComponent();
        }



        Change3 mn = new Change3();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string y1 = textBox3.Text;
            string a = textBox4.Text;
            string x2 = textBox6.Text;
            string y2 = textBox5.Text;
            string b = textBox2.Text;
            double x = mn.dis1(Convert.ToDouble(x1), Convert.ToDouble(y1), Convert.ToDouble(x2), Convert.ToDouble(y2), Convert.ToDouble(a), Convert.ToDouble(b));
            double y = mn.dis2(Convert.ToDouble(x1), Convert.ToDouble(y1), Convert.ToDouble(x2), Convert.ToDouble(y2), Convert.ToDouble(a), Convert.ToDouble(b));
            textBox8.Text = Convert.ToString(x);
            textBox7.Text = Convert.ToString(y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            
            string x1 = textBox14.Text;
            string y1 = textBox13.Text;
            string Dap = textBox12.Text;
            string x2 = textBox11.Text;
            string y2 = textBox10.Text;
            string Dbp = textBox9.Text;
            double Xp =mn.angle01(Convert.ToDouble(x1), Convert.ToDouble(x2), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(Dap), Convert.ToDouble(Dbp));
            double Yp = mn.angle02(Convert.ToDouble(x1), Convert.ToDouble(x2), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(Dap), Convert.ToDouble(Dbp));
            textBox16.Text = Convert.ToString(Xp);
            textBox15.Text = Convert.ToString(Yp);
        }
            
        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x1, x2, x3, y1, y2, y3,pa,pb,pc;
            x1 = textBox21.Text;
            x2 = textBox20.Text;
            x3 = textBox19.Text;
            y1 = textBox27.Text;
            y2 = textBox26.Text;
            y3 = textBox25.Text;
            pa = textBox24.Text;
            pb = textBox23.Text;
            pc = textBox22.Text;
            double xp = mn.hf01(Convert.ToDouble(pa), Convert.ToDouble(pb), Convert.ToDouble(pc), Convert.ToDouble(x1), Convert.ToDouble(x2), Convert.ToDouble(x3), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(y3));
            double yp = mn.hf02(Convert.ToDouble(pa), Convert.ToDouble(pb), Convert.ToDouble(pc), Convert.ToDouble(x1), Convert.ToDouble(x2), Convert.ToDouble(x3), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(y3));
            textBox18.Text = Convert.ToString(xp);
            textBox17.Text = Convert.ToString(yp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
