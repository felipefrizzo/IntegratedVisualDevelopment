using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForm01
{
    static class Principal
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormCalc screen = new FormCalc();
            screen.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(screen);
        }
    }
}
