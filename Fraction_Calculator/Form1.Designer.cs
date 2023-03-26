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
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(138, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 23);
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
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(222, 55);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(23, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // txtDenom1
            // 
            this.txtDenom1.AcceptsTab = true;
            this.txtDenom1.Location = new System.Drawing.Point(72, 55);
            this.txtDenom1.Name = "txtDenom1";
            this.txtDenom1.Size = new System.Drawing.Size(23, 20);
            this.txtDenom1.TabIndex = 3;
            // 
            // txtDenom2
            // 
            this.txtDenom2.Location = new System.Drawing.Point(269, 55);
            this.txtDenom2.Name = "txtDenom2";
            this.txtDenom2.Size = new System.Drawing.Size(23, 20);
            this.txtDenom2.TabIndex = 4;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(150, 34);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(31, 17);
            this.rbAdd.TabIndex = 5;
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
            this.rbSubtract.TabIndex = 6;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "-";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(150, 78);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(30, 17);
            this.rbDivide.TabIndex = 7;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "/";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(150, 101);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(29, 17);
            this.rbMultiply.TabIndex = 8;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "*";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 192);
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
    }
}

