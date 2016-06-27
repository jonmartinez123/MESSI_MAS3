using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.DAO
{
    class ListadoSQL
    {


        internal static void getTop5VendedoresConMasFacturas(System.Windows.Forms.DataGridView dataGridView1, string anio, int nroTrimestre)
        {
            SqlConnector.retrieveDT("get_top5ConMasFacturas", dataGridView1, anio, nroTrimestre);
        }

        internal static void getTop5ConMontoMasFacturado(System.Windows.Forms.DataGridView dataGridView1, string anio, int nroTrimestre)
        {
            SqlConnector.retrieveDT("get_top5ConMayorMontoFacturado", dataGridView1, anio, nroTrimestre);
        }
    }
}
