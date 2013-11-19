using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class AviaoController:Controller
    {
        public static AviaoController criar() { return new AviaoController(); }
        
        protected frmAviao frmTela { get; set; }

        protected frmAviao tela() {
            return frmTela;
        }

        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Avião";
        }

        protected override void salvar_Click(object sender, EventArgs e)
        {
            Aviao aviao = null;
            if (string.IsNullOrEmpty(tela().txtId.Text))
                aviao = new Aviao(tela().txtModelo.Text, int.Parse(tela().txtAssento.Text));
            else
                aviao = (Aviao)repositorio().obter(int.Parse(tela().txtId.Text));

            aviao.modelo = tela().txtModelo.Text;
            aviao.assentos = int.Parse(tela().txtAssento.Text);
            repositorio().salvar(aviao);
            tela().Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }

        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Aviao aviao = (Aviao)repositorio().obter(id);

            criarTela();
            tela().txtId.Text = aviao.id.ToString();
            tela().txtModelo.Text = aviao.modelo;
            tela().txtAssento.Text = aviao.assentos.ToString();
            tela().ShowDialog();
        }
       
        protected override Form criarTela() {
            this.frmTela = new frmAviao();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.Text = "Cadastro de Avião";
            return frmTela;
        }

        protected override Repositorio repositorio() {
            return new AviaoRepositorio();
        }
    }
}
