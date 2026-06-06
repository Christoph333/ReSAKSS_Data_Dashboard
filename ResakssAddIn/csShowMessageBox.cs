using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResakssAddIn
{
    public class csShowMessageBox
    {
        /*-----------------------------------------------------------------------------
         * static method 
         
         *----------------------------------------------------------------------------*/

        public static DialogResult fnShowMessageBoxWithParameters(
                                                  string message, string caption,
                                                  MessageBoxButtons buttons,
                                                  MessageBoxIcon icon,
                                                  MessageBoxDefaultButton defaultButton,
                                                  MessageBoxOptions allign)
        {
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon, defaultButton, allign);
            return result;
        }
    }

}
