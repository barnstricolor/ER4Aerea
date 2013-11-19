using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ER4Aerea
{
    public partial class frmAgencia : Form
    {
        public frmAgencia()
        {
            InitializeComponent();
        }
        
        
        private void frmReserva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_TRECHO' table. You can move, or remove it, as needed.
            //this.cAD_TRECHOTableAdapter.Fill(this.dataSet1.CAD_TRECHO);

            this.WindowState = FormWindowState.Maximized;

        }

        

        private void frmReserva_Resize(object sender, EventArgs e)
        {
            tlp.Width = this.Width-15;
            tlp.Height = this.Height - 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa();
            frm.id_retorno=txtOrigem;
            frm.nom_retorno = txtNomOrigem;
            frm.codigo = "ID_CIDADE";
            frm.descricao = "NOM_CIDADE";
            frm.tabela = "CAD_CIDADE";
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa();
            frm.id_retorno = txtCliente;
            frm.nom_retorno = txtNomCliente;
            frm.codigo = "ID_CLIENTE";
            frm.descricao = "NOM_CLIENTE";
            frm.tabela = "CAD_CLIENTE";
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa();
            frm.id_retorno = txtDestino;
            frm.nom_retorno = txtNomDestino;
            frm.codigo = "ID_CIDADE";
            frm.descricao = "NOM_CIDADE";
            frm.tabela = "CAD_CIDADE";
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Email email = new Email();

            email.enviar("hdr_ricardo@hotmail.com");
         
        }

        private void button5_Click(object sender, System.EventArgs e)
        {  
            
            //Voo voo = new Voo();
            
            //voo.origem = int.Parse(txtOrigem.Text);
            //voo.destino = int.Parse(txtDestino.Text);
            //voo.partida = DateTime.Parse(dtpPartida.Text);
            //voo.chegada = DateTime.Parse(dtpChegada.Text);


            /*OleDbDataReader dr = voo.listar();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdVoo.DataSource = dt;
            */

        }


    }
}
