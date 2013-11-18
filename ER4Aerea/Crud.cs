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
        
        public Crud(Repositorio repo)
        {
            int horizontal = 60;
            this.repositorio = repo;
            this.SuspendLayout();
            this.Name = "Crud";

            for (int i = 1; i < repositorio.colunas().GetLength(0); i++)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(10, horizontal);
                lbl.Name = "lbl" + repositorio.colunas()[i,2];
                lbl.Size = new System.Drawing.Size(500, 20);
                lbl.TabIndex = i;
                lbl.Text = repositorio.colunas()[i,2];
                this.Controls.Add(lbl);
                horizontal += 20;
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(10, horizontal);
                txt.Name = "txt" + repositorio.colunas()[i,2];
                txt.Size = new System.Drawing.Size(500, 20);
                txt.TabIndex = i+1;
                txt.Text=repositorio.colunas()[i,2]
                this.Controls.Add(txt);
                horizontal += 30;
            }            

            this.ResumeLayout(false);
            this.PerformLayout();
            
        }
        public override void btnFechar_Click(object sender, EventArgs e)
        {
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
