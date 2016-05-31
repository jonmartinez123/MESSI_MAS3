using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Localidad
    {
        private string nombre;
        private int codigoPostal;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int CodigoPostal { get { return codigoPostal; } set { codigoPostal = value; } }
    }
}
