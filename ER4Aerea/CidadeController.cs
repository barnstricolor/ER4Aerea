using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class CidadeController
    {
        public static CidadeController criar() { return new CidadeController(); }
        
        protected frmCidade cidadeTela { get; set; }
        protected frmPesquisa pesquisaTela { get; set; }
        public void mostrarPesquisa(Form mdi)
        {
            pesquisaTela = new frmPesquisa();
            pesquisaTela.repositorio = new CidadeRepositorio();
            pesquisaTela.MdiParent = mdi;
            pesquisaTela.btnPesquisar.Click += new EventHandler(this.pesquisa_Click);
            pesquisaTela.btnNovo.Click += new EventHandler(this.novo_Click);
            pesquisaTela.btnEditar.Click += new EventHandler(this.editar_Click);
            pesquisaTela.btnExcluir.Click += new EventHandler(this.excluir_Click);
            pesquisaTela.Show();
        }
        
        void pesquisa_Click(object sender, EventArgs e) {
            //MessageBox.Show("pesuiqsa click");
        }
        void novo_Click(object sender, EventArgs e) {
            cidadeTela = obterCidadeTela();
            cidadeTela.ShowDialog();
        }
        void salvar_Click(object sender, EventArgs e)
        {
            CidadeRepositorio repositorio = new CidadeRepositorio();
            Cidade cidade = null;
            if (string.IsNullOrEmpty(cidadeTela.txtId.Text))
            {
                cidade = new Cidade(cidadeTela.txtNome.Text, cidadeTela.txtCep.Text);
            }
            else 
            {
                cidade = (Cidade)repositorio.obter(int.Parse(cidadeTela.txtId.Text));
                cidade.nome=cidadeTela.txtNome.Text;
                cidade.cep=cidadeTela.txtCep.Text;
            }
            repositorio.salvar(cidade);
            cidadeTela.Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }
        void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDomino();
            CidadeRepositorio repositorio = new CidadeRepositorio();
            Cidade cidade = (Cidade)repositorio.obter(id);

            cidadeTela = obterCidadeTela();
            cidadeTela.txtId.Text = cidade.id.ToString();
            cidadeTela.txtNome.Text = cidade.nome;
            cidadeTela.txtCep.Text = cidade.cep;
            cidadeTela.ShowDialog();
        }
        void excluir_Click(object sender, EventArgs e) {
            int id = pesquisaTela.getIdDomino();
            CidadeRepositorio repositorio = new CidadeRepositorio();
            repositorio.excluir(id);
            pesquisaTela.btnPesquisar.PerformClick();
        }
        protected frmCidade obterCidadeTela() {
            frmCidade cidadeTela = new frmCidade();
            cidadeTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            return cidadeTela;

        }
    }
}
