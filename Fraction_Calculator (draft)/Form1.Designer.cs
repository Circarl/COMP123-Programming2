namespace Fraction_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtDenom1 = new System.Windows.Forms.TextBox();
            this.txtDenom2 = new System.Windows.Forms.TextBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.label_first = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox1_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(12, 143);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(382, 37);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Perform Calculation";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.DoCalculation);
            // 
            // txtNum1
            // 
            this.txtNum1.AcceptsTab = true;
            this.txtNum1.Location = new System.Drawing.Point(28, 55);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(23, 20);
            this.txtNum1.TabIndex = 1;
            //this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.AcceptsTab = true;
            this.txtNum2.Location = new System.Drawing.Point(222, 55);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(23, 20);
            this.txtNum2.TabIndex = 7;
            // 
            // txtDenom1
            // 
            this.txtDenom1.AcceptsTab = true;
            this.txtDenom1.Location = new System.Drawing.Point(72, 55);
            this.txtDenom1.Name = "txtDenom1";
            this.txtDenom1.Size = new System.Drawing.Size(23, 20);
            this.txtDenom1.TabIndex = 2;
            // 
            // txtDenom2
            // 
            this.txtDenom2.AcceptsTab = true;
            this.txtDenom2.Location = new System.Drawing.Point(269, 55);
            this.txtDenom2.Name = "txtDenom2";
            this.txtDenom2.Size = new System.Drawing.Size(23, 20);
            this.txtDenom2.TabIndex = 8;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(150, 34);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(31, 17);
            this.rbAdd.TabIndex = 3;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "+";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(150, 55);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(28, 17);
            this.rbSubtract.TabIndex = 4;
            this.rbSubtract.Text = "-";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(150, 78);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(30, 17);
            this.rbDivide.TabIndex = 5;
            this.rbDivide.Text = "/";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(150, 101);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(29, 17);
            this.rbMultiply.TabIndex = 6;
            this.rbMultiply.Text = "*";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // label_first
            // 
            this.label_first.AutoSize = true;
            this.label_first.Location = new System.Drawing.Point(42, 20);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(26, 13);
            this.label_first.TabIndex = 9;
            this.label_first.Text = "First";
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(238, 20);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(44, 13);
            this.label_second.TabIndex = 10;
            this.label_second.Text = "Second";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(353, 20);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(37, 13);
            this.label_result.TabIndex = 11;
            this.label_result.Text = "Result";
            // 
            // textBox1_result
            // 
            this.textBox1_result.Location = new System.Drawing.Point(343, 55);
            this.textBox1_result.Name = "textBox1_result";
            this.textBox1_result.Size = new System.Drawing.Size(51, 20);
            this.textBox1_result.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label_first);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.rbSubtract);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.txtDenom2);
            this.Controls.Add(this.txtDenom1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtDenom1;
        private System.Windows.Forms.TextBox txtDenom2;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.Label label_first;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox1_result;
        private System.Windows.Forms.Label label1;
    }
}

