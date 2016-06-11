using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Utils
{
    public class Localidad
    {
        private string nombre;
        private int id;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Id { get { return id; } set { id = value; } }
    }
}
