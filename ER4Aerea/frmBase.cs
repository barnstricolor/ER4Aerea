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
    public partial class frmBase : Form
    {
        public Repositorio repositorio { get; set; }
        public Dominio dominio {get;set;}

        public frmBase()
        {
            InitializeComponent();
        }
        public virtual void btnFechar_Click(object sender, EventArgs e)
        {
        }

        public virtual void btnGravar_Click(object sender, EventArgs e)
        {
        }

        public virtual void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
