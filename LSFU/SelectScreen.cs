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
    public partial class SelectScreen : Form
    {
        public SelectScreen()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            foreach (Form form in WindowManager.getWindows())
            {
                if (form.Name == "StartScreen")
                {
                    Point p = Location;
                    form.Location = p;
                    form.Show();
                }
            }
        }

        private void SelectScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
