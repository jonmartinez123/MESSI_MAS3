using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MercadoEnvio.Utils
{
    public static class Validaciones
    {
        public static void allowNumericOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public static void allowAlphaOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public static void allowAlphanumericOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public static void allowMaxLenght(this Form aForm, MaterialSkin.Controls.MaterialSingleLineTextField txt,int tamMax, KeyPressEventArgs e)
        {

            e.Handled = (txt.TextLength > tamMax);
        }

    }
}
