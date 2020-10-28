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
    public partial class TextMode : Form
    {
        static string key_phrase = "";
        static bool delete_file_flag = false;
        public TextMode()
        {
            InitializeComponent();
        }

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            KeyPassword kp = new KeyPassword();
            if (kp.ShowDialog(this) == DialogResult.OK) textBoxKeyPhrase.Text = kp.textBoxPassword.Text;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpenTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Open Text File";
            od.SupportMultiDottedExtensions = true; //несколько разрешений
            if (od.ShowDialog(this) != DialogResult.OK) return;

            using (StreamReader sr = new StreamReader(od.FileName, Encoding.Default))
            {
                string[] temp_string = new string[0];
                while (!sr.EndOfStream)
                {
                    Array.Resize(ref temp_string, temp_string.Length + 1);
                    temp_string[temp_string.Length - 1] = sr.ReadLine();
                }
                textBoxText.Lines = temp_string;

                MessageBox.Show(this, "The file was uploaded successfully", "Success", MessageBoxButtons.OK);
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Text File";
            sfd.SupportMultiDottedExtensions = true;
            if (sfd.ShowDialog(this) != DialogResult.OK) return;
            
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.Default))
                for (int i = 0; i < textBoxText.Lines.Length; i++)  sw.WriteLine(textBoxText.Lines[i]);

            MessageBox.Show(this, "The file was successfully written", "Success", MessageBoxButtons.OK);
        }

        private void buttonEncryptTextToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Text File";
            sfd.SupportMultiDottedExtensions = true;
            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            //////////////////////////////////
            //тут шифровка
            //////////////////////////////////
            /*
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.Default))
                for (int i = 0; i < textBoxText.Lines.Length; i++) sw.WriteLine(textBoxText.Lines[i]);
            */
            MessageBox.Show(this, "The file was successfully encrypted and saved", "Success encrypt", MessageBoxButtons.OK);
        }

        private void buttonDecryptFileToText_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Open Text File";
            od.SupportMultiDottedExtensions = true; //несколько разрешений
            if (od.ShowDialog(this) != DialogResult.OK) return;

            using (StreamReader sr = new StreamReader(od.FileName, Encoding.Default))
            {
                string[] temp_string = new string[0];
                while (!sr.EndOfStream)
                {
                    Array.Resize(ref temp_string, temp_string.Length + 1);
                    temp_string[temp_string.Length - 1] = sr.ReadLine();
                }
                //////////////////////
                //тут дешифровка
                //////////////////////
                /*
                textBoxText.Lines = temp_string;
                */
            }
            MessageBox.Show(this, "The file was successfully uploaded and decrypted", "Success decrypt", MessageBoxButtons.OK);
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
