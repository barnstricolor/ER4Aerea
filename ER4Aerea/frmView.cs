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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.VW_POSICAO_VOO' table. You can move, or remove it, as needed.
            this.VW_POSICAO_VOOTableAdapter.Fill(this.DataSet1.VW_POSICAO_VOO);
            // TODO: This line of code loads data into the 'dataSet2.VW_POSICAO_VOO' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DataSet1.CLIENTE' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
        }

    }
}
