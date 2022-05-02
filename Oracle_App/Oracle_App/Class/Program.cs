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
            Application.Run(new Form_DBA("DBA2", "DBA2"));
            //Application.Run(new Form_CoSoYTe("CS57", "CS57"));
            //Application.Run(new Form_BacSi("NV5", "NV5"));
            //Application.Run(new Form_BenhNhan("BN0", "BN0"));
            //Application.Run(new Form_ThanhTra("NV32", "NV32"));
            //Application.Run(new Login());
        }
    }
}
