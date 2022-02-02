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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dark");
            comboBox1.Items.Add("Light");

            if (Program.backColor == "Dark")
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
            } 
            else
            {
                comboBox1.SelectedItem = comboBox1.Items[1];
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Program.backColor = comboBox1.SelectedItem.ToString();
            Program.refreshUI();
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

        private void Settings_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
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
    }
}
