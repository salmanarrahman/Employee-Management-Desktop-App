using Design.Forms;
using Design.Forms.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
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
             Application.Run(new Login());
            //Application.Run(new Forms.Manager.ManagerUI());
         //  Application.Run(new Form_Employee());
        }
    }
}
