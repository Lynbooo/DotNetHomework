using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        int n;
        double leng, per1, per2, th1, th2;
        Pen pen;
        Graphics gp;
        String[] colorString = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink", "Black" };
        Pen[] colorPen = { Pens.Red, Pens.Orange, Pens.Yellow, Pens.Green, Pens.Blue, Pens.Purple, Pens.Pink, Pens.Black };
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("Orange");
            comboBox1.Items.Add("Yellow");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Blue");
            comboBox1.Items.Add("Purple");
            comboBox1.Items.Add("Pink");
            comboBox1.Items.Add("Black");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_n.Text == ""
                | textBox_leng.Text == ""
                | textBox_per1.Text == ""
                | textBox_per2.Text == ""
                | textBox_th1.Text == ""
                | textBox_th2.Text == ""
                ) { return; }
            n = Convert.ToInt32(textBox_n.Text);
            leng = Convert.ToDouble(textBox_leng.Text);
            per1 = Convert.ToDouble(textBox_per1.Text);
            textBox_per1.Text = Convert.ToString(per1);
            per2 = Convert.ToDouble(textBox_per2.Text);
            th1 = Convert.ToDouble(textBox_th1.Text);
            th2 = Convert.ToDouble(textBox_th2.Text);
            Console.WriteLine("{n}");
            pen = colorPen[Array.IndexOf(colorString, comboBox1.Text)];

            if (gp == null) gp = this.CreateGraphics();
            gp.Clear(Color.White);
            DrawCayleyTree(n, leng, 550, 380, -Math.PI / 2);
        }
        private void DrawCayleyTree(int n, double leng, double x0, double y0, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            gp.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
            DrawCayleyTree(n - 1, per1 * leng, x1, y1, th + th1 * Math.PI / 180);
            DrawCayleyTree(n - 1, per2 * leng, x1, y1, th - th2 * Math.PI / 180);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
