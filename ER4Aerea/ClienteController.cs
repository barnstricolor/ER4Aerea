using System;
using System.Collections.Generic;
using System.Collections;
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
            dcb.DataSource = new BindingSource(table,null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";
        }
        
        private bool validaTela() {
            foreach (Control x in tela().Controls)
            {
                if (x is TextBox)
                {
                    if (((TextBox)x).Name.ToUpper() != "txtId".ToUpper())
                        if (string.IsNullOrWhiteSpace(((TextBox)x).Text))
                        {
                            MessageBox.Show("Informe todos os valores");
                            x.Focus();
                            return false;
                        }
                }
                else if (x is ComboBox) {
                    if (((ComboBox)x).SelectedIndex == -1)
                    {
                        MessageBox.Show("Informe todos os valores");
                        x.Focus();
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

                Cliente cliente = null;
                if (string.IsNullOrEmpty(tela().txtID.Text))
                    cliente = new Cliente(tela().txtNome.Text);
                else
                    cliente = (Cliente)repositorio().obter(int.Parse(tela().txtID.Text));

                if (tela().dcbCidade.SelectedIndex != -1)
                {
                    CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
                    Cidade cidade = (Cidade)cidadeRepositorio.obter((int)tela().dcbCidade.SelectedValue);
                    cliente.cidade = cidade;
                }

                cliente.nome = tela().txtNome.Text;
                cliente.bairro = tela().txtBairro.Text;
                cliente.celular = tela().txtCel.Text;
                cliente.cep = tela().txtCep.Text;
                cliente.cpf = tela().txtCpf.Text;
                cliente.email = tela().txtEmail.Text;
                cliente.endereco = tela().txtEndereco.Text;
                cliente.ocupacao = tela().txtOcup.Text;
                cliente.renda = float.Parse(tela().txtRenda.Text);
                if (tela().chkMasculino.Checked)
                    cliente.sexo = "M";
                else
                    cliente.sexo = "F";
                if (tela().chkReceb.Checked)
                    cliente.promocao = "S" ;
                else
                    cliente.promocao = "N";
                if (tela().chkEsp.Checked)
                    cliente.especial = "S";
                else
                    cliente.especial = "N";
                cliente.desconto = float.Parse(tela().txtDesconto.Text);
                cliente.numero = tela().txtNum.Text;
                cliente.telefone = tela().txtTel.Text;
                cliente.rg = tela().txtRg.Text;

                repositorio().salvar(cliente);
                tela().Close();
                pesquisaTela.btnPesquisar.PerformClick();
            }
        }
        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Cliente cliente = (Cliente)repositorio().obter(id);

            criarTela();
            carregarCidade(tela().dcbCidade);
            tela().txtID.Text = cliente.id.ToString();
            tela().txtNome.Text = cliente.nome;
            tela().txtBairro.Text = cliente.bairro;
            tela().txtCel.Text = cliente.celular;
            tela().txtCep.Text = cliente.cep;
            tela().dcbCidade.SelectedValue = cliente.cidade.id;
            tela().txtCpf.Text = cliente.cpf;
            tela().txtEmail.Text = cliente.email;
            tela().txtEndereco.Text = cliente.endereco;
            tela().txtNum.Text = cliente.numero.ToString();
            tela().txtOcup.Text = cliente.ocupacao;
            tela().txtRenda.Text = cliente.renda.ToString();
            tela().txtRg.Text = cliente.rg;
            tela().txtTel.Text = cliente.telefone;
            
            if (cliente.especial == "S") 
                tela().chkEsp.Checked = true;
            
            if (cliente.promocao == "S")
                tela().chkReceb.Checked = true;

            if (cliente.sexo == "M")
                tela().chkMasculino.Checked = true;
            else
                tela().chkFeminino.Checked = true;
            tela().txtDesconto.Text = cliente.desconto.ToString();
            tela().ShowDialog();
        }
        protected override Form criarTela()
        {
            this.frmTela = new frmCliente();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.dcbCidade.Click += new EventHandler(this.carregarCidade);
            frmTela.Text = "Cadastro de Clientes";
            return frmTela;
        }

        protected override Repositorio repositorio()
        {
            return new ClienteRepositorio();
        }
    }
}
