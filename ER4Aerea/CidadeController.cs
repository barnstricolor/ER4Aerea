using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class CidadeController:Controller
    {
        public static CidadeController criar() { return new CidadeController(); }
        
        protected frmCidade frmTela { get; set; }

        protected frmCidade tela()
        {
            return frmTela;
        }
        
        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Cidade";
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

                Cidade cidade = null;
                if (string.IsNullOrEmpty(tela().txtId.Text))
                    cidade = new Cidade(tela().txtNome.Text, tela().txtCep.Text);
                else
                    cidade = (Cidade)repositorio().obter(int.Parse(tela().txtId.Text));

                cidade.nome = tela().txtNome.Text;
                cidade.cep = tela().txtCep.Text;
                repositorio().salvar(cidade);
                tela().Close();
                pesquisaTela.btnPesquisar.PerformClick();
            }
        }
        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Cidade cidade = (Cidade)repositorio().obter(id);

            criarTela();
            tela().txtId.Text = cidade.id.ToString();
            tela().txtNome.Text = cidade.nome;
            tela().txtCep.Text = cidade.cep;
            tela().ShowDialog();
        }
        protected override Form criarTela()
        {
            this.frmTela = new frmCidade();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.Text = "Cadastro de Cidade";
            return frmTela;
        }

        protected override Repositorio repositorio()
        {
            return new CidadeRepositorio();
        }
    }
}
