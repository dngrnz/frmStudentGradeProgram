using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }private void button1_Click(object sender, EventArgs e)
        {


            double science = Convert.ToDouble(textBox5.Text);
            double mathematics = Convert.ToDouble(textBox6.Text);
            double english = Convert.ToDouble(textBox7.Text);
            double filipino = Convert.ToDouble(textBox8.Text);
            double PE = Convert.ToDouble(textBox9.Text);

            double sum = science + mathematics + english + filipino + PE;
            double totalgrade = sum / 5;
            double average = Math.Round(totalgrade);

            label9.Text = average >= 75.00 ? "The Student Passed..\n The General Average of " + textBox2.Text + " is " + average : "The Student Failed..\n Try Again Next Year";
            
        }

        }
    }

