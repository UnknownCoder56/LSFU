using System;
using System.Windows.Forms;

namespace LSFU
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("StartScreen", this);
        }

        private void Credits_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
