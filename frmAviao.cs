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
    public partial class frmAviao : Form
    {
        public frmAviao()
        {
            InitializeComponent();
        }

        private void cAD_AVIAOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cAD_AVIAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmAviao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAD_AVIAO' table. You can move, or remove it, as needed.
            this.cAD_AVIAOTableAdapter.Fill(this.dataSet1.CAD_AVIAO);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Ok!");
        }
    }
}
