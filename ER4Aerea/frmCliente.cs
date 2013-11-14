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
    public partial class frmCliente : Form
    {
        Bd persistencia;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void cAD_CLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_CLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_CLIENTE' table. You can move, or remove it, as needed.
            this.cAD_CLIENTETableAdapter.Fill(this.dataSet1.CAD_CLIENTE);

        }

        private void iD_CLIENTETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cod_cli1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ende_cli_Click(object sender, EventArgs e)
        {

        }

        private void cod_cli_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void email_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void feminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void receive_em_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fax_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cont_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void ncont_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void cel_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void fixo_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void dta_nasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rg_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void cep_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_cli_Click(object sender, EventArgs e)
        {

        }

        private void bai_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void cod_cli1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cid_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void end_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void nEnd_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void nom_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_end_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void ende_cli_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {   
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
