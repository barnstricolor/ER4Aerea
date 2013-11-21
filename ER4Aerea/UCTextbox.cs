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
                if (this.Tag.ToString() == "N")
                    if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                        e.Handled = true;
                if (this.Tag.ToString() == "D")
                    if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ','))
                        e.Handled = true;
                //if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar)) 
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
        protected override void OnLeave(EventArgs e)
        {
            if (this.Tag != null)
            {
                if (this.Tag.ToString() == "D")
                {
                    float cubic = 0;
                    bool isNumeric = float.TryParse(this.Text, out cubic);
                    if (isNumeric)
                    {
                        this.Text = cubic.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Informe o Valor no Formato Monetário");
                        this.Focus();
                    }
                    
                }
            }
        }
    }
}