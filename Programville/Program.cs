using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programville
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
            do
            {
                if (WindowManager.crUtilizator != null)
                {
                    if (WindowManager.crUtilizator.TipUtilizator == 1)
                        Application.Run(new FrmHomeAdmin());
                    else
                        Application.Run(new FrmHomeScreen());
                }
                else
                {
                    Application.Run(new FrmLogin());
                }


            } while (WindowManager.isActive == true);
        }
    }
}
