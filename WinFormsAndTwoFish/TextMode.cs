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
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class TextMode : Form
    {
        static string key_phrase = "";
        private TwofishManaged algorithm;

        public TextMode()
        {
            InitializeComponent();
            algorithm = new TwofishManaged();
            algorithm.Mode = CipherMode.ECB;
            algorithm.Padding = PaddingMode.ANSIX923;
            algorithm.GenerateIV();
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
            if (key_phrase == "")
            {
                MessageBox.Show(this, "Enter your passphrase");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Text File";
            sfd.SupportMultiDottedExtensions = true;
            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.ASCII.GetBytes(key_phrase);
                md5.TransformFinalBlock(bytes, 0, bytes.Length);
                algorithm.Key = md5.Hash;
            }

            ICryptoTransform encrypt = algorithm.CreateEncryptor();

            using (FileStream fs = new FileStream(sfd.FileName, System.IO.FileMode.Create, FileAccess.Write))
            using (CryptoStream cs = new CryptoStream(fs, encrypt, CryptoStreamMode.Write))
            using (BinaryWriter bw = new BinaryWriter(cs))
            {
                byte[] bytes = Encoding.Default.GetBytes(textBoxText.Text);
                bytes = encrypt.TransformFinalBlock(bytes, 0, bytes.Length);
                bw.Write(bytes);
            }
            MessageBox.Show(this, "The file was successfully encrypted and saved", "Success encrypt", MessageBoxButtons.OK);

            if (checkBoxDelete.Checked)
            {
                textBoxText.Text = "";
                MessageBox.Show(this, "Input text successfully deleted!");
            }
        }

        private void buttonDecryptFileToText_Click(object sender, EventArgs e)
        {
            if (key_phrase == "")
            {
                MessageBox.Show(this, "Enter your passphrase");
                return;
            }
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Open Text File";
            od.SupportMultiDottedExtensions = true; //несколько разрешений

            if (od.ShowDialog(this) != DialogResult.OK) return;

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.ASCII.GetBytes(key_phrase);
                md5.TransformFinalBlock(bytes, 0, bytes.Length);
                algorithm.Key = md5.Hash;
            }

            ICryptoTransform decrypt = algorithm.CreateDecryptor();

            using (FileStream inpStr = new FileStream(od.FileName, System.IO.FileMode.Open, FileAccess.Read))
            using (FileStream outStr = new FileStream(od.FileName+"_temp", System.IO.FileMode.Create, FileAccess.Write))
            using (MemoryStream mstr = new MemoryStream())
            {
                using (CryptoStream cStr = new CryptoStream(inpStr, decrypt, CryptoStreamMode.Read))
                {
                    cStr.CopyTo(mstr);
                }
                byte[] bytes = mstr.ToArray();
                try
                {
                    bytes = decrypt.TransformFinalBlock(bytes, 0, bytes.Length);
                }
                catch (CryptographicException)
                {
                    MessageBox.Show(this, "Error!!!", "Error", MessageBoxButtons.OK);
                    return;
                }
                //for correct
                byte[] bytes_temp = new byte[bytes.Length];

                int k = 0;
                for (int i = 0; i < bytes_temp.Length; i++)
                {
                    if (bytes[i] != 0 && bytes[i] != 16)
                    {
                        bytes_temp[k] = bytes[i];
                        k++;
                    }
                }
                bytes_temp[k] = 0;
                Array.Resize(ref bytes_temp, k);

                textBoxText.Text = Encoding.Default.GetString(bytes_temp, 0, bytes_temp.Length);
            }
            MessageBox.Show(this, "The file was successfully uploaded and decrypted", "Success decrypt", MessageBoxButtons.OK);
            
            if (checkBoxDelete.Checked)
            {
                FileInfo fileInf = new FileInfo(od.FileName);
                if (fileInf.Exists)
                {
                    fileInf.Delete();
                    MessageBox.Show(this, "Input file successfully deleted!");
                }
                else
                    MessageBox.Show(this, "Failed to delete the Input file!");
            }
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
    }
}