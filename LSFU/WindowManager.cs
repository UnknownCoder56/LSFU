using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
