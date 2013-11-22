using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    public class CancelarReservaController
    {
        private frmCancelarReserva tela;

        public static CancelarReservaController criar(){
            return new CancelarReservaController();
        }

        public void mostrarTela(Form mdi)
        {
            tela = criarTela(mdi);
            tela.ShowDialog();
        }

        protected frmCancelarReserva criarTela(Form mdi)
        {
            frmCancelarReserva tela = new frmCancelarReserva();
            tela.dcbCliente.Click += new EventHandler(this.carregarCliente);
            tela.btnPesquisar.Click += new EventHandler(this.pesquisar);
            tela.btnCancelar.Click += new EventHandler(this.cancelar);
            return tela;
        }

        protected void carregarCliente(object sender, EventArgs e)
        {

            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            HashSet<Dominio> lista = clienteRepositorio.obterTodos();
            carregarDataCombo(lista, (ComboBox)sender);
        }

        protected void pesquisar(object sender, EventArgs e) {
            tela.grd.Rows.Clear();
            if (tela.dcbCliente.SelectedValue.ToString() == null){
                 MessageBox.Show("Selecione o Cliente");
                return;
            }
            int idCliente = Convert.ToInt32(tela.dcbCliente.SelectedValue.ToString());
            ReservaRepositorio repositorio = new ReservaRepositorio();
            HashSet<Reserva> reservas = repositorio.obterByCliente(idCliente);
            carregarGrid(reservas, tela.grd);

        }

        protected void cancelar(object sender, EventArgs e)
        {
            if (tela.grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Reserva");
                return;
            }

            if (MessageBox.Show("Deseja cancelar a Reserva?", "Cancelar Reserva", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            ReservaRepositorio repositorio = new ReservaRepositorio();
            int idReserva =(int)tela.grd.SelectedRows[0].Cells[0].Value;
            repositorio.excluir(idReserva);
            pesquisar(null, null);

        }
        protected void carregarDataCombo(HashSet<Dominio> lista, ComboBox dcb)
        {
            Hashtable table = new Hashtable();
            foreach (Dominio dominio in lista)
            {
                Cliente cliente = (Cliente)dominio;
                table.Add(cliente.id, cliente.nome);
            }
            dcb.DataSource = new BindingSource(table, null);
            dcb.DisplayMember = "Value";
            dcb.ValueMember = "Key";
        }
        protected void carregarGrid(HashSet<Reserva> lista, DataGridView grid)
        {            
            foreach (Reserva reserva in lista)
            {
                preencherRow(reserva,grid);
            }
        }
        private void preencherRow(Reserva reserva,DataGridView grid)
        {
            VooRepositorio vooRepositorio = new VooRepositorio();
            Voo voo = vooRepositorio.obterVooByReserva(reserva.id);
            object[] valores = new object[] { 
                reserva.id, 
                reserva.preco, 
                voo.origem.nome,
                voo.destino.nome,
                voo.partida,
                voo.chegada,
                voo.aviao.modelo,
                reserva.assentos};
            grid.Rows.Add(valores);            
        }
    }
}
