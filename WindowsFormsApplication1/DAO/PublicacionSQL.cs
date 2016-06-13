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
    class PublicacionSQL
    {
        public static Modelo.Oferta getUltimoValorOferta(int idPublicacion)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_ultimaOferta", idPublicacion);
            var reader = cmd.ExecuteReader();

            Modelo.Oferta oferta = new Modelo.Oferta();

            while (reader.Read())
            {      
                oferta.Valor = int.Parse(reader["valorMax"].ToString());
            }
            return oferta;
        }


        internal static void crearOferta(Modelo.Oferta oferta)
        {
            SqlConnector.executeProcedure("crear_oferta", oferta.Valor, oferta.Usuario.Id, oferta.Publicacion.Id);        
        }

        internal static Modelo.Publicacion filtrarPublicacionesPorRubro(int idRubro, string descripcion)
        {
            throw new NotImplementedException();
        }

        internal static Modelo.Publicacion filtrarPubliacionesPorDescripcion(string descripcion)
        {
            throw new NotImplementedException();
        }
    }
}
