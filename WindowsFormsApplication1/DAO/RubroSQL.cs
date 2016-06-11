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
    public class RubroSQL
    {
        public static List<Rubro> getRubros()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_rubros");
            var reader = cmd.ExecuteReader();

            List<Rubro> rubros = new List<Rubro>();
            Rubro r;
            while (reader.Read())
            {
                r = new Rubro();
                r.Id = int.Parse(reader["rubro_id"].ToString());
                r.DescripcionCorta = reader["rubro_descripcionCorta"].ToString();
                rubros.Add(r);
            }
            return rubros;
        }
    }
}
