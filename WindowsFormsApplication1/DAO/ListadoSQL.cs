using MercadoEnvio.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public static List<Visibilidad> getVisibilidades()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_visibilidades");
            var reader = cmd.ExecuteReader();

            List<Visibilidad> visibilidades = new List<Visibilidad>();
            Visibilidad v;
            while (reader.Read())
            {
                v = new Visibilidad();
                v.Id = int.Parse(reader["visibilidad_id"].ToString());
                v.Descripcion = reader["visibilidad_descripcion"].ToString();
                visibilidades.Add(v);
            }
            return visibilidades;

        }


        internal static void get_top5vendedoresConMayorCantidadDeProductosNoVendidos(System.Windows.Forms.DataGridView dataGridView1, string anio, int nroTrimestre, string visibilidad)
        {
            SqlConnector.retrieveDT("get_top5vendedoresConMayorCantidadDeProductosNoVendidos", dataGridView1, anio, nroTrimestre, visibilidad);
        }

        internal static void get_top5clientesConMasCompraSegunRubro(System.Windows.Forms.DataGridView dataGridView1, string anio, int nroTrimestre, string rubro)
        {
            SqlConnector.retrieveDT("get_top5clientesConMasCompraSegunRubro", dataGridView1, anio, nroTrimestre, rubro);
        }
    }

}

