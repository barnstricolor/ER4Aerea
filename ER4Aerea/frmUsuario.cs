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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void cAD_USUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_USUARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_USUARIO' table. You can move, or remove it, as needed.
            this.cAD_USUARIOTableAdapter.Fill(this.dataSet1.CAD_USUARIO);

        }

        private void nOM_SENHALabel_Click(object sender, EventArgs e)
        {

        }
    }
}
