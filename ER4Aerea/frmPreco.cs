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
    public partial class frmPreco : Form
    {
        public frmPreco()
        {
            InitializeComponent();
        }

        private void cAD_PRECOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_PRECOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmPreco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_PRECO' table. You can move, or remove it, as needed.
            this.cAD_PRECOTableAdapter.Fill(this.dataSet1.CAD_PRECO);

        }
    }
}
