using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    public class VendaController
    {
        private frmVenda tela;

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
            //tela.dcbDestino.Click += new EventHandler(this.carregarCidade);
            //tela.btnPesquisar.Click += new EventHandler(this.pesquisarVoos);
            return tela;
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
        
    }
}
