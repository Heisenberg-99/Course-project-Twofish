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
    public partial class FileMode : Form
    {
        private string key_phrase = "";

        private TwofishManaged algorithm;
        
        public FileMode()
        {
            InitializeComponent();
            algorithm = new TwofishManaged();
            algorithm.Mode = CipherMode.ECB;
            algorithm.Padding = PaddingMode.ANSIX923;
            algorithm.GenerateIV();
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
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (key_phrase == "")
            {
                MessageBox.Show(this, "Enter your passphrase");
                return;
            }
            if (!File.Exists(LoadFile.Text))
            {
                MessageBox.Show(this, "Input file not found", "Not Found", MessageBoxButtons.OK);
                return;
            }
            if (SaveFile.Text.Length == 0)
            {
                MessageBox.Show(this, "Output filename is incorrect", "Incorrect output filename", MessageBoxButtons.OK);
                return;
            }
            // hashing our password phrase
            /*
             * MD5 (англ. Message Digest 5) — 128-битный алгоритм хеширования, разработанный профессором Рональдом Л. Ривестом из 
             * Массачусетского технологического института (Massachusetts Institute of Technology, MIT) в 1991 году.
             */
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.ASCII.GetBytes(textBoxKeyPhrase.Text);
                md5.TransformFinalBlock(bytes, 0, bytes.Length);
                algorithm.Key = md5.Hash;
            }

            ICryptoTransform encrypt = algorithm.CreateEncryptor();

            using (BinaryReader br = new BinaryReader(new FileStream(LoadFile.Text, System.IO.FileMode.Open, FileAccess.Read)))
            using (FileStream fs = new FileStream(SaveFile.Text, System.IO.FileMode.Create, FileAccess.Write))
            using (CryptoStream cs = new CryptoStream(fs, encrypt, CryptoStreamMode.Write))
            using (BinaryWriter bw = new BinaryWriter(cs))
            {
                byte[] bytes = br.ReadBytes((int)br.BaseStream.Length);
                bytes = encrypt.TransformFinalBlock(bytes, 0, bytes.Length);
                bw.Write(bytes);
            }
            MessageBox.Show(this, "Encrypt sucessfully!");

            if (checkBoxDelete.Checked)
            {
                FileInfo fileInf = new FileInfo(LoadFile.Text);
                if (fileInf.Exists)
                {
                    fileInf.Delete();
                    LoadFile.Text = "";
                    MessageBox.Show(this, "Input file successfully deleted!");
                }
                else
                    MessageBox.Show(this, "Failed to delete the Input file!");
            }
        }
        private void LoadFile_TextChanged(object sender, EventArgs e)
        {

        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (key_phrase == "")
            {
                MessageBox.Show(this, "Enter your passphrase");
                return;
            }
            if (!File.Exists(LoadFile.Text))
            {
                MessageBox.Show(this, "File Not Found", "Error", MessageBoxButtons.OK);
                return;
            }
            if (SaveFile.Text.Length == 0)
            {
                MessageBox.Show(this, "Invalid File Name", "Error", MessageBoxButtons.OK);
                return;
            }
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.ASCII.GetBytes(textBoxKeyPhrase.Text);
                md5.TransformFinalBlock(bytes, 0, bytes.Length);
                algorithm.Key = md5.Hash;
            }

            ICryptoTransform decrypt = algorithm.CreateDecryptor();

            using (FileStream inpStr = new FileStream(LoadFile.Text, System.IO.FileMode.Open, FileAccess.Read))
            using (FileStream outStr = new FileStream(SaveFile.Text, System.IO.FileMode.Create, FileAccess.Write))
            using (CryptoStream cStr = new CryptoStream(inpStr, decrypt, CryptoStreamMode.Read))
            using (MemoryStream mstr = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(outStr))
            {
                cStr.CopyTo(mstr);
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

                bw.Write(bytes_temp);
            }
            MessageBox.Show(this, "Decrypt successfully!");

            if (checkBoxDelete.Checked)
            {
                FileInfo fileInf = new FileInfo(LoadFile.Text);
                if (fileInf.Exists)
                {
                    fileInf.Delete();
                    LoadFile.Text = "";
                    MessageBox.Show(this, "Input file successfully deleted!");
                } else
                    MessageBox.Show(this, "Failed to delete the Input file!");
            }
        }
    }
}