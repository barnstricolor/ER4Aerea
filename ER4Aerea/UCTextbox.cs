using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ER4Aerea
{
    public class UCTextBox : TextBox
    {

        public UCTextBox()
        {

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {

                // save the current caret position

                int pos = this.SelectionStart;

                // insert the upper case character



                this.Text = this.Text.Insert(this.SelectionStart,

                Char.ToUpper(e.KeyChar).ToString());



                // and update the current caret position

                this.SelectionStart = pos + 1;

                e.Handled = true;

            }



            base.OnKeyPress(e);

        }



    }
}