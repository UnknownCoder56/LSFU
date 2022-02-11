using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSFU
{
    public partial class ContactsScreen : Form
    {
        public ContactsScreen()
        {
            InitializeComponent();
            toolTip.SetToolTip(pictureBox1, "Gmail (Click to open page)");
            toolTip.SetToolTip(pictureBox2, "YouTube (Click to open page)");
            toolTip.SetToolTip(pictureBox3, "Discord (Click to open page)");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/?fs=1&to=infinixspaceagency@gmail.com&su=&body=&tf=cm");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7AmQMW8WuC");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCvgm0ClM1IjTcifKdG1qRrA");
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("StartScreen", this);
        }

        private void ContactsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
