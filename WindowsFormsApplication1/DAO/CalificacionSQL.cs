using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
    class CalificacionSQL
    {
        internal static void getCalificacionesPendientes(DataGridView calificacionesPendientes)
        {
            SqlConnector.retrieveDT("get_calificacionesPendientesDe", calificacionesPendientes,Utils.Persistencia.usuario.Id);
        }

        internal static void getHistoricoCalificaciones(DataGridView historicoCalificacionesUltimas)
        {
            SqlConnector.retrieveDT("get_ultimas5CalificacionesHechasDe", historicoCalificacionesUltimas);
        }

        internal static void getComprasXEstrellas(DataGridView comprasxEstrellas)
        {
            SqlConnector.retrieveDT("get_comprasXEstrellasSegunId", comprasxEstrellas);
        }
    }
}
