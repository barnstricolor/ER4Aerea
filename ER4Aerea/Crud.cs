using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ER4Aerea
{
    public partial class Crud : frmBase
    {
        
        public Crud()
        {
            this.SuspendLayout();
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(713, 389);
            this.Name = "Crud";

            TextBox txt = new TextBox();
            txt.Location = new Point(50, 50);
            txt.Visible = true;
            this.Controls.Add(txt);            
            
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public override void btnFechar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dominio.id.ToString());
            this.Close();

        }

        public override void btnGravar_Click(object sender, EventArgs e)
        {
            repositorio.salvar(dominio);

        }
        public override void btnExcluir_Click(object sender, EventArgs e)
        {
            repositorio.excluir(dominio.id);
        }

    }
}
