using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Utils
{
    public class FormaDePago
    {
        private int id;
        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Id { get { return id; } set { id = value; } }

    }
}
