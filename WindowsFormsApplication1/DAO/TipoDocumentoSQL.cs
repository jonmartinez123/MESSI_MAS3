using MercadoEnvio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
    class TipoDocumentoSQL
    {
        public static List<TipoDocumento> getTipoDocumentos()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_tipoDocumentos");
            var reader = cmd.ExecuteReader();

            List<TipoDocumento> tipos = new List<TipoDocumento>();
            TipoDocumento t;
            while (reader.Read())
            {
                t = new TipoDocumento();
                t.Id = int.Parse(reader["tipoDocumento_id"].ToString());
                t.Descripcion = reader["tipoDocumento_nombre"].ToString();
                tipos.Add(t);
            }
            return tipos;
        }
    }
}
