using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

          private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller controller = CidadeController.criar();
            controller.mostrarPesquisa(this);
        }

        private void aviãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller controller = AviaoController.criar();
            controller.mostrarPesquisa(this);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller controller = ClienteController.criar();
            controller.mostrarPesquisa(this);
        }

        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmView();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();            

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller controller = UsuarioController.criar();
            controller.mostrarPesquisa(this);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "ER4Aérea - " + Bd.NOME_USUARIO_LOGADO;
        }

        private void vôoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller controller = VooController.criar();
            controller.mostrarPesquisa(this);
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgenciaController controller = AgenciaController.criar();
            controller.mostrarTela(this);


        }

    }
}
