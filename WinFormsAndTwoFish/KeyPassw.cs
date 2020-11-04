using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KeyPassword : Form
    {
        public KeyPassword()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int passwLength = rand.Next((int)numericUpDownMinLenth.Value, (int)numericUpDownMaxLenth.Value); // генерируем длину пароля
            string digits = "0123456789";
            string letterUpCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letterDownCase = "abcdefghijklmnopqrstuvwxyz";
            string specSymbols = "!@#$%^&*()_-+=`[]{}~/,?<>";
            int numDigits = (int)numericUpDownDigits.Value;
            int numLetterUpCase = (int)numericUpDownUpCase.Value;
            int numLetterDownCase = (int)numericUpDownLowCase.Value;
            int numSpecSymbols = (int)numericUpDownSpecSymb.Value;
            List<string> password_confusion = new List<string>();                   //какие элементы доступны
            List<string> temp_password_confusion = new List<string>();
            StringBuilder gen_phrase = new StringBuilder();                         //генерируемая фраза

            int temp_numDigits = numDigits;
            int temp_numLetterUpCase = numLetterUpCase;
            int temp_numLetterDownCase = numLetterDownCase;
            int temp_numSpecSymbols = numSpecSymbols;

            if (numDigits > 0) { password_confusion.Add("hasDigits"); temp_password_confusion.Add("hasDigits"); }
            if (numLetterUpCase > 0) { password_confusion.Add("hasNumLetterUpCase"); temp_password_confusion.Add("hasNumLetterUpCase"); }
            if (numLetterDownCase > 0) { password_confusion.Add("hasNumLetterDownCase"); temp_password_confusion.Add("hasNumLetterDownCase"); }
            if (numSpecSymbols > 0) { password_confusion.Add("hasNumSpecSymbols"); temp_password_confusion.Add("hasNumSpecSymbols"); }

            while (temp_numDigits + temp_numLetterUpCase + temp_numLetterDownCase + temp_numSpecSymbols > 0)
            {
                int type = rand.Next(temp_password_confusion.Count);

                if (temp_password_confusion[type] == "hasDigits" && temp_numDigits > 0)
                {
                    gen_phrase.Append(digits[rand.Next(digits.Length)]);                //заполняем случайными числами
                    temp_numDigits--;
                    if (temp_numDigits == 0) temp_password_confusion.Remove("hasDigits");
                }
                else if (temp_password_confusion[type] == "hasNumLetterUpCase" && temp_numLetterUpCase > 0)
                {
                    gen_phrase.Append(letterUpCase[rand.Next(letterUpCase.Length)]);        //заполняем случайными заглавными буквами
                    temp_numLetterUpCase--;
                    if (temp_numLetterUpCase == 0) temp_password_confusion.Remove("hasNumLetterUpCase");
                }
                else if (temp_password_confusion[type] == "hasNumLetterDownCase" && temp_numLetterDownCase > 0)
                {
                    gen_phrase.Append(letterDownCase[rand.Next(letterDownCase.Length)]);    //заполняем случайными малыми буквами
                    temp_numLetterDownCase--;
                    if (temp_numLetterDownCase == 0) temp_password_confusion.Remove("hasNumLetterDownCase");
                }
                else 
                {
                    gen_phrase.Append(specSymbols[rand.Next(specSymbols.Length)]);          //заполняем случайными символами
                    temp_numSpecSymbols--;
                    if (temp_numSpecSymbols == 0) temp_password_confusion.Remove("hasNumSpecSymbols");
                }
            }
            
            int difference = passwLength - (numDigits + numLetterUpCase + numLetterDownCase + numSpecSymbols); //оставшиеся символы
            while (difference != 0)
            {
                int type = rand.Next(password_confusion.Count);

                if (password_confusion[type] == "hasDigits")
                    gen_phrase.Append(digits[rand.Next(digits.Length)]);                //заполняем случайными числами
                else if (password_confusion[type] == "hasNumLetterUpCase")
                    gen_phrase.Append(letterUpCase[rand.Next(letterUpCase.Length)]);    //заполняем случайными заглавными буквами
                else if (password_confusion[type] == "hasNumLetterDownCase")
                    gen_phrase.Append(letterDownCase[rand.Next(letterDownCase.Length)]); //заполняем случайными малыми буквами
                else if (password_confusion[type] == "hasNumSpecSymbols")
                    gen_phrase.Append(specSymbols[rand.Next(specSymbols.Length)]); //заполняем случайными символами

                difference--;
            }
            
            textBoxPassword.Text = gen_phrase.ToString();
        }
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0)
                MessageBox.Show("Enter a non-empty password!");
            else if (textBoxPassword.Text.Length < (int)numericUpDownMinLenth.Value || textBoxPassword.Text.Length > (int)numericUpDownMaxLenth.Value)
                MessageBox.Show("Enter the password of the length that belongs to the interval!");
            else
            {
                MessageBox.Show("The phrase is successfully entered");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void numericUpDownMinLenth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMinLenth.Value > numericUpDownMaxLenth.Value)
            {
                numericUpDownMaxLenth.Value = numericUpDownMinLenth.Value;
            }
        }
        private void numericUpDownMaxLenth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMaxLenth.Value < numericUpDownMinLenth.Value)
            {
                numericUpDownMinLenth.Value = numericUpDownMaxLenth.Value;
            }
        }
        private void numericUpDownDigits_ValueChanged(object sender, EventArgs e)
        {
            //проверка на превышение максимума
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) > numericUpDownMaxLenth.Value)
                numericUpDownDigits.Value = numericUpDownDigits.Value - 1;
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) != 0)
                ButtonGenerate.Enabled = true;
            else
                ButtonGenerate.Enabled = false;
        }
        private void numericUpDownUpCase_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) > numericUpDownMaxLenth.Value)
                numericUpDownUpCase.Value = numericUpDownUpCase.Value - 1;
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) != 0)
                ButtonGenerate.Enabled = true;
            else
                ButtonGenerate.Enabled = false;
        }
        private void numericUpDownLowCase_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) > numericUpDownMaxLenth.Value)
                numericUpDownLowCase.Value = numericUpDownLowCase.Value - 1;
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) != 0)
                ButtonGenerate.Enabled = true;
            else
                ButtonGenerate.Enabled = false;
        }
        private void numericUpDownSpecSymb_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) > numericUpDownMaxLenth.Value)
                numericUpDownSpecSymb.Value = numericUpDownSpecSymb.Value - 1;
            if ((numericUpDownDigits.Value + numericUpDownUpCase.Value +
                 numericUpDownLowCase.Value + numericUpDownSpecSymb.Value) != 0)
                ButtonGenerate.Enabled = true;
            else
                ButtonGenerate.Enabled = false;
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void KeyPassword_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPhrase_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = (textBoxPassword.PasswordChar == '*') ? textBoxPassword.PasswordChar = '\0' : textBoxPassword.PasswordChar = '*';
        }
    }
}