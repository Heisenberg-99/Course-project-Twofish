using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class FileMode : Form
    {
        static string key_phrase = "";
        static bool delete_file_flag = false;
        public FileMode()
        {
            InitializeComponent();
        }

        private void BrowseLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Select file to loading";
            od.SupportMultiDottedExtensions = true;
            if (od.ShowDialog(this) == DialogResult.OK)
                if (SaveFile.Text != od.FileName)
                    LoadFile.Text = od.FileName;
                else
                    MessageBox.Show(this, "Loading/Saving duplicate files selected!", "Loading/Saving duplicate", MessageBoxButtons.OK);
            if (File.Exists(LoadFile.Text) && File.Exists(SaveFile.Text))
            {
                EncryptButton.Enabled = true;
                DecryptButton.Enabled = true;
            }
            else
            {
                EncryptButton.Enabled = false;
                DecryptButton.Enabled = false;
            }
        }

        private void BrowseSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select file to saving";
            sfd.SupportMultiDottedExtensions = true;
            if (sfd.ShowDialog(this) != DialogResult.OK) return;
            if (LoadFile.Text != sfd.FileName)
                SaveFile.Text = sfd.FileName;
            else
                MessageBox.Show(this, "Loading/Saving duplicate files selected!", "Loading/Saving duplicate", MessageBoxButtons.OK);
            if (File.Exists(LoadFile.Text) && File.Exists(SaveFile.Text))
            {
                EncryptButton.Enabled = true;
                DecryptButton.Enabled = true;
            }
            else
            {
                EncryptButton.Enabled = false;
                DecryptButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyPassword kp = new KeyPassword();
            if (kp.ShowDialog(this) == DialogResult.OK) textBoxKeyPhrase.Text = kp.textBoxPassword.Text;
        }

        private void textBoxKeyPhrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxShowPhrase_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKeyPhrase.PasswordChar = (textBoxKeyPhrase.PasswordChar == '*') ? textBoxKeyPhrase.PasswordChar = '\0' : textBoxKeyPhrase.PasswordChar = '*';
        }

        private void checkBoxShowPhraseConfirm_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKeyPhraseConfirm.PasswordChar = (textBoxKeyPhraseConfirm.PasswordChar == '*') ? textBoxKeyPhraseConfirm.PasswordChar = '\0' : textBoxKeyPhraseConfirm.PasswordChar = '*';
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxKeyPhrase.Text == textBoxKeyPhraseConfirm.Text)
            {
                if (textBoxKeyPhrase.Text == "")
                {
                    MessageBox.Show("Key phrase can't be empty");
                    key_phrase = "";
                    return;
                }
                MessageBox.Show("The key phrase was entered successfully");
                key_phrase = textBoxKeyPhrase.Text;
            }
            else
            {
                MessageBox.Show("The key phrase wasn't entered successfully. Phrases don't match.");
                key_phrase = "";
            }
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            delete_file_flag = !delete_file_flag;
        }
    }
}