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
    public partial class frmVoo : Form
    {
        public frmVoo()
        {
            InitializeComponent();
        }

        private void cAD_VOOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_VOOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmVoo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_VOO' table. You can move, or remove it, as needed.
            this.cAD_VOOTableAdapter.Fill(this.dataSet1.CAD_VOO);

        }

        private void qTD_PASSAGEIROSTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
