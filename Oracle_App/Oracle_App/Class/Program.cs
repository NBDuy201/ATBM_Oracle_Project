using Oracle_App;
using Oracle_App.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Admin("DBA_BV", "DBA_BV"));
            Application.Run(new Form_CoSoYTe("CS57", "CS57"));
            //Application.Run(new Login());
        }
    }
}
