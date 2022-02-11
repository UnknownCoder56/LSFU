using System;
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
            comboBox1.Items.Add("Images");

            if (Program.backColor == "Dark")
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
                Program.backgroundManager.timer.Enabled = false;
            } 
            else if (Program.backColor == "Light")
            {
                comboBox1.SelectedItem = comboBox1.Items[1];
                Program.backgroundManager.timer.Enabled = false;
            }
            else if (Program.backColor == "Images")
            {
                comboBox1.SelectedItem = comboBox1.Items[2];
                Program.backgroundManager.timer.Enabled = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Program.backColor = comboBox1.SelectedItem.ToString();
            Program.refreshUI();
            WindowManager.showWindow("StartScreen", this);
        }

        private void Settings_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("StartScreen", this);
        }
    }
}
