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
            if (txt.Text.Length == tamMax)
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        public static Boolean isValid(this Control control)
        {
            if (control.Text == "") { MessageBox.Show("Falta especificar" + control.AccessibleDescription); }
            return false;
        }


       /* // try catchea una excepcion proviniente de campos vacios
        public static Boolean validateNotNullForAll(this Form aForm, Control.ControlCollection controls)
        {
            var isValid = false;
            try { isValid = aForm.validar(controls); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return isValid;
        }*/


    }
}
