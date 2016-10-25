using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardExample01
{
    static class Main_
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Calculadora screen = new Calculadora();
            screen.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(screen);
        }
    }
}
