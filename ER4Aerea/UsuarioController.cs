using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class UsuarioController:Controller
    {
        public static UsuarioController criar() { return new UsuarioController(); }
        
        protected frmUsuario frmTela { get; set; }

        protected frmUsuario tela() {
            return frmTela;
        }

        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Usuários";
        }
        protected override void salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;
            if (string.IsNullOrEmpty(tela().txtId.Text))
                usuario = new Usuario();
            else
                usuario = (Usuario)repositorio().obter(int.Parse(tela().txtId.Text));

            usuario.nome = tela().txtNome.Text;
            usuario.login = tela().txtLogin.Text;
            usuario.senha = tela().txtSenha.Text;

            repositorio().salvar(usuario);
            tela().Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }

        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Usuario usuario = (Usuario)repositorio().obter(id);

            criarTela();
            tela().txtId.Text = usuario.id.ToString();
            tela().txtNome.Text = usuario.nome;
            tela().txtLogin.Text = usuario.login;
            tela().txtSenha.Text = usuario.senha;
            tela().ShowDialog();
        }
       
        protected override Form criarTela() {
            this.frmTela = new frmUsuario();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.Text = "Cadastro de Usuários";
            return frmTela;
        }

        protected override Repositorio repositorio() {
            return new UsuarioRepositorio();
        }
    }
}
