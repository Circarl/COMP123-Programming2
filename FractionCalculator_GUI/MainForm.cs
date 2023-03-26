using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FractionCalculator_GUI
{
    public partial class MainForm : Form
    {
        private Fraction fraction1 = new Fraction();
        private Fraction fraction2 = new Fraction();
        private string operation = "+";

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            txtNumerator1.KeyPress += Txt_KeyPress;
            txtDenominator1.KeyPress += Txt_KeyPress;
            txtNumerator2.KeyPress += Txt_KeyPress;
            txtDenominator2.KeyPress += Txt_KeyPress;

            rbAdd.CheckedChanged += Rb_CheckedChanged;
            rbSubtract.CheckedChanged += Rb_CheckedChanged;
            rbMultiply.CheckedChanged += Rb_CheckedChanged;
            rbDivide.CheckedChanged += Rb_CheckedChanged;

            txtNumerator1.TabIndex = 0;
            txtDenominator1.TabIndex = 1;
            txtNumerator2.TabIndex = 2;
            txtDenominator2.TabIndex = 3;
            rbAdd.TabIndex = 4;
            rbSubtract.TabIndex = 5;
            rbMultiply.TabIndex = 6;
            rbDivide.TabIndex = 7;
            btn_Calculate.TabIndex = 8;
            txtResultNum.TabIndex = 9;
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operation = radioButton.Text;
                DoCalculation();
            }
        }
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }
        private Fraction DoCalculation()
        {
            int num1 = int.Parse(txtNumerator1.Text);
            int den1 = int.Parse(txtDenominator1.Text);
            int num2 = int.Parse(txtNumerator2.Text);
            int den2 = int.Parse(txtDenominator2.Text);
            Fraction frac1 = new Fraction(num1, den1);
            Fraction frac2 = new Fraction(num2, den2);
            Fraction result = null;
            string operation = "";
            if (rbAdd.Checked)
            {
                operation = "+";
                result = frac1 + frac2;
            }
            else if (rbSubtract.Checked)
            {
                operation = "-";
                result = frac1 - frac2;
            }
            else if (rbMultiply.Checked)
            {
                operation = "*";
                result = frac1 * frac2;
            }
            else if (rbDivide.Checked)
            {
                operation = "/";
                result = frac1 / frac2;
            }

            if (result != null)
            {
                result = SimplifyFraction(result);
                txtResultNum.Text = result.Top.ToString();
                txtResultDen.Text = result.Bottom.ToString();
            }

            return result;
        }

        private Fraction SimplifyFraction(Fraction fraction)
        {
            int gcd = GCD(fraction.Top, fraction.Bottom);
            int top = fraction.Top / gcd;
            int bottom = fraction.Bottom / gcd;
            return new Fraction(top, bottom);
        }

        private int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        //click events for operation buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }
        //preventing non-digit input events 
        private void txtNumerator1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtDenominator1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtNumerator2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void txtDenominator2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }


    }
}
