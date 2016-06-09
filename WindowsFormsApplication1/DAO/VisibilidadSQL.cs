using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
    public class VisibilidadSQL
    {
        public static int getVisibilidades(DataGridView dg)
        {
            return SqlConnector.retrieveDT("getVisibilidades", dg);
        }

        public static int eliminarVisibilidad(int visibilidadId)
        {
            return SqlConnector.executeProcedure("eliminarVisibilidad", visibilidadId);
        }
        public static int agregarVisibilidad(int codigo, string descripcion, double porcentaje, double precio, double costoEnvio)
        {
            return SqlConnector.executeProcedure("agregarVisibilidad", codigo, descripcion, porcentaje, precio, costoEnvio);
        }
        public static int modificarVisibilidad(int id, int codigo, string descripcion, double porcentaje, double precio, double costoEnvio)
        {
            return SqlConnector.executeProcedure("modificarVisibilidad", id, codigo, descripcion, porcentaje, precio, costoEnvio);
        }
    }
}
