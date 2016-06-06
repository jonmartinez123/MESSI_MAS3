using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    class Visibilidad
    {
        private string descripcion;
        private int precio;
        private int porcentaje;
        private int costoEnvio;
        public int Precio { get { return precio; } set { precio = value; } }
        public int Porcentaje { get { return porcentaje; } set { porcentaje = value; } }
        public int CostoEnvio { get { return costoEnvio; } set { costoEnvio = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
    }
}
