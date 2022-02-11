using System.Drawing;
using System.Threading;
using System.Timers;

namespace LSFU
{
    class BackgroundManager
    {
        public Image currentImage;
        public System.Timers.Timer timer;
        Image[] Images = new Image[6];
        int index = 1;

        public BackgroundManager()
        {
            Images[0] = Properties.Resources.image1;
            Images[1] = Properties.Resources.image2;
            Images[2] = Properties.Resources.image3;
            Images[3] = Properties.Resources.image4;
            Images[4] = Properties.Resources.image5;
            Images[5] = Properties.Resources.image6;
            timer = new System.Timers.Timer(10000);
            timer.Elapsed += onTimedEvent;
            timer.Enabled = true;
        }

        private void onTimedEvent(object source, ElapsedEventArgs e)
        {
            if (Program.backColor == "Images")
            {
                if (index < Images.Length)
                {
                    Thread.Sleep(2000);
                    currentImage = Images[index];
                    Program.refreshBackground(Images[index]);
                    index++;
                }
                else
                {
                    Thread.Sleep(2000);
                    index = 0;
                    currentImage = Images[index];
                    Program.refreshBackground(Images[index]);
                    index++;
                }
            }
        }

        public void fakeUpdate()
        {
            if (Program.backColor == "Images")
            {
                if (index < Images.Length)
                {
                    Thread.Sleep(2000);
                    currentImage = Images[index];
                    Program.refreshBackground(Images[index]);
                    index++;
                }
                else
                {
                    Thread.Sleep(2000);
                    index = 0;
                    currentImage = Images[index];
                    Program.refreshBackground(Images[index]);
                    index++;
                }
            }
        }
    }
}
