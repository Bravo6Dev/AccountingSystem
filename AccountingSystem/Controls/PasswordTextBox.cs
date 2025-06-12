using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Controls
{
    public class PasswordTextBox : Guna2TextBox
    {
        private bool isPasswordShown = false;

        public PasswordTextBox()
        {
            this.UseSystemPasswordChar = true;
            this.IconLeft = Properties.Resources.visibility; 
            this.IconLeftCursor = Cursors.Hand;
            this.RightToLeft = RightToLeft.Yes;


            this.IconLeftClick += TogglePassword;
        }

        private void TogglePassword(object sender, EventArgs e)
        {
            isPasswordShown = !isPasswordShown;
            this.UseSystemPasswordChar = !isPasswordShown;

            
            this.IconLeft = isPasswordShown
                ? Properties.Resources.visibility   
                : Properties.Resources.visibility_off; 
        }
    }
}
