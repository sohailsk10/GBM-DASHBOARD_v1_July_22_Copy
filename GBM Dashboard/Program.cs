using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBM_Dashboard
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
            Application.Run(new Main_Form());

           //Application.Run(new XtraForm1());
           //Application.Run(new XtraForm4());
           //Application.Run(new Dashboard_Tab());
           //Application.Run(new Tab());

        }
    }
}
