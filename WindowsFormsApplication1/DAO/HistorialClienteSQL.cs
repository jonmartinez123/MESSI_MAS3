using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.DAO
{
    class HistorialClienteSQL
    {
        internal static void getHistorial(System.Windows.Forms.DataGridView historialGridView)
        {
            SqlConnector.retrieveDT("get_historialClienteID", historialGridView, Utils.Persistencia.usuario.Id);
        }
    }
}
