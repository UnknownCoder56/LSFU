using System.Collections.Generic;
using System.Windows.Forms;

namespace LSFU
{
    internal class WindowManager
    {
        static List<Form> forms;

        public static List<Form> getWindows()
        {
            return forms;
        }

        public static void setWindows(List<Form> formsArray)
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

        public static void showMyWindow(Form form, Form caller)
        {
            caller.Hide();
            form.Location = caller.Location;
            form.Size = caller.Size;
            form.WindowState = caller.WindowState;
            form.BringToFront();
            form.Show();
        }
    }
}
