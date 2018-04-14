using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Marks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader("marks.txt",
                Encoding.GetEncoding("windows-1251"));
            int num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            int num = 0;
            double sum = 0;
            string line = "";
            while (line != null)
            {
                line = r.ReadLine();
                if (line == "2")
                {
                    num2++;
                }
                if (line == "3")
                {
                    num3++;
                }
                if (line == "4")
                {
                    num4++;
                }

                if (line == "5")
                {
                    num5++;
                }

                if (line == "6")
                {
                    num6++;
                }
                if (line != null)
                {
                    sum = sum + double.Parse(line);
                    num++;
                }
            }
            r.Close();
            ti2.Text = num2.ToString();
            ti3.Text = num3.ToString();
            ti4.Text = num4.ToString();
            pate.Text = num5.ToString();
            ti6.Text = num6.ToString();
            
           
            sum = Math.Round(sum / num, 2);
            label7.Text = sum.ToString();
        }
    }
}
