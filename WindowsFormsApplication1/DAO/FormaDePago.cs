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
    class FormaDePago
    {
        public static List<Modelo.FormaDePago> getFormasDePago()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_formasDePago");
            var reader = cmd.ExecuteReader();

            List<Modelo.FormaDePago> formas = new List<Modelo.FormaDePago>();
            Modelo.FormaDePago f;
            while (reader.Read())
            {
                f = new Modelo.FormaDePago();
                f.Id = int.Parse(reader["formaDePago_id"].ToString());
                f.Nombre = reader["formaDePago_nombre"].ToString();
                formas.Add(f);
            }
            return formas;
        }
    }
}
