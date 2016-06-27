using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Modelo;

namespace MercadoEnvio.DAO
{
    class VisualizarFacturaSQL
    {
        public static int getFacturaDetalles(DataGridView dg, int idFactura)
        {
            return SqlConnector.retrieveDT("getFacturaDetalles", dg, idFactura);
        }
        public static int esCliente(int idUsuario)
        {
            return SqlConnector.executeProcedure("esCliente",idUsuario);
        }
        public static Modelo.Factura getFacturaDetallesCabecera(int idFactura)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getFacturaDetallesCabecera",idFactura);
            var reader = cmd.ExecuteReader();
            Factura factura = new Factura();
            while (reader.Read())
            {
                factura.Fecha = Convert.ToDateTime(reader["factura_fecha"]);
                factura.IdFormaDePago = Convert.ToInt32(reader["factura_formaDePago"]);
                factura.Numero = Convert.ToInt32(reader["factura_numero"]);
                factura.IdVendedor = Convert.ToInt32(reader["factura_idVendedor"]);
                factura.ImporteTotal = Convert.ToDouble(reader["factura_importeTotal"]);
            }
            return factura;
        }
    }
}
