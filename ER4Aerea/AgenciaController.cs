using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    public class AgenciaController
    {
        private frmAgencia tela;

        public static AgenciaController criar(){
            return new AgenciaController();
        }

        public void mostrarTela(Form mdi)
        {
            tela = criarTela(mdi);
            tela.Show
();
        }
        
        protected frmAgencia criarTela(Form mdi)
        {
            frmAgencia tela = new frmAgencia();
            tela.MdiParent = mdi;
            tela.dcbOrigem.Click += new EventHandler(this.carregarCidade);
            tela.dcbDestino.Click += new EventHandler(this.carregarCidade);
            tela.btnPesquisar.Click += new EventHandler(this.pesquisarVoos);
            tela.btnReservar.Click += new EventHandler(this.mostrarTelaVenda);
            return tela;
        }


        protected void mostrarTelaVenda(object sender, EventArgs e)
        {
            VendaController ctl = new VendaController();
            ctl.mostrarTela(tela.MdiParent);
        }
        protected void carregarCidade(object sender, EventArgs e){

            CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
            HashSet<Dominio> lista = cidadeRepositorio.obterTodos();
            carregarDataCombo(lista, (ComboBox)sender);
        }
        protected void carregarDataCombo(HashSet<Dominio> lista, ComboBox dcb) { 
            Hashtable table=new Hashtable();
            foreach(Dominio dominio in lista){
                Cidade cidade=(Cidade)dominio;
                table.Add(cidade.id, cidade.nome);
            }
            dcb.DataSource = new BindingSource(table, null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";            
        }
        protected void pesquisarVoos(object sender, EventArgs e)
        {   
            int assentos=(int)tela.txtAssentos.Value;

            tela.grdIda.Rows.Clear();
            tela.grdVolta.Rows.Clear();

            CidadeRepositorio cidadeRepositorio = new CidadeRepositorio();
            Cidade origem=(Cidade)cidadeRepositorio.obter(int.Parse(tela.dcbOrigem.SelectedValue.ToString()));
            Cidade destino = (Cidade)cidadeRepositorio.obter(int.Parse(tela.dcbDestino.SelectedValue.ToString()));
            Agencia agencia = new Agencia();

            HashSet<Voo> voosIda = agencia.obterVoos(tela.dtpPartida.Value, origem, destino, assentos);
            carregarGrid(voosIda, tela.grdIda);
            if (tela.optIdaVolta.Checked)
            {
                HashSet<Voo> voosVolta = agencia.obterVoos(tela.dtpChegada.Value, destino, origem, assentos);
                carregarGrid(voosVolta, tela.grdVolta);
            }
        }
        protected void carregarGrid(HashSet<Voo> lista, DataGridView grid)
        {            
            foreach (Voo voo in lista)
            {
                preencherRow(voo,grid);
            }
        }
        private void preencherRow(Voo voo,DataGridView grid)
        {


            object[] valores = new object[] { voo.id, voo.preco, voo.aviao.modelo, voo.assentosDisponiveis(), voo.partida.Hour + ":" + voo.partida.Minute };
            grid.Rows.Add(valores);
            
        }


    }
}
