using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ER4Aerea
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
            //tratamento de erro generico
            Erros erros = new Erros();
            Application.ThreadException += new ThreadExceptionEventHandler(erros.UnhandledThreadExceptionHandler);
            //Application.ThreadException += new ThreadExceptionEventHandler(erros.UnhandledThreadExceptionHandler);

            frmLogin f = new frmLogin();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new frmPrincipal());
        }
    }
}
