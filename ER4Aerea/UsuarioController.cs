using System;
using System.Collections.Generic;
using System.Collections;
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
        private bool validaTela() {
            foreach (Control x in tela().Controls)
            {
                if (x is TextBox)
                {
                    if (((TextBox)x).Name != "txtId")
                        if (string.IsNullOrWhiteSpace(((TextBox)x).Text))
                        {
                            MessageBox.Show("Informe todos os valores");
                            return false;
                        }                        
                }
            }
            return true;

        }
        protected override void salvar_Click(object sender, EventArgs e)
        {
            if (validaTela())
            {

                Usuario usuario = null;
                if (string.IsNullOrEmpty(tela().txtId.Text))
                    usuario = new Usuario();
                else
                    usuario = (Usuario)repositorio().obter(int.Parse(tela().txtId.Text));

                if (tela().dcbCidade.SelectedValue.ToString() != "")
                {
                    CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
                    Cidade cidade = (Cidade)cidadeRepositorio.obter((int)tela().dcbCidade.SelectedValue);
                    usuario.cidade = cidade;
                }

                usuario.nome = tela().txtNome.Text;
                usuario.login = tela().txtLogin.Text;
                usuario.senha = tela().txtSenha.Text;
                usuario.cpf = tela().txtCpf.Text;
                usuario.endereco = tela().txtEndereco.Text;
                usuario.numero = int.Parse(tela().txtNumero.Text);

                repositorio().salvar(usuario);
                tela().Close();
                pesquisaTela.btnPesquisar.PerformClick();
            }
        }

        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Usuario usuario = (Usuario)repositorio().obter(id);

            criarTela();
            carregarCidade(tela().dcbCidade);
            tela().txtId.Text = usuario.id.ToString();
            tela().txtNome.Text = usuario.nome;
            tela().txtLogin.Text = usuario.login;
            tela().txtSenha.Text = usuario.senha;
            tela().txtCpf.Text = usuario.cpf;
            tela().txtEndereco.Text = usuario.endereco;
            tela().txtNumero.Text = usuario.numero.ToString();
            tela().dcbCidade.SelectedValue = usuario.cidade.id;
            tela().ShowDialog();
        }
       
        protected override Form criarTela() {
            this.frmTela = new frmUsuario();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.dcbCidade.Click += new EventHandler(this.carregarCidade);
            frmTela.Text = "Cadastro de Usuários";
            return frmTela;
        }

        protected override Repositorio repositorio() {
            return new UsuarioRepositorio();
        }
        protected void carregarCidade(object sender, EventArgs e)
        {
            CidadeRepositorio repo = new CidadeRepositorio();
            HashSet<Dominio> lista = repo.obterTodos();
            carregarDataCombo(lista, (ComboBox)sender);
        }
        protected void carregarCidade(ComboBox cbo)
        {
            CidadeRepositorio repo = new CidadeRepositorio();
            HashSet<Dominio> lista = repo.obterTodos();
            carregarDataCombo(lista, cbo);
        }
        protected void carregarDataCombo(HashSet<Dominio> lista, ComboBox dcb)
        {
            Hashtable table = new Hashtable();
            foreach (Dominio dominio in lista)
            {
                Cidade cidade = (Cidade)dominio;
                table.Add(cidade.id, cidade.nome);
            }
            dcb.DataSource = new BindingSource(table, null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";
        }

    }
}
