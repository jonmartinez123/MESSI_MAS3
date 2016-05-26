using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Funcionalidad
    {
        private int id;
        private String descripcion;
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Id { get { return id; } set { id = value; } }
    }
}
