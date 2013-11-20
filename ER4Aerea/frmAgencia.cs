using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ER4Aerea
{
    public partial class frmAgencia : Form
    {
        public frmAgencia()
        {
            InitializeComponent();
        }
        
        
        private void frmReserva_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void frmReserva_Resize(object sender, EventArgs e)
        {
            tlp.Width = this.Width-15;
            tlp.Height = this.Height - 15;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {



        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }


    }
}
