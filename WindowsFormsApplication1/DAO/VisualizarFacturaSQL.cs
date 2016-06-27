using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
    class VisualizarFacturaSQL
    {
        public static int getPublicaciones(DataGridView dg, int idUsuario)
        {
            return SqlConnector.retrieveDT("getPublicaciones", dg, idUsuario);
        }
    }
}
