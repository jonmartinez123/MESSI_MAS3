using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Rubro
    {
        private int id;
        private string descripcionCorta;
        private string descripcionLarga;

        public int Id { get { return id; } set { id = value; } }
        public string DescripcionCorta { get { return descripcionCorta; } set { descripcionCorta = value; } }
        public string DescripcionLarga { get { return descripcionLarga; } set { descripcionLarga = value; } }
    }
}
