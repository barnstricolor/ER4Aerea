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
    public partial class frmAssento : Form
    {
        public frmAssento()
        {
            InitializeComponent();
        }

        private void cAD_ASSENTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_ASSENTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmAssento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_ASSENTO' table. You can move, or remove it, as needed.
            this.cAD_ASSENTOTableAdapter.Fill(this.dataSet1.CAD_ASSENTO);

        }

        private void nOM_OCUPANTETextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
