using System.Data;

namespace Fraction_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Evaluate the expression in the TextBox using DataTable.Compute method
                DataTable dt = new DataTable();
                string expression = textBox1.Text;
                object result = dt.Compute(expression, "");

                // Display the result in the TextBox
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // Display an error message in the TextBox if an error occurs
                textBox1.Text = "Error";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zero(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void multiplyMultiplication(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void divideDivision(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void minusSubtraction(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void plusAddition(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void number7(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void number8(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void number9(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void number4(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void number5(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void number6(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void number1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void number2(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void number3(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }
    }
}