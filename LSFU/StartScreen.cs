using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Hide();
            foreach (Form form in WindowManager.getWindows())
            {
                if (form.Name == "SelectScreen")
                {
                    Point p = Location;
                    form.Location = p;
                    form.Show();
                }
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            foreach (Form form in WindowManager.getWindows()) {
                if (form.Name == "Settings")
                {
                    Point p = Location;
                    form.Location = p;
                    form.Show();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
