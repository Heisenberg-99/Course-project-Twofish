namespace WindowsFormsApp1
{
    partial class KeyPassword
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMinLenth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxLenth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDigits = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUpCase = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowCase = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpecSymb = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxShowPhrase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLenth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLenth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecSymb)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(71, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(245, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(15, 247);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(385, 23);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Enabled = false;
            this.ButtonGenerate.Location = new System.Drawing.Point(237, 129);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(163, 97);
            this.ButtonGenerate.TabIndex = 3;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(237, 45);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(163, 53);
            this.ButtonOk.TabIndex = 4;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password restrictions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Digits (0-9)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Uppercase letters (A-Z)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lowercase letters (a-z)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Special symbols";
            // 
            // numericUpDownMinLenth
            // 
            this.numericUpDownMinLenth.Location = new System.Drawing.Point(163, 48);
            this.numericUpDownMinLenth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownMinLenth.Name = "numericUpDownMinLenth";
            this.numericUpDownMinLenth.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownMinLenth.TabIndex = 12;
            this.numericUpDownMinLenth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownMinLenth.ValueChanged += new System.EventHandler(this.numericUpDownMinLenth_ValueChanged);
            // 
            // numericUpDownMaxLenth
            // 
            this.numericUpDownMaxLenth.Location = new System.Drawing.Point(163, 78);
            this.numericUpDownMaxLenth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownMaxLenth.Name = "numericUpDownMaxLenth";
            this.numericUpDownMaxLenth.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownMaxLenth.TabIndex = 13;
            this.numericUpDownMaxLenth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownMaxLenth.ValueChanged += new System.EventHandler(this.numericUpDownMaxLenth_ValueChanged);
            // 
            // numericUpDownDigits
            // 
            this.numericUpDownDigits.Location = new System.Drawing.Point(166, 129);
            this.numericUpDownDigits.Name = "numericUpDownDigits";
            this.numericUpDownDigits.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownDigits.TabIndex = 15;
            this.numericUpDownDigits.ValueChanged += new System.EventHandler(this.numericUpDownDigits_ValueChanged);
            // 
            // numericUpDownUpCase
            // 
            this.numericUpDownUpCase.Location = new System.Drawing.Point(166, 154);
            this.numericUpDownUpCase.Name = "numericUpDownUpCase";
            this.numericUpDownUpCase.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownUpCase.TabIndex = 16;
            this.numericUpDownUpCase.ValueChanged += new System.EventHandler(this.numericUpDownUpCase_ValueChanged);
            // 
            // numericUpDownLowCase
            // 
            this.numericUpDownLowCase.Location = new System.Drawing.Point(166, 180);
            this.numericUpDownLowCase.Name = "numericUpDownLowCase";
            this.numericUpDownLowCase.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownLowCase.TabIndex = 17;
            this.numericUpDownLowCase.ValueChanged += new System.EventHandler(this.numericUpDownLowCase_ValueChanged);
            // 
            // numericUpDownSpecSymb
            // 
            this.numericUpDownSpecSymb.Location = new System.Drawing.Point(166, 206);
            this.numericUpDownSpecSymb.Name = "numericUpDownSpecSymb";
            this.numericUpDownSpecSymb.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownSpecSymb.TabIndex = 18;
            this.numericUpDownSpecSymb.ValueChanged += new System.EventHandler(this.numericUpDownSpecSymb_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Min count";
            // 
            // checkBoxShowPhrase
            // 
            this.checkBoxShowPhrase.AutoSize = true;
            this.checkBoxShowPhrase.Location = new System.Drawing.Point(322, 14);
            this.checkBoxShowPhrase.Name = "checkBoxShowPhrase";
            this.checkBoxShowPhrase.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowPhrase.TabIndex = 21;
            this.checkBoxShowPhrase.Text = "Show phrase";
            this.checkBoxShowPhrase.UseVisualStyleBackColor = true;
            this.checkBoxShowPhrase.CheckedChanged += new System.EventHandler(this.checkBoxShowPhrase_CheckedChanged);
            // 
            // KeyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 277);
            this.Controls.Add(this.checkBoxShowPhrase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownSpecSymb);
            this.Controls.Add(this.numericUpDownLowCase);
            this.Controls.Add(this.numericUpDownUpCase);
            this.Controls.Add(this.numericUpDownDigits);
            this.Controls.Add(this.numericUpDownMaxLenth);
            this.Controls.Add(this.numericUpDownMinLenth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "KeyPassword";
            this.Text = "KeyPassword Editor";
            this.Load += new System.EventHandler(this.KeyPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLenth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLenth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecSymb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMinLenth;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxLenth;
        private System.Windows.Forms.NumericUpDown numericUpDownDigits;
        private System.Windows.Forms.NumericUpDown numericUpDownUpCase;
        private System.Windows.Forms.NumericUpDown numericUpDownLowCase;
        private System.Windows.Forms.NumericUpDown numericUpDownSpecSymb;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPhrase;
    }
}