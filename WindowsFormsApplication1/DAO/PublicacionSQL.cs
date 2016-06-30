using MercadoEnvio.Modelo;
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

        public static List<Rubro> getRubrosPorPublicacion(int idPublicacion)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getRubrosPorPublicacion", idPublicacion);
            var reader = cmd.ExecuteReader();
            List<Rubro> rubros = new List<Rubro>();
            Rubro r;
            while (reader.Read())
            {
                r = new Rubro();
                r.Id = int.Parse(reader["rubro_id"].ToString());
                r.DescripcionCorta = reader["rubro_descripcionCorta"].ToString();
                r.DescripcionLarga = reader["rubro_descripcionLarga"].ToString();
                rubros.Add(r);
            }
            return rubros;
        }
        /*
        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }
        */

        internal static DataTable filtrarPublicacionesPorRubro(DataTable dtAAcumular, int idRubro, string descripcion)
        {
            return DAO.SqlConnector.retrieveDTToBeConvertedParaComprarYOfertar(dtAAcumular, "filtrarPublicacionPorRubro", idRubro, descripcion, Persistencia.usuario.Id); 
        }

        internal static DataTable obtenerPublicacionesActivas()
        {
            return DAO.SqlConnector.retrieveDTToBeConverted("obtenerPublicacionesActivas", Persistencia.usuario.Id);
        }

        internal static int crearComprar(int idPublicacion, int idCliente, int cantidad)
        {
            return SqlConnector.executeProcedure("crearCompra", idPublicacion, idCliente, cantidad);  
        }


        internal static void insertarPublicacion(int idEstado,int idVisibilidad,DataTable idRubros,int idUsuario,int idTipoPublicacion,string descripcion,DateTime fechaInicio,DateTime fechaFin,double minimoSubasta,double precio,int stock,int seCobraEnvio)
        {
            if (minimoSubasta != -1)
            {
                SqlConnector.executeProcedure("insertarPublicacion", idEstado, idVisibilidad, idUsuario, idTipoPublicacion, descripcion, fechaInicio, fechaFin, minimoSubasta, precio, stock, seCobraEnvio,idRubros);
            }
            else
            {
                SqlConnector.executeProcedure("insertarPublicacion", idEstado, idVisibilidad, idUsuario, idTipoPublicacion, descripcion, fechaInicio, fechaFin, null, precio, stock, seCobraEnvio,idRubros);

            }
        }

        internal static void updatearPublicacion(int idPublicacion ,int idEstado, int idVisibilidad, DataTable idRubros, int idUsuario, int idTipoPublicacion, string descripcion, DateTime fechaInicio, DateTime fechaFin, double minimoSubasta, double precio, int stock, int seCobraEnvio)
        {
            if (minimoSubasta != -1)
            {
                SqlConnector.executeProcedure("updatearPublicacion", idPublicacion, idEstado, idVisibilidad, idUsuario, idTipoPublicacion, descripcion, fechaInicio, fechaFin, minimoSubasta, precio, stock, seCobraEnvio, idRubros);
            }
            else
            {
                SqlConnector.executeProcedure("updatearPublicacion", idPublicacion, idEstado, idVisibilidad, idUsuario, idTipoPublicacion, descripcion, fechaInicio, fechaFin, null, precio, stock, seCobraEnvio, idRubros);

            }
        }
        internal static int activarPublicacion(int idPublicacion, DateTime fechaActivo, int idUsuario, int idFormaDePago, double monto)
        {
            return SqlConnector.executeProcedure("activarPublicacion", idPublicacion, fechaActivo, idUsuario, idFormaDePago,monto);  
        }
        internal static void updetearEstado(int idPublicacion, int idEstado)
        {
            SqlConnector.executeProcedure("updetearEstado", idPublicacion, idEstado);
        }

        internal static void cambiarEstadoDeSubastasVencidas(DateTime fechaDelSistema)
        {
            SqlConnector.executeProcedure("cambiarEstadoDeSubastasVencidas", fechaDelSistema);
        }
    }
}