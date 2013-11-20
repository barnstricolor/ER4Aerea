using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ER4Aerea
{
    class Erros
    {
        public void UnhandledThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            this.HandleUnhandledException(e.Exception);
        }

        public void HandleUnhandledException(Exception e)
        {
            if (MessageBox.Show("Um erro inesperado ocorreu. Continuar ?",
                Application.ProductName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
