using System.Windows.Forms;

namespace LSFU
{
    internal class WindowManager
    {
        static Form[] forms;

        public static Form[] getWindows()
        {
            return forms;
        }

        public static void setWindows(Form[] formsArray)
        {
            forms = formsArray;
        }

        public static void showWindow(string windowName, Form caller)
        {
            caller.Hide();
            foreach (Form form in getWindows())
            {
                if (form.Name == windowName)
                {
                    form.Location = caller.Location;
                    form.Size = caller.Size;
                    form.WindowState = caller.WindowState;
                    form.BringToFront();
                    form.Show();
                }
            }
        }
    }
}
