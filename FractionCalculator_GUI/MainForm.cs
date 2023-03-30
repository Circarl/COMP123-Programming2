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

            txtNumerator1.TabIndex = 5;
            txtDenominator1.TabIndex = 6;
            rbAdd.TabIndex = 0;
            rbAdd.KeyDown += rbAdd_KeyDown;
            rbSubtract.TabIndex = 1;
            rbSubtract.KeyDown += rbSubtract_KeyDown;
            rbMultiply.TabIndex = 2;
            rbMultiply.KeyDown += rbMultiply_KeyDown;
            rbDivide.TabIndex = 3;
            rbDivide.KeyDown += rbDivide_KeyDown;
            txtNumerator2.TabIndex = 7;
            txtDenominator2.TabIndex = 8;
            btn_Calculate.TabIndex = 9;
            txtResultNum.TabIndex = 10;



        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
        private void rbAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Control[] radioButtons = new Control[] { rbAdd, rbSubtract, rbMultiply, rbDivide };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i] == sender && i < radioButtons.Length - 1)
                    {
                        radioButtons[i + 1].Focus();
                        e.Handled = true;
                        break;
                    }
                }
            }
        }
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operation = radioButton.Text;
                //DoCalculation();
            }
            else
            {
                // Set the focus to the next radio button in the group
                Control[] radioButtons = new Control[] { rbAdd, rbSubtract, rbMultiply, rbDivide };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i] == radioButton && i < radioButtons.Length - 1)
                    {
                        radioButtons[i + 1].Focus();
                        break;
                    }
                }
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
        //Simply result of fraction
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
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    DoCalculation();
        //}

        //private void btnSubtract_Click(object sender, EventArgs e)
        //{
        //    DoCalculation();
        //}

        //private void btnMultiply_Click(object sender, EventArgs e)
        //{
        //    DoCalculation();
        //}

        //private void btnDivide_Click(object sender, EventArgs e)
        //{
        //    DoCalculation();
        //}

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

        private void txtDenominator1_TextChanged(object sender, EventArgs e)
        {

        }
        //Spacebar keypress on the radio buttons option
        private void rbAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rbAdd.Checked = true;
                e.Handled = true;
            }
        }

        private void rbSubtract_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rbSubtract.Checked = true;
                e.Handled = true;
            }

        }

        private void rbDivide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rbDivide.Checked = true;
                e.Handled = true;
            }
        }

        private void rbMultiply_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                rbMultiply.Checked = true;
                e.Handled = true;
            }
        }

        private void btn_Calculate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rbSubtract_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Control[] radioButtons = new Control[] { rbAdd, rbSubtract, rbMultiply, rbDivide };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i] == sender && i < radioButtons.Length - 1)
                    {
                        radioButtons[i + 1].Focus();
                        e.Handled = true;
                        break;
                    }
                }
            }
        }

        private void rbDivide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Control[] radioButtons = new Control[] { rbAdd, rbSubtract, rbMultiply, rbDivide };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i] == sender && i < radioButtons.Length - 1)
                    {
                        radioButtons[i + 1].Focus();
                        e.Handled = true;
                        break;
                    }
                }
            }
        }

        private void rbMultiply_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Control[] radioButtons = new Control[] { rbAdd, rbSubtract, rbMultiply, rbDivide };
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i] == sender && i < radioButtons.Length - 1)
                    {
                        radioButtons[i + 1].Focus();
                        e.Handled = true;
                        break;
                    }
                }
            }
        }
    }
}
