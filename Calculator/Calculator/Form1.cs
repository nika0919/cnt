using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "add":
                    result = first + second;
                    break;

                case "minus":
                    result = first - second;
                    break;

                case "multiply":
                    result = first * second;
                    break;

                case "division":
                    result = first / second;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            textBox3.Text = result.ToString();
        }
    }
}
