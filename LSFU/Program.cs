using LSFU.Screens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LSFU
{
    internal static class Program
    {
        public static string backColor = "Images";
        public static BackgroundManager backgroundManager = new BackgroundManager();

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
            SelectScreen select = new SelectScreen();
            Credits credits = new Credits();
            ContactsScreen contacts = new ContactsScreen();
            settings.Show();
            settings.Hide();
            credits.Show();
            credits.Hide();
            select.Show();
            select.Hide();
            start.Show();
            start.Hide();
            contacts.Show();
            contacts.Hide();
            List<Form> forms = new List<Form>
            {
                start,
                settings,
                select,
                credits,
                contacts
            };
            WindowManager.setWindows(forms);
            refreshUI();
            Application.Run(start);
            refreshUI();
        }

        public static void refreshBackground(Image img)
        {
            for (int i = 0; i < WindowManager.getWindows().Count; i++)
            {
                Form window = WindowManager.getWindows()[i];
                window.BackgroundImage = img;
                window.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public static void refreshUI()
        {
            for (int i = 0; i < WindowManager.getWindows().Count; i++)
            {
                if (backColor == "Dark")
                {
                    Form window = WindowManager.getWindows()[i];
                    window.BackColor = Color.Black;
                    window.BackgroundImage = null;
                    foreach (Control c in window.Controls)
                    {
                        if (c is Label)
                        {
                            c.ForeColor = Color.White;
                            c.BackColor = Color.Transparent;
                        }
                        c.Font = new Font("Montserrat", 10, FontStyle.Bold);
                    }
                }
                else if (backColor == "Light")
                {
                    Form window = WindowManager.getWindows()[i];
                    window.BackColor = Color.White;
                    window.BackgroundImage = null;
                    foreach (Control c in window.Controls)
                    {
                        if (c is Label)
                        {
                            c.ForeColor = Color.Black;
                            c.BackColor = Color.Transparent;
                        }
                        c.Font = new Font("Montserrat", 10, FontStyle.Bold);
                    }
                }
                else if (backColor == "Images")
                {
                    Form window = WindowManager.getWindows()[i];
                    foreach (Control c in window.Controls)
                    {
                        if (c is Label)
                        {
                            c.ForeColor = Color.White;
                            c.BackColor = Color.Transparent;
                        }
                        c.Font = new Font("Montserrat", 10, FontStyle.Bold);
                    }
                }
            }
        }
    }
}