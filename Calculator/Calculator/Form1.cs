using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                double second = Convert.ToDouble(textBox2.Text);
                ITwoArgCalculator calculator = TwoArgFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(first, second);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка " + exc.Message);
            }
        }


        private void OneButtonClick(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                IOneArgCalculator calculator = OneArgFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(first);
                textBox3.Text = result.ToString();
            }

            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка " + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = textBox4.Text.Split(' ');
                double[] doubleArray = new double[stringArray.Length];
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Convert.ToDouble(stringArray[i]);
                }
                ISorting calculator = SortingFactory.CreateCalculator(((Button)sender).Name);
                 
                string stringResult="";
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    stringResult += " " + doubleArray[i];
                }

                textBox3.Text = stringResult;
            }

            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка " + exc.Message);
            }
        }
    }
}
