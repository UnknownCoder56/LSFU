using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSFU.Screens
{
    public partial class TopicLearnScreen : Form
    {
        public string TopicName;
        public string TopicData;

        public TopicLearnScreen(string name, string data)
        {
            InitializeComponent();
            TopicName = name;
            TopicData = data;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            WindowManager.showWindow("SelectScreen", this);
        }

        private void TopicLearnScreen_Shown(object sender, EventArgs e)
        {
            headingLabel.Text = TopicName;
            dataLabel.Text = TopicData;
        }

        private void TopicLearnScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
