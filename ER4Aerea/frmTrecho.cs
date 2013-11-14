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
    public partial class frmTrecho : Form
    {
        public frmTrecho()
        {
            InitializeComponent();
        }

        private void cAD_TRECHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_TRECHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmTrecho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_TRECHO' table. You can move, or remove it, as needed.
            this.cAD_TRECHOTableAdapter.Fill(this.dataSet1.CAD_TRECHO);

        }
    }
}
