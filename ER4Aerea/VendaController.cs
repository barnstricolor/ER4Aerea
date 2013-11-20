using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ER4Aerea
{
    public class VendaController
    {
        private frmVenda tela;
        public Voo origem { get; set; }
        public Voo destino { get; set; }
        public int assentos { get; set; }

        public static VendaController criar(){
            return new VendaController();
        }
        public void mostrarTela(Form mdi)
        {
            tela = criarTela(mdi);
            tela.ShowDialog();
        }
        protected frmVenda criarTela(Form mdi)
        {
            frmVenda tela = new frmVenda();
            // tela.MdiParent = mdi;
            tela.dcbCliente.Click += new EventHandler(this.carregarCliente);
            tela.dcbCliente.SelectionChangeCommitted += new EventHandler(this.atualizaValores);
            tela.btnReservar.Click += new EventHandler(this.finalizarVenda);

            //tela.dcbDestino.Click += new EventHandler(this.carregarCidade);
            //tela.btnPesquisar.Click += new EventHandler(this.pesquisarVoos);
            tela.lblAssentos.Text = this.assentos.ToString();
            tela.lblAviaoIda.Text = this.origem.aviao.modelo;
            tela.lblPartidaIda.Text = this.origem.partida.Hour + ":" + this.origem.partida.Minute;
            tela.lblPrecoIda.Text = this.origem.preco.ToString();
            tela.lblAviaoIda.Text = this.origem.aviao.modelo;
            tela.lblPartidaVolta.Text = this.destino.partida.Hour + ":" + this.destino.partida.Minute;
            tela.lblPrecoVolta.Text = this.destino.preco.ToString();
            tela.lblAviaoVolta.Text = this.destino.aviao.modelo;
            tela.Text = "Reserva de Passagem Aérea";
            return tela;
        }
        protected void atualizaValores(object sender, EventArgs e)
        {
            if (tela.dcbCliente.SelectedValue.ToString() != null)
            {
                float total=0, desconto=0, final=0;


                ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
                Cliente cliente = (Cliente)clienteRepositorio.obter((int)tela.dcbCliente.SelectedValue);
                desconto=cliente.getDesconto();

                tela.lblEspecial.Visible = cliente.isEspecial();

                total = origem.preco * assentos + (destino.preco) * assentos;
                
                final=total-desconto;

                tela.lblTotal.Text = total.ToString("C2"); ;
                tela.lblDesconto.Text = desconto.ToString("C2");
                tela.lblPrecoFinal.Text = final.ToString("C2");
            }
            else
            {
                MessageBox.Show("Selecione o Cliente");
            }
        }
        protected void carregarCliente(object sender, EventArgs e){

            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            HashSet<Dominio> lista = clienteRepositorio.obterTodos();
            carregarDataCombo(lista, (ComboBox)sender);
        }
        protected void carregarDataCombo(HashSet<Dominio> lista, ComboBox dcb) { 
            Hashtable table=new Hashtable();
            foreach(Dominio dominio in lista){
                Cliente cliente = (Cliente)dominio;
                table.Add(cliente.id, cliente.nome);
            }
            dcb.DataSource = new BindingSource(table, null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";            
        }
        protected void finalizarVenda(object sender, EventArgs e)
        {            
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = (Cliente)clienteRepositorio.obter((int)tela.dcbCliente.SelectedValue);

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            Usuario usuario = (Usuario)usuarioRepositorio.obter(Bd.ID_USUARIO_LOGADO);

            origem.novaReserva(cliente, assentos, usuario);
            destino.novaReserva(cliente, assentos, usuario);

            VooRepositorio vooRepositorio = new VooRepositorio();
            vooRepositorio.salvar(origem);
            vooRepositorio.salvar(destino);

            tela.Close();
        }        
    }
}
