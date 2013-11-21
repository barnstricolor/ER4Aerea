using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class VooController:Controller
    {
        public static VooController criar() { return new VooController(); }
        
        protected frmVoo frmTela { get; set; }

        protected frmVoo tela()
        {
            return frmTela;
        }

        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Voo";
        }

        protected override void salvar_Click(object sender, EventArgs e)
        {
            CidadeRepositorio cidadeRepositorio=new CidadeRepositorio();
            Cidade origem=(Cidade)cidadeRepositorio.obter((int)tela().dcbOrigem.SelectedValue);
            Cidade destino=(Cidade)cidadeRepositorio.obter((int)(tela().dcbDestino.SelectedValue));
            AviaoRepositorio aviaoRepositorio=new AviaoRepositorio();
            Aviao aviao = (Aviao)aviaoRepositorio.obter((int)tela().dcbAviao.SelectedValue);
            
            Voo voo = null;
            if (string.IsNullOrEmpty(tela().txtId.Text))
                voo = new Voo(aviao,origem,destino,DateTime.Parse(tela().dtpPartida.Text),float.Parse(tela().txtPreco.Text));
            else
                voo = (Voo)repositorio().obter(int.Parse(tela().txtId.Text));

            repositorio().salvar(voo);
            tela().Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }

        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Voo voo = (Voo)repositorio().obter(id);

            criarTela();
            tela().txtId.Text = voo.id.ToString();
            tela().dcbAviao.SelectedValue = voo.aviao.id.ToString();
            tela().dcbOrigem.SelectedValue = voo.origem.id.ToString();
            tela().dcbDestino.SelectedValue = voo.destino.id.ToString();
            tela().txtPreco.Text = voo.preco.ToString();
            tela().dtpPartida.Value = voo.partida;
            tela().dtpChegada.Value = voo.chegada;
            tela().ShowDialog();                         
            
        }
       
        protected override Form criarTela() {
            this.frmTela = new frmVoo();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.Text = "Cadastro de Voo";
            return frmTela;
        }

        protected override Repositorio repositorio() {
            return new VooRepositorio();
        }
    }
}
