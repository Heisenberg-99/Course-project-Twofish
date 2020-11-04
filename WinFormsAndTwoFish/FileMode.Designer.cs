namespace WindowsFormsApp1
{
    partial class FileMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadFile = new System.Windows.Forms.TextBox();
            this.SaveFile = new System.Windows.Forms.TextBox();
            this.BrowseLoad = new System.Windows.Forms.Button();
            this.BrowseSave = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.textBoxKeyPhrase = new System.Windows.Forms.TextBox();
            this.buttonGenKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxKeyPhraseConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxShowPhraseConfirm = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPhrase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(82, 82);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(476, 20);
            this.LoadFile.TabIndex = 2;
            this.LoadFile.TextChanged += new System.EventHandler(this.LoadFile_TextChanged);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(82, 108);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(476, 20);
            this.SaveFile.TabIndex = 3;
            // 
            // BrowseLoad
            // 
            this.BrowseLoad.Location = new System.Drawing.Point(564, 80);
            this.BrowseLoad.Name = "BrowseLoad";
            this.BrowseLoad.Size = new System.Drawing.Size(224, 23);
            this.BrowseLoad.TabIndex = 4;
            this.BrowseLoad.Text = "Browse";
            this.BrowseLoad.UseVisualStyleBackColor = true;
            this.BrowseLoad.Click += new System.EventHandler(this.BrowseLoad_Click);
            // 
            // BrowseSave
            // 
            this.BrowseSave.Location = new System.Drawing.Point(564, 106);
            this.BrowseSave.Name = "BrowseSave";
            this.BrowseSave.Size = new System.Drawing.Size(224, 23);
            this.BrowseSave.TabIndex = 5;
            this.BrowseSave.Text = "Browse";
            this.BrowseSave.UseVisualStyleBackColor = true;
            this.BrowseSave.Click += new System.EventHandler(this.BrowseSave_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(82, 134);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(128, 29);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(216, 134);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(128, 28);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // textBoxKeyPhrase
            // 
            this.textBoxKeyPhrase.Location = new System.Drawing.Point(82, 23);
            this.textBoxKeyPhrase.Name = "textBoxKeyPhrase";
            this.textBoxKeyPhrase.PasswordChar = '*';
            this.textBoxKeyPhrase.Size = new System.Drawing.Size(476, 20);
            this.textBoxKeyPhrase.TabIndex = 8;
            this.textBoxKeyPhrase.TextChanged += new System.EventHandler(this.textBoxKeyPhrase_TextChanged);
            // 
            // buttonGenKey
            // 
            this.buttonGenKey.Location = new System.Drawing.Point(685, 23);
            this.buttonGenKey.Name = "buttonGenKey";
            this.buttonGenKey.Size = new System.Drawing.Size(103, 23);
            this.buttonGenKey.TabIndex = 9;
            this.buttonGenKey.Text = "Generate key";
            this.buttonGenKey.UseVisualStyleBackColor = true;
            this.buttonGenKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key phrase";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(564, 135);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(224, 28);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Location = new System.Drawing.Point(369, 134);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(176, 29);
            this.checkBoxDelete.TabIndex = 13;
            this.checkBoxDelete.Text = "Delete Encrypt/Decrypt file";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(685, 53);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(103, 23);
            this.buttonConfirm.TabIndex = 14;
            this.buttonConfirm.Text = "Confirm phrase";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxKeyPhraseConfirm
            // 
            this.textBoxKeyPhraseConfirm.Location = new System.Drawing.Point(82, 53);
            this.textBoxKeyPhraseConfirm.Name = "textBoxKeyPhraseConfirm";
            this.textBoxKeyPhraseConfirm.PasswordChar = '*';
            this.textBoxKeyPhraseConfirm.Size = new System.Drawing.Size(476, 20);
            this.textBoxKeyPhraseConfirm.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key phrase confirm";
            // 
            // checkBoxShowPhraseConfirm
            // 
            this.checkBoxShowPhraseConfirm.AutoSize = true;
            this.checkBoxShowPhraseConfirm.Location = new System.Drawing.Point(564, 57);
            this.checkBoxShowPhraseConfirm.Name = "checkBoxShowPhraseConfirm";
            this.checkBoxShowPhraseConfirm.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowPhraseConfirm.TabIndex = 23;
            this.checkBoxShowPhraseConfirm.Text = "Show phrase";
            this.checkBoxShowPhraseConfirm.UseVisualStyleBackColor = true;
            this.checkBoxShowPhraseConfirm.CheckedChanged += new System.EventHandler(this.checkBoxShowPhraseConfirm_CheckedChanged);
            // 
            // checkBoxShowPhrase
            // 
            this.checkBoxShowPhrase.AutoSize = true;
            this.checkBoxShowPhrase.Location = new System.Drawing.Point(564, 23);
            this.checkBoxShowPhrase.Name = "checkBoxShowPhrase";
            this.checkBoxShowPhrase.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowPhrase.TabIndex = 22;
            this.checkBoxShowPhrase.Text = "Show phrase";
            this.checkBoxShowPhrase.UseVisualStyleBackColor = true;
            this.checkBoxShowPhrase.CheckedChanged += new System.EventHandler(this.checkBoxShowPhrase_CheckedChanged);
            // 
            // FileMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 162);
            this.Controls.Add(this.checkBoxShowPhraseConfirm);
            this.Controls.Add(this.checkBoxShowPhrase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKeyPhraseConfirm);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGenKey);
            this.Controls.Add(this.textBoxKeyPhrase);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.BrowseSave);
            this.Controls.Add(this.BrowseLoad);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileMode";
            this.Text = "FileMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoadFile;
        private System.Windows.Forms.TextBox SaveFile;
        private System.Windows.Forms.Button BrowseLoad;
        private System.Windows.Forms.Button BrowseSave;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button buttonGenKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKeyPhrase;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxKeyPhraseConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxShowPhraseConfirm;
        private System.Windows.Forms.CheckBox checkBoxShowPhrase;
    }
}