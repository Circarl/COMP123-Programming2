using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void DoCalculation(string operation)
        {
            int num1 = int.Parse(numerator1.Text);
            int den1 = int.Parse(denominator1.Text);
            int num2 = int.Parse(numerator2.Text);
            int den2 = int.Parse(denominator2.Text);
            int resultNum, resultDen;

            switch (operation)
            {
                case "+":
                    resultNum = num1 * den2 + num2 * den1;
                    resultDen = den1 * den2;
                    break;
                case "-":
                    resultNum = num1 * den2 - num2 * den1;
                    resultDen = den1 * den2;
                    break;
                case "*":
                    resultNum = num1 * num2;
                    resultDen = den1 * den2;
                    break;
                case "/":
                    resultNum = num1 * den2;
                    resultDen = den1 * num2;
                    break;
                default:
                    resultNum = 0;
                    resultDen = 0;
                    break;
            }

            resultNumerator.Text = resultNum.ToString();
            resultDenominator.Text = resultDen.ToString();

        }

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
    }

}
