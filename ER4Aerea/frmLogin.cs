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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bd persistencia = Bd.Instance;
            if (persistencia.obterConexao()!=null)
            {
                UsuarioRepositorio repositorio = new UsuarioRepositorio();
                Usuario usuario = (Usuario)repositorio.obter(txtNome.Text, txtSenha.Text);
                if (usuario != null)
                {
                    this.DialogResult = DialogResult.OK;
                    Bd.USUARIO_LOGADO = txtNome.Text;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválido!", "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}
