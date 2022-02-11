using LSFU.Classes;
using LSFU.Screens;
using System;
using System.Windows.Forms;

namespace LSFU
{
    public partial class SelectScreen : Form
    {
        public SelectScreen()
        {
            InitializeComponent();
            int i = 0;
            Topic[] topics = new ViewModel().getTopics();

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    if (x == 3 && y == 1) i--;
                    RoundedButton button1 = new RoundedButton();
                    button1.Text = topics[i].Name;
                    TopicButtonClickListenerData data = new TopicButtonClickListenerData(topics[i].Name, topics[i].Data, this);
                    button1.Click += data.OnClick;
                    button1 = SetButtonProperties(button1);
                    tableLayoutPanel1.Controls.Add(button1, y, x);
                    i++;
                }
            }

            RoundedButton button = new RoundedButton();
            button.Text = "Back to Home";
            button.Click += button8_Click;
            button = SetButtonProperties(button);
            tableLayoutPanel1.Controls.RemoveAt(7);
            tableLayoutPanel1.Controls.Add(button, 1, 3);
        }

        private RoundedButton SetButtonProperties(RoundedButton button)
        {
            button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button.BackColor = System.Drawing.Color.MediumSlateBlue;
            button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            button.BorderColor = System.Drawing.Color.DarkSlateBlue;
            button.BorderRadius = 10;
            button.BorderSize = 2;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(3, 3);
            button.Size = new System.Drawing.Size(274, 39);
            button.TabIndex = 8;
            button.TextColor = System.Drawing.Color.White;
            button.UseVisualStyleBackColor = false;
            return button;
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
