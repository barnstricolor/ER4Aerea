using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }
        private void frmTeste_MouseMove(object sender, MouseEventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            this.Text  = x + " - " + y;
        }
        private void frmTeste_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show(button1.Left.ToString());
        }
        private void frmTeste_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Location = new Point(e.X, e.Y);
        }

        private void frmTeste_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            button1.Location= new Point(control.Size.Width - (button1.Width*101), control.Size.Height - button1.Height-10);
            
        }
    }
}
