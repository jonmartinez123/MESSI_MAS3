using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.DAO
{
    public class TipoPublicacionSQL
    {
        public static int getId(string tipo)
        {

            return SqlConnector.executeProcedure("getIdTipoPublicacion", tipo);
        }
    }
}
