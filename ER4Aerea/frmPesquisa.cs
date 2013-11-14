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
        public Repositorio repo { get; set; }



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

            List<Dominio> lista = repo.obterByFiltroString(txtNomOrigem.Text);

            foreach (var dominio in lista)
            {
                preencherRow(dominio);
            }            
             
        }
        private void preencherRow(Dominio dominio) {

            object[] valores = repo.extrairValores(dominio);

            grd.Rows.Add(valores);
            
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
