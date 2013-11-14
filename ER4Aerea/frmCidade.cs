using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER4Aerea
{
    public partial class frmCidade : Form
    {
        private CidadeRepositorio repositorio = new CidadeRepositorio();
        private Cidade dados;

        public frmCidade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(txtID_CIDADE.Text))
            {
                dados = new Cidade(txtNOM_CIDADE.Text);
            }
            else 
            {
                dados = (Cidade)repositorio.obter(int.Parse(txtID_CIDADE.Text));                                
            }
            
            dados.cep = txtNUM_CEP.Text;            
            repositorio.salvar(dados);
            
            txtID_CIDADE.Text = dados.id.ToString();*/
        }

    }
}
