using MercadoEnvio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
    public class LocalidadSQL
    {
        public static List<Localidad> getLocalidades()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_localidades");
            var reader = cmd.ExecuteReader();

            List<Localidad> localidades = new List<Localidad>();
            Localidad l;
            while (reader.Read())
            {
                l = new Localidad();
                l.Id = int.Parse(reader["localidad_id"].ToString());
                l.Nombre = reader["localidad_nombre"].ToString();
                localidades.Add(l);
            }
            return localidades;
        }
    }
}
