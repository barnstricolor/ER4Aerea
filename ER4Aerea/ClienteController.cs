using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class ClienteController:Controller
    {
        public static ClienteController criar() { return new ClienteController(); }
        
        protected frmCliente frmTela { get; set; }

        protected frmCliente tela()
        {
            return frmTela;
        }
        
        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Clientes";
        }
        
        protected override void salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            if (string.IsNullOrEmpty(tela().txtId.Text))
                cliente = new Cliente(tela().txtNome.Text, false);
            else
                cliente = (Cliente)repositorio().obter(int.Parse(tela().txtId.Text));

            cliente.nome = tela().txtNome.Text;
            repositorio().salvar(cliente);
            tela().Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }
        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Cliente cliente = (Cliente)repositorio().obter(id);

            criarTela();
            tela().txtId.Text = cliente.id.ToString();
            tela().txtNome.Text = cliente.nome;
            tela().ShowDialog();
        }
        protected override Form criarTela()
        {
            this.frmTela = new frmCliente();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.Text = "Cadastro de Clientes";
            return frmTela;
        }

        protected override Repositorio repositorio()
        {
            return new ClienteRepositorio();
        }
    }
}
