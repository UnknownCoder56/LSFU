using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSFU
{
    internal static class Program
    {
        public static String backColor = "Dark";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartScreen start = new StartScreen();
            Settings settings = new Settings();
            settings.Hide();
            Form[] forms = { start, settings };
            WindowManager.setWindows(forms);
            refreshUI();
            Application.Run(start);
        }

        public static void refreshUI()
        {
            for (int i = 0; i < WindowManager.getWindows().Length; i++)
            {
                if (backColor == "Dark")
                {
                    Form window = WindowManager.getWindows()[i];
                    window.BackColor = Color.Black;
                    foreach (Control c in window.Controls)
                        if (c is Label)
                            c.ForeColor = Color.White;
                }
                else
                {
                    Form window = WindowManager.getWindows()[i];
                    window.BackColor = Color.White;
                    foreach (Control c in window.Controls)
                        if (c is Label)
                            c.ForeColor = Color.Black;
                }
            }
        }
    }
}