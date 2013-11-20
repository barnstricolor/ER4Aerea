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
            if (string.IsNullOrEmpty(tela().txtID.Text))
                cliente = new Cliente(tela().txtNome.Text);
            else
                cliente = (Cliente)repositorio().obter(int.Parse(tela().txtID.Text));

            CidadeRepositorio cidadeRepositorio= new CidadeRepositorio();
            Cidade cidade = (Cidade)cidadeRepositorio.obter(int.Parse(tela().txtCidade.Text));

            cliente.nome = tela().txtNome.Text;
            cliente.bairro = tela().txtBairro.Text;
            cliente.celular = tela().txtCel.Text;
            cliente.cep = tela().txtCep.Text;
            cliente.cidade = cidade;
            cliente.cpf = tela().txtCpf.Text;
            cliente.email = tela().txtEmail.Text;
            cliente.endereco = tela().txtEndereco.Text;
            cliente.ocupacao = tela().txtOcup.Text;
            cliente.renda = int.Parse(tela().txtRenda.Text);
            if (tela().chkMasculino.Checked)
                cliente.sexo = "M";
            else
                cliente.sexo = "F";
            if (tela().chkReceb.Checked)
                cliente.promocao = "S";
            else
                cliente.promocao = "N";
            if (tela().chkEsp.Checked)
                cliente.especial = "S";
            else
                cliente.especial = "N";

            cliente.numero = int.Parse(tela().txtNum.Text);
            cliente.telefone = tela().txtTel.Text;
            cliente.rg = tela().txtRg.Text;         

            repositorio().salvar(cliente);
            tela().Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }
        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Cliente cliente = (Cliente)repositorio().obter(id);

            criarTela();
            tela().txtID.Text = cliente.id.ToString();
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
