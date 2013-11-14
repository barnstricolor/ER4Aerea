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

        private void frmPesquisa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Bd persistencia = new Bd();

            string str;
            str = "Select " + codigo +","+ descricao + " from " + tabela + " Where 1=1";
            if (!string.IsNullOrEmpty(txtOrigem.Text))
                str+=" And " + codigo +" = "+txtOrigem.Text;
            if (!string.IsNullOrEmpty(txtNomOrigem.Text))
                str += " And " + descricao + " = LIKE '%" + txtOrigem.Text + "%'";
            
            OleDbDataReader dr = persistencia.obterQuery(str);
            DataTable dt = new DataTable();
            dt.Load(dr);
            grd.DataSource = dt;

            dr.Close();*/
        }

        private void grd_DoubleClick(object sender, EventArgs e)
        {
            /*id_retorno.Text = grd.SelectedRows[0].Cells[0].Value.ToString();
            if (nom_retorno!=null)
                nom_retorno.Text = grd.SelectedRows[0].Cells[1].Value.ToString();
            if (tela != null)
            {
                Bd persistencia = new Bd();
                string str = "("; string s; string[] a; 
                
                str = "Select * from " + tabela;
                if (!string.IsNullOrEmpty(txtOrigem.Text))
                    str += " Where " + codigo + " = " + grd.SelectedRows[0].Cells[0].Value.ToString();

                OleDbDataReader dr = persistencia.obterQuery(str);
                DataTable dt = new DataTable();
                dt.Load(dr);
                foreach (Control c in tela.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Tag != null)
                        {
                            s = ((TextBox)c).Tag.ToString();
                            a = s.Split(',');
                            
                            c.Text = (string) dr[a[0].ToString()].ToString();
                            
                        }
                    }
                }

                
            }
                
            this.Dispose();
            */
        }
    }
}
