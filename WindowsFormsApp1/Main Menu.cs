using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutPrograToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileMode fm = new FileMode();
            fm.ShowDialog();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextMode tm = new TextMode();
            tm.ShowDialog();
        }

        private void encryptionDecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
