namespace FractionCalculator_GUI
{
    partial class MainForm
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
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.txtResultDen = new System.Windows.Forms.TextBox();
            this.txtResultNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(127, 170);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(145, 23);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "Perform Calculation";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "/";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(129, 46);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(31, 17);
            this.rbAdd.TabIndex = 6;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "+";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(129, 69);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(28, 17);
            this.rbSubtract.TabIndex = 7;
            this.rbSubtract.Text = "-";
            this.rbSubtract.UseVisualStyleBackColor = true;
            this.rbSubtract.CheckedChanged += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(129, 92);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(30, 17);
            this.rbDivide.TabIndex = 8;
            this.rbDivide.Text = "/";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(129, 115);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(29, 17);
            this.rbMultiply.TabIndex = 9;
            this.rbMultiply.Text = "*";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.AcceptsTab = true;
            this.txtNumerator1.Location = new System.Drawing.Point(35, 72);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(21, 20);
            this.txtNumerator1.TabIndex = 1;
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.AcceptsTab = true;
            this.txtDenominator1.Location = new System.Drawing.Point(78, 72);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(21, 20);
            this.txtDenominator1.TabIndex = 2;
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.AcceptsTab = true;
            this.txtDenominator2.Location = new System.Drawing.Point(223, 72);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(21, 20);
            this.txtDenominator2.TabIndex = 4;
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.AcceptsTab = true;
            this.txtNumerator2.Location = new System.Drawing.Point(180, 72);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(21, 20);
            this.txtNumerator2.TabIndex = 3;
            // 
            // txtResultDen
            // 
            this.txtResultDen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtResultDen.Location = new System.Drawing.Point(361, 72);
            this.txtResultDen.Name = "txtResultDen";
            this.txtResultDen.ReadOnly = true;
            this.txtResultDen.Size = new System.Drawing.Size(21, 20);
            this.txtResultDen.TabIndex = 16;
            this.txtResultDen.TabStop = false;
            // 
            // txtResultNum
            // 
            this.txtResultNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtResultNum.Location = new System.Drawing.Point(318, 72);
            this.txtResultNum.Name = "txtResultNum";
            this.txtResultNum.ReadOnly = true;
            this.txtResultNum.Size = new System.Drawing.Size(21, 20);
            this.txtResultNum.TabIndex = 15;
            this.txtResultNum.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "=";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(404, 205);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResultDen);
            this.Controls.Add(this.txtResultNum);
            this.Controls.Add(this.txtDenominator2);
            this.Controls.Add(this.txtNumerator2);
            this.Controls.Add(this.txtDenominator1);
            this.Controls.Add(this.txtNumerator1);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.rbSubtract);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculate);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.TextBox txtResultDen;
        private System.Windows.Forms.TextBox txtResultNum;
        private System.Windows.Forms.Label label7;
    }
}

