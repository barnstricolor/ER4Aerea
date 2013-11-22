using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    class ReservaController:Controller
    {
        public static ReservaController criar() { return new ReservaController(); }
        
        protected frmReserva frmTela { get; set; }

        protected frmReserva tela()
        {
            return frmTela;
        }

        protected override void configurarPesquisaTela(frmPesquisa pesquisaTela, Form mdi)
        {
            pesquisaTela.Text = "Cadastro de Reservas";
        }

        protected override void salvar_Click(object sender, EventArgs e)
        {
            VooRepositorio vooRepositorio = new VooRepositorio();
            Voo voo = (Voo)vooRepositorio.obter(int.Parse(tela().txtVoo.Text));
            ClienteRepositorio clienteRepositorio=new ClienteRepositorio();
            //Cliente cliente = (Cliente)clienteRepositorio.obter(int.Parse(tela().txtCliente.Text));
            UsuarioRepositorio usuarioRepositorio=new UsuarioRepositorio();
            Usuario usuario=(Usuario)usuarioRepositorio.obter(Bd.ID_USUARIO_LOGADO);
            
            Reserva reserva = null;
            if (string.IsNullOrEmpty(tela().txtId.Text))
                reserva = new Reserva(null,int.Parse(tela().txtAssentos.Text),float.Parse(tela().txtValor.Text),voo,usuario);
            else
                reserva = (Reserva)repositorio().obter(int.Parse(tela().txtId.Text));

            repositorio().salvar(reserva);
            tela().Close();
            pesquisaTela.btnPesquisar.PerformClick();
        }

        protected override void editar_Click(object sender, EventArgs e)
        {
            int id = pesquisaTela.getIdDominio();
            Reserva reserva = (Reserva)repositorio().obter(id);

            criarTela();
            tela().txtId.Text = reserva.id.ToString();
            //tela().txtCliente.Text = reserva.cliente.id.ToString();
            tela().txtAssentos.Text = reserva.assentos.ToString();
            tela().txtVoo.Text = reserva.voo.id.ToString();
            tela().txtValor.Text = reserva.preco.ToString();
            tela().ShowDialog();                         
            
        }
       
        protected override Form criarTela() {
            this.frmTela = new frmReserva();
            frmTela.btnSalvar.Click += new EventHandler(this.salvar_Click);
            frmTela.Text = "Cadastro de Reservas";
            return frmTela;
        }

        protected override Repositorio repositorio() {
            return new ReservaRepositorio();
        }
    }
}
