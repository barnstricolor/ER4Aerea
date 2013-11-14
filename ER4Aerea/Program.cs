using System;
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

            frmLogin f = new frmLogin();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new frmPrincipal());
        }
    }
}
