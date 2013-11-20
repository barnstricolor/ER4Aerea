using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    public abstract class Controller
    {
        protected frmPesquisa pesquisaTela { get; set; }

        public void mostrarPesquisa(Form mdi)
        {
            pesquisaTela = criarPesquisaTela(mdi);
            pesquisaTela.Show();
        }
        protected frmPesquisa criarPesquisaTela(Form mdi)
        {
            frmPesquisa pesquisaTela = new frmPesquisa();
            pesquisaTela.MdiParent = mdi;
            pesquisaTela.repositorio = repositorio();
            pesquisaTela.btnNovo.Click += new EventHandler(this.novo_Click);
            pesquisaTela.btnEditar.Click += new EventHandler(this.editar_Click);
            pesquisaTela.btnExcluir.Click += new EventHandler(this.excluir_Click);
            configurarPesquisaTela(pesquisaTela, mdi);
            return pesquisaTela;
        }

        protected abstract void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi);

        protected abstract Repositorio repositorio();

        protected void novo_Click(object sender, EventArgs e)
        {
            criarTela().ShowDialog();
        }

        protected abstract Form criarTela();
        //protected abstract void limpar_Click(object sender, EventArgs e);
        protected abstract void salvar_Click(object sender, EventArgs e);
        protected abstract void editar_Click(object sender, EventArgs e);
        void excluir_Click(object sender, EventArgs e) {
            int id = pesquisaTela.getIdDominio();
            repositorio().excluir(id);
            pesquisaTela.btnPesquisar.PerformClick();
        }
    }
}
