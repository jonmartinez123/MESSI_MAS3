﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
   public class CalificacionSQL
    {
        internal static void getCalificacionesPendientes(DataGridView calificacionesPendientes)
        {
            SqlConnector.retrieveDT("get_calificacionesPendientesDeID", calificacionesPendientes, Convert.ToString(Modelo.Persistencia.usuario.Id));
        }

        internal static void getHistoricoCalificaciones(DataGridView historicoCalificacionesUltimas)
        {
            SqlConnector.retrieveDT("get_ultimas5CalificacionesHechasDe", historicoCalificacionesUltimas, Convert.ToString(Modelo.Persistencia.usuario.Id));
        }

        internal static void getComprasXEstrellas(DataGridView comprasxEstrellas)
        {
            SqlConnector.retrieveDT("get_comprasXEstrellasSegunId", comprasxEstrellas, Convert.ToString(Modelo.Persistencia.usuario.Id));
 
        }

        internal static void actualizarCalificacion(int idCalificacion, string mensajeCalificacion, int cantidadEstrellasDadas)
        {
            SqlConnector.executeProcedure("actualizar_calificacionDe", idCalificacion, mensajeCalificacion, cantidadEstrellasDadas);
        }
    }
}
