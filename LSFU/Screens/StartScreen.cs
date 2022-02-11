using System;
using System.Windows.Forms;

namespace LSFU
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("SelectScreen", this);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("Settings", this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditsButton_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("Credits", this);
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("ContactsScreen", this);
        }
    }
}
