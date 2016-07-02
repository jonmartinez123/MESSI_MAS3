using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MercadoEnvio.Modelo
{
    public static class Validaciones
    {
        public static void allowNumericOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public static void allowNumericOnlyYGuion(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-');
        }
        public static void allowAlphanumericOnlyYGuion(this Form aForm, KeyPressEventArgs e)
        {
             e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar=='-');
        }
        public static void allowNumericOnlyParaDouble(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }
        public static bool tieneDosGuiones(string texto) {
            int cantGuiones=0;
            foreach (Char c in texto) {
                if (c == '-')
                {
                    cantGuiones++;
                }
            }
            return cantGuiones == 2;
        }
        public static void allowAlphaOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public static void allowAlphaOnlyYEspacio(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ');
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

        public static Boolean esAlfaNumerico(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(strToCheck);
        }

        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
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
