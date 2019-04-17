using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShwWeek7DrawTree
{
    public partial class Form1 : Form
    {
        private Graphics g;

        private Color[] colorList = new Color[2] { Color.Black, Color.Blue };
        private int colorChoice;
        private int penSize = 1;
        private Pen pen = new Pen(Color.Black);
        private double angleL;
        private double angleR;
        private double leng0;
        private double perL;
        private double perR;
        private int k;
        public int n=10;

        private int rootX = 200;
        private int rootY = 310;

        public Form1()
        {
            InitializeComponent();
            if (g == null)
                g = panel2.CreateGraphics();
            g.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            try
            {
                leng0 = System.Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                textBox5.Text = "100";
                leng0 = 100;
            }
            DrawCayleyTree(n,rootX,rootY,leng0,-Math.PI/2);
        }

        private void DrawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            try
            {
                angleL = System.Convert.ToDouble(textBox1.Text);
                angleR = System.Convert.ToDouble(textBox3.Text);
                perL = System.Convert.ToDouble(textBox2.Text);
                perR = System.Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                textBox1.Text = textBox3.Text = "30";
                angleL = angleR = 30;
                textBox4.Text = textBox2.Text = "0.5";
                perL = perR = 0.5;
            }
            if (n == 0)
                return;

            double thL = angleL * Math.PI / 180;
            double thR = angleR * Math.PI / 180;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            MyDrawLine(x0, y0, x1, y1);

            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);
            if(k>1) MyDrawLine(x1, y1, x2, y2);

            DrawCayleyTree(n - 1, x1, y1, perL * leng, th + thL);
            DrawCayleyTree(n - 1, x2, y2, perR * leng, th - thR);
        }

        private void MyDrawLine(double x0, double y0, double x1, double y1)
        {
            pen.Color = colorList[colorChoice];
            pen.Width = penSize;
            g.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorChoice = comboBox1.SelectedIndex; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                penSize = 3;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                penSize = 1;
        }
    }
}
