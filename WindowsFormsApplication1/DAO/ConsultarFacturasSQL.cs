using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.DAO
{
    class ConsultarFacturasSQL
    {
        internal static DataTable getFacturasEntreFechas(Utils.SuperGrid gridFacturas, String dateDesde, String dateHasta)
        {
            
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechas", gridFacturas, Utils.Persistencia.usuario.Id, dateDesde, dateHasta);
            return dt;
        }

        internal static DataTable getFacturasEntreImporte(Utils.SuperGrid superGrid1, Int32 importeBajo, Int32 importeAlto)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreImporte", superGrid1, Utils.Persistencia.usuario.Id, importeBajo, importeAlto);
            return dt;
        }

        internal static DataTable getFacturasConPalabraEnDetalle(Utils.SuperGrid superGrid1, String p)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConDetalle", superGrid1, Utils.Persistencia.usuario.Id, p);
            return dt;
        }

        internal static DataTable getFacturasEntreFechaEImporte(Utils.SuperGrid superGrid1, string dateDesde, string dateHasta, double p1, double p2)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechasEImporte", superGrid1, Utils.Persistencia.usuario.Id, dateDesde, dateHasta, p1, p2);
            return dt;
        }

        internal static DataTable getFacturasEntreFechasYDetalle(Utils.SuperGrid superGrid1, string dateDesde, string dateHasta, string p)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechasYContieneDetalle", superGrid1, Utils.Persistencia.usuario.Id, dateDesde, dateHasta, p);
            return dt;
        }

        internal static DataTable getFacturasEntreImporteYDetalle(Utils.SuperGrid superGrid1, double p1, double p2, string detalle)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreImporteYDetalle", superGrid1, Utils.Persistencia.usuario.Id, p1, p2, detalle);
            return dt;
        }

        internal static DataTable getFacturasConTodoLosFiltro(Utils.SuperGrid superGrid1, string dateDesde, string dateHasta, double p1, double p2, string detalle)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConTodoLosFiltros", superGrid1, Utils.Persistencia.usuario.Id, dateDesde,dateHasta, p1, p2, detalle);
            return dt;
        }
    }
}
