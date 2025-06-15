using Applications.Util;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem
{
    public static class FormHelper
    {
        public static DialogResult ServerError(Exception ex)
        {
            Log.Error(ex, ex.Message);
            return MessageBox.Show(Messages.ServerError, "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
