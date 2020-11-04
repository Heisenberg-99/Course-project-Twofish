namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fucnctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPrograToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fucnctionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Program";
            // 
            // fucnctionsToolStripMenuItem
            // 
            this.fucnctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptionDecryptionToolStripMenuItem});
            this.fucnctionsToolStripMenuItem.Name = "fucnctionsToolStripMenuItem";
            this.fucnctionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fucnctionsToolStripMenuItem.Text = "Fucnctions";
            // 
            // encryptionDecryptionToolStripMenuItem
            // 
            this.encryptionDecryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textToolStripMenuItem});
            this.encryptionDecryptionToolStripMenuItem.Name = "encryptionDecryptionToolStripMenuItem";
            this.encryptionDecryptionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.encryptionDecryptionToolStripMenuItem.Text = "Encryption / Decryption";
            this.encryptionDecryptionToolStripMenuItem.Click += new System.EventHandler(this.encryptionDecryptionToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPrograToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.referenceToolStripMenuItem.Text = "Reference";
            // 
            // aboutPrograToolStripMenuItem
            // 
            this.aboutPrograToolStripMenuItem.Name = "aboutPrograToolStripMenuItem";
            this.aboutPrograToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutPrograToolStripMenuItem.Text = "About program";
            this.aboutPrograToolStripMenuItem.Click += new System.EventHandler(this.aboutPrograToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 142);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPrograToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fucnctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionDecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
    }
}

