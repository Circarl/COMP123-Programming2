using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Fraction_Calculator
{
    public partial class Form1 : Form
    {
        private string SelectedOperation { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {  }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SelectedOperation = "+";
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void radioButton_subtract(object sender, EventArgs e)
        {
            SelectedOperation = "-";
        }

        private void radioButton_divide(object sender, EventArgs e)
        {
            SelectedOperation = "/";
        }

        private void radioButton_multiply(object sender, EventArgs e)
        {
            SelectedOperation = "*";
        }

        private void result_denom(object sender, EventArgs e)
        {

        }

        private void numerator1(object sender, EventArgs e)
        {

        }

        private void denominator1(object sender, EventArgs e)
        {

        }

        private void numerator2(object sender, EventArgs e)
        {

        }

        private void denominator2(object sender, EventArgs e)
        {

        }

        private void result_num(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numerator1.Text) && !string.IsNullOrEmpty(denominator1.Text) &&
                !string.IsNullOrEmpty(numerator2.Text) && !string.IsNullOrEmpty(denominator2.Text) &&
                !string.IsNullOrEmpty(SelectedOperation))
            {
                DoCalculation(SelectedOperation);
            }
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numerator1 = Convert.ToInt32(textBox1.Text);
            int denominator1 = Convert.ToInt32(textBox2.Text);
            int numerator2 = Convert.ToInt32(textBox3.Text);
            int denominator2 = Convert.ToInt32(textBox4.Text);

            string operation = comboBox1.Text;

            Fraction fraction1 = new Fraction(numerator1, denominator1);
            Fraction fraction2 = new Fraction(numerator2, denominator2);

            Fraction result;

            switch (operation)
            {
                case "+":
                    result = fraction1 + fraction2;
                    break;
                case "-":
                    result = fraction1 - fraction2;
                    break;
                case "*":
                    result = fraction1 * fraction2;
                    break;
                case "/":
                    result = fraction1 / fraction2;
                    break;
                default:
                    MessageBox.Show("Please select an operation.");
                    return;
            }

            resultNumerator.Text = result.Numerator.ToString();
            resultDenominator.Text = result.Denominator.ToString();
        }
        private void DoCalculation(string operation)
        {

        }
    }

}
