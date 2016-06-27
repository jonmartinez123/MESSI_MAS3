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
        public static int getFacturaDetalles(DataGridView dg, int idFactura)
        {
            return SqlConnector.retrieveDT("getFacturaDetalles", dg, idFactura);
        }
    }
}
