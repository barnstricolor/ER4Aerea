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


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
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
            CidadeController controller = CidadeController.criar();
            controller.mostrarPesquisa(this);
        }

        private void assentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aviãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa();
            frm.repositorio = new AviaoRepositorio();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.Show();  
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa();
            //frm.repo = new cliRepositorio();
            frm.MdiParent = this;
            frm.Show();  

        }

        private void preçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void promoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva frm = new frmReserva();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();            

        }

        private void trechoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vôoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmView();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();            

        }

    }
}
