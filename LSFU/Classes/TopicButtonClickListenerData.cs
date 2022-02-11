using LSFU.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSFU.Classes
{
    class TopicButtonClickListenerData
    {
        public string Name { get; set; }
        public string Data { get; set; }
        public Form Caller { get; set; }

        public TopicButtonClickListenerData(string name, string data, Form caller)
        {
            Name = name;
            Data = data;
            Caller = caller;
        }

        public void OnClick(object sender, EventArgs e)
        {
            TopicLearnScreen screen = new TopicLearnScreen(Name, Data);
            screen.Show();
            screen.Hide();
            var _ = WindowManager.getWindows();
            _.Add(screen);
            WindowManager.setWindows(_);
            Program.refreshUI();
            WindowManager.showMyWindow(screen, Caller);
        }
    }
}
