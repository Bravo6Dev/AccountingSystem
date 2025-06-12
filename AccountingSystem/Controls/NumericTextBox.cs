using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Controls
{
    public class NumericTextBox : Guna2TextBox
    {
        public NumericTextBox()
        {
            this.KeyPress += MoneyTextBox_KeyPress;
        }

        private void MoneyTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsControl(ch))
                return;
           
            if (char.IsDigit(ch))
                return;

            if (ch == '.' && !this.Text.Contains("."))
                return;

            e.Handled = true;
        }
    }
}
