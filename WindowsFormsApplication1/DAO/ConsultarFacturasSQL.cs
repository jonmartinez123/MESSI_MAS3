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
        internal static DataTable getFacturasEntreFechas(Modelo.SuperGrid gridFacturas, String dateDesde, String dateHasta)
        {
            
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechas", gridFacturas, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta);
            return dt;
        }

        internal static DataTable getFacturasEntreImporte(Modelo.SuperGrid superGrid1, Int32 importeBajo, Int32 importeAlto)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreImporte", superGrid1, Modelo.Persistencia.usuario.Id, importeBajo, importeAlto);
            return dt;
         

            
        }

        internal static DataTable getFacturasConPalabraEnDetalle(Modelo.SuperGrid superGrid1, String p)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConDetalle", superGrid1, Modelo.Persistencia.usuario.Id, p);
            return dt;
        }

        internal static DataTable getFacturasEntreFechaEImporte(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, double p1, double p2)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechasEImporte", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta, p1, p2);
            return dt;
        }

        internal static DataTable getFacturasEntreFechasYDetalle(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, string p)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechasYContieneDetalle", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta, p);
            return dt;
        }

        internal static DataTable getFacturasEntreImporteYDetalle(Modelo.SuperGrid superGrid1, double p1, double p2, string detalle)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreImporteYDetalle", superGrid1, Modelo.Persistencia.usuario.Id, p1, p2, detalle);
            return dt;
        }

        internal static DataTable getFacturasConTodoLosFiltro(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, double p1, double p2, string detalle)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConTodoLosFiltros", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde,dateHasta, p1, p2, detalle);
            return dt;
        }

        internal static DataTable getFacturasConTodoLosFiltrosMasDirigido(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, double p1, double p2, string detalle, string dniocuit)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConTodoLosFiltrosInclusoDNIOCUIT", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta, p1, p2, detalle, dniocuit);
            return dt;
        }

        internal static DataTable getFacturasHacia(Modelo.SuperGrid superGrid1, string p)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasHacia", superGrid1, Modelo.Persistencia.usuario.Id, p);
            return dt;
        }

        internal static DataTable getFacturasEntreFechasYDirigido(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, string p)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreFechasYDirigido", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta, p);
            return dt;
        }

        internal static DataTable getFacturasEntreImporteYDirigido(Modelo.SuperGrid superGrid1, double p1, double p2, string dnioCuit)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreImporteYDirigido", superGrid1, Modelo.Persistencia.usuario.Id, p1, p2, dnioCuit);
            return dt;
        }

        internal static DataTable getFacturasEntreDetalleyDirigido(Modelo.SuperGrid superGrid1, string dniOCuit, string detalle)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasEntreDetalleYDirigido", superGrid1, Modelo.Persistencia.usuario.Id, dniOCuit, detalle);
            return dt;
        }

        internal static DataTable getFacturasConFechaImporteYDirigido(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, double p1, double p2, string dniOCuit)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConFechaImporteYDirigido", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta, p1, p2, dniOCuit);
            return dt;
        }

        internal static DataTable getFacturasConFechaDetalleyDirigido(Modelo.SuperGrid superGrid1, string dateDesde, string dateHasta, string detalle, string dniOCuit)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConFechaDetalleyDirigido", superGrid1, Modelo.Persistencia.usuario.Id, dateDesde, dateHasta, detalle, dniOCuit);
            return dt;
        }

        internal static DataTable getFacturasConDetalleImporteYDirigido(Modelo.SuperGrid superGrid1, double p1, double p2, string detalle, string dniOCuit)
        {
            DataTable dt = SqlConnector.retrieveDTPaginado("get_facturasConDetalleImporteYDirigido", superGrid1, Modelo.Persistencia.usuario.Id, p1, p2, detalle, dniOCuit);
            return dt;
        }
    }
}
