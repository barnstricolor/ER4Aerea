using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ER4Aerea
{
    public partial class frmPesquisa : Form
    {
        public Repositorio repositorio { get; set; }
        
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string tabela { get; set; }
        
        public Form tela { get; set; }

        public System.Windows.Forms.TextBox id_retorno { get; set; }
        public System.Windows.Forms.TextBox nom_retorno { get; set; }

        public frmPesquisa()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grd.Rows.Clear();
            List<Dominio> lista = repositorio.obterByFiltroString(txtNomOrigem.Text);
            foreach (var dominio in lista)
            {
                preencherRow(dominio);
            }            
        }
        private void preencherRow(Dominio dominio) {
            object[] valores = repositorio.extrairValores(dominio);
            grd.Rows.Add(valores);
        }
        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Crud crud = new Crud();
            crud.repositorio = this.repositorio;
            //crud.dominio = new Cidade("Teste","14100");
            //crud.Text = "Cidade";
            crud.dominio = repositorio.obter(int.Parse(grd.Rows[e.RowIndex].Cells[0].Value.ToString()));
            crud.ShowDialog();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
