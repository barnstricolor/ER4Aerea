using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class UCTextBox : System.Windows.Forms.TextBox
    {

        public UCTextBox()
        {

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (this.Tag != null)
            {
                if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) 
                    e.Handled = true;
            }
            else
            {
            
                if (Char.IsLetter(e.KeyChar))
                {

                    int pos = this.SelectionStart;

                    this.Text = this.Text.Insert(this.SelectionStart,

                    Char.ToUpper(e.KeyChar).ToString());

                    this.SelectionStart = pos + 1;

                    e.Handled = true;
                }

                base.OnKeyPress(e);
            }
        }

    }
}