namespace WindowsFormsApp1
{
    partial class TextMode
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenTextFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonEncryptTextToFile = new System.Windows.Forms.Button();
            this.buttonDecryptFileToText = new System.Windows.Forms.Button();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxKeyPhrase = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKeyPhraseConfirm = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.checkBoxShowPhrase = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPhraseConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key phrase";
            // 
            // buttonOpenTextFile
            // 
            this.buttonOpenTextFile.Location = new System.Drawing.Point(495, 92);
            this.buttonOpenTextFile.Name = "buttonOpenTextFile";
            this.buttonOpenTextFile.Size = new System.Drawing.Size(133, 31);
            this.buttonOpenTextFile.TabIndex = 2;
            this.buttonOpenTextFile.Text = "Open text file";
            this.buttonOpenTextFile.UseVisualStyleBackColor = true;
            this.buttonOpenTextFile.Click += new System.EventHandler(this.buttonOpenTextFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(495, 151);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(133, 32);
            this.buttonSaveToFile.TabIndex = 3;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonEncryptTextToFile
            // 
            this.buttonEncryptTextToFile.Location = new System.Drawing.Point(495, 189);
            this.buttonEncryptTextToFile.Name = "buttonEncryptTextToFile";
            this.buttonEncryptTextToFile.Size = new System.Drawing.Size(133, 32);
            this.buttonEncryptTextToFile.TabIndex = 4;
            this.buttonEncryptTextToFile.Text = "Encrypt text to file";
            this.buttonEncryptTextToFile.UseVisualStyleBackColor = true;
            this.buttonEncryptTextToFile.Click += new System.EventHandler(this.buttonEncryptTextToFile_Click);
            // 
            // buttonDecryptFileToText
            // 
            this.buttonDecryptFileToText.Location = new System.Drawing.Point(495, 227);
            this.buttonDecryptFileToText.Name = "buttonDecryptFileToText";
            this.buttonDecryptFileToText.Size = new System.Drawing.Size(133, 31);
            this.buttonDecryptFileToText.TabIndex = 5;
            this.buttonDecryptFileToText.Text = "Decrypt file to text";
            this.buttonDecryptFileToText.UseVisualStyleBackColor = true;
            this.buttonDecryptFileToText.Click += new System.EventHandler(this.buttonDecryptFileToText_Click);
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.Location = new System.Drawing.Point(495, 12);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(133, 20);
            this.buttonGenerateKey.TabIndex = 6;
            this.buttonGenerateKey.Text = "Generate key";
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(495, 324);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 34);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxKeyPhrase
            // 
            this.textBoxKeyPhrase.Location = new System.Drawing.Point(73, 12);
            this.textBoxKeyPhrase.Name = "textBoxKeyPhrase";
            this.textBoxKeyPhrase.PasswordChar = '*';
            this.textBoxKeyPhrase.Size = new System.Drawing.Size(318, 20);
            this.textBoxKeyPhrase.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(73, 92);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(416, 267);
            this.textBoxText.TabIndex = 10;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Location = new System.Drawing.Point(495, 264);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(125, 53);
            this.checkBoxDelete.TabIndex = 12;
            this.checkBoxDelete.Text = "Delete Encrypt/Decrypt file";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 46);
            this.label4.TabIndex = 19;
            this.label4.Text = "Key phrase confirm";
            // 
            // textBoxKeyPhraseConfirm
            // 
            this.textBoxKeyPhraseConfirm.Location = new System.Drawing.Point(73, 46);
            this.textBoxKeyPhraseConfirm.Name = "textBoxKeyPhraseConfirm";
            this.textBoxKeyPhraseConfirm.PasswordChar = '*';
            this.textBoxKeyPhraseConfirm.Size = new System.Drawing.Size(318, 20);
            this.textBoxKeyPhraseConfirm.TabIndex = 18;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(495, 46);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(133, 20);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Confirm phrase";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // checkBoxShowPhrase
            // 
            this.checkBoxShowPhrase.AutoSize = true;
            this.checkBoxShowPhrase.Location = new System.Drawing.Point(401, 15);
            this.checkBoxShowPhrase.Name = "checkBoxShowPhrase";
            this.checkBoxShowPhrase.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowPhrase.TabIndex = 20;
            this.checkBoxShowPhrase.Text = "Show phrase";
            this.checkBoxShowPhrase.UseVisualStyleBackColor = true;
            this.checkBoxShowPhrase.CheckedChanged += new System.EventHandler(this.checkBoxShowPhrase_CheckedChanged);
            // 
            // checkBoxShowPhraseConfirm
            // 
            this.checkBoxShowPhraseConfirm.AutoSize = true;
            this.checkBoxShowPhraseConfirm.Location = new System.Drawing.Point(401, 49);
            this.checkBoxShowPhraseConfirm.Name = "checkBoxShowPhraseConfirm";
            this.checkBoxShowPhraseConfirm.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowPhraseConfirm.TabIndex = 21;
            this.checkBoxShowPhraseConfirm.Text = "Show phrase";
            this.checkBoxShowPhraseConfirm.UseVisualStyleBackColor = true;
            this.checkBoxShowPhraseConfirm.CheckedChanged += new System.EventHandler(this.checkBoxShowPhraseConfirm_CheckedChanged);
            // 
            // TextMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 371);
            this.Controls.Add(this.checkBoxShowPhraseConfirm);
            this.Controls.Add(this.checkBoxShowPhrase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKeyPhraseConfirm);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxKeyPhrase);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGenerateKey);
            this.Controls.Add(this.buttonDecryptFileToText);
            this.Controls.Add(this.buttonEncryptTextToFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonOpenTextFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TextMode";
            this.Text = "TextMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenTextFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonEncryptTextToFile;
        private System.Windows.Forms.Button buttonDecryptFileToText;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxKeyPhrase;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKeyPhraseConfirm;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.CheckBox checkBoxShowPhrase;
        private System.Windows.Forms.CheckBox checkBoxShowPhraseConfirm;
    }
}