using MercadoEnvio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MercadoEnvio.DAO
{
    class PublicacionSQL
    {
		public static int getPublicaciones(DataGridView dg,int idUsuario)
        {
            return SqlConnector.retrieveDT("getPublicaciones", dg, idUsuario);
        }
        public static Modelo.Oferta getUltimoValorOferta(int idPublicacion)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_ultimaOferta", idPublicacion);
            var reader = cmd.ExecuteReader();

            Modelo.Oferta oferta = new Modelo.Oferta();

            while (reader.Read())
            {      
                oferta.Valor = double.Parse(reader["valorMax"].ToString());
            }
            return oferta;
        }


        internal static void crearOferta(Modelo.Oferta oferta)
        {
            SqlConnector.executeProcedure("crearOferta", oferta.Valor, oferta.Usuario.Id, oferta.Publicacion.Id);        
        }

        
        

        internal static DataTable filtrarPublicacionesPorRubro(DataTable dtAAcumular, int idRubro, string descripcion)
        {

            //DataTable dtNuevo;
            return DAO.SqlConnector.retrieveDTToBeConvertedParaComprarYOfertar(dtAAcumular, "filtrarPublicacionPorRubro", idRubro, descripcion);
           // dtAAcumular =DAO.SqlConnector.retrieveDTToBeConvertedParaComprarYOfertar(dtAAcumular, "get_publicacionesSegunRubroID", idRubro);
           // dtAAcumular.Merge(dtNuevo, true);

          // DAO.SqlConnector.bindNamesToDataTable(dtAAcumular, superGrid);
          // superGrid.DataSource = dtAAcumular;
             
        }

        internal static DataTable filtrarPubliacionesPorDescripcion(DataTable dtAAcumular, string descripcion)
        {
            return DAO.SqlConnector.retrieveDTToBeConvertedParaComprarYOfertar(dtAAcumular, "filtrarPublicacionPorDescripcion", descripcion);
        }
    }
}
