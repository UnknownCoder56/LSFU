using System;
using System.Windows.Forms;

namespace LSFU
{
    public partial class SelectScreen : Form
    {
        public SelectScreen()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("StartScreen", this);
        }

        private void SelectScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
