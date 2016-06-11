using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.DAO
{
    class HistorialClienteSQL
    {
        internal static DataTable getHistorial(SuperGrid historialGridView)
        {
           DataTable dt =  SqlConnector.retrieveDTPaginado("get_historialClienteID", historialGridView, Utils.Persistencia.usuario.Id);
           return dt;
        }

        internal static void getResumen(System.Windows.Forms.DataGridView historialGridView)
        {
            SqlConnector.retrieveDT("get_resumenComprasUsuario", historialGridView, Utils.Persistencia.usuario.Id);
        }

    }
}
