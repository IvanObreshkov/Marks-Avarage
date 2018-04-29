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
            List<string> lines = new List<string>(File.ReadAllLines("marks.txt"));
            double avg = 0;
            foreach (var line in lines)
            {
                switch (line)
                {
                    case "2":
                        ti2.Text = (int.Parse(ti2.Text) + 1).ToString();
                        break;
                    case "3":
                        ti3.Text = (int.Parse(ti3.Text) + 1).ToString();
                        break;
                    case "4":
                        ti4.Text = (int.Parse(ti4.Text) + 1).ToString();
                        break;
                    case "5":
                        ti5.Text = (int.Parse(ti5.Text) + 1).ToString();
                        break;
                    case "6":
                        ti6.Text = (int.Parse(ti6.Text) + 1).ToString();
                        break;
                    default:
                        break;
                }
                if(line != null) avg += double.Parse(line);
            }
            avg = avg / lines.Count();
            label7.Text = Math.Round(avg,2).ToString();
        }
    }
}
