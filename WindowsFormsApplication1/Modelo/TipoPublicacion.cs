using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class TipoPublicacion
    {
        public int id;
        public string nombre;
        public int tieneEnvio;
        public TipoPublicacion(int idTipo, string nombreTipo, int tieneEnvioTipo) {
            this.id = idTipo;
            this.nombre = nombreTipo;
            this.tieneEnvio = tieneEnvioTipo;
        }
    }
}
