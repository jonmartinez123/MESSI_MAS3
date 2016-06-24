﻿using MercadoEnvio.Modelo;
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

        internal static void crearComprar(int idPublicacion, int idCliente, int cantidad, int idFormaDePago)
        {
            SqlConnector.executeProcedure("crearCompra", idPublicacion, idCliente, cantidad, idFormaDePago);  
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
    }
}
