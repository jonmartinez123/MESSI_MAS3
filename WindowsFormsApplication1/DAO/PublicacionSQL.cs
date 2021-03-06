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
            SqlConnector.executeProcedure("crearOferta", oferta.Valor, oferta.Usuario.Id, oferta.Publicacion.Id,Config.ConfiguracionVariable.FechaSistema);        
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
       
        internal static int crearComprar(int idPublicacion, int idCliente, int cantidad)
        {
            return SqlConnector.executeProcedure("crearCompra", idPublicacion, idCliente, cantidad, Config.ConfiguracionVariable.FechaSistema);  
        }


        internal static void insertarPublicacion(int idEstado,int idVisibilidad,DataTable idRubros,int idUsuario,int idTipoPublicacion,string descripcion,DateTime fechaInicio,DateTime fechaFin,double minimoSubasta,double precio,int stock,int seCobraEnvio)
        {
            if (minimoSubasta != -1)
            {
                SqlConnector.executeProcedure("insertarPublicacion", idEstado, idVisibilidad, idUsuario, idTipoPublicacion, descripcion, fechaInicio, fechaFin, minimoSubasta, null, stock, seCobraEnvio,idRubros);
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
                SqlConnector.executeProcedure("updatearPublicacion", idPublicacion, idEstado, idVisibilidad, idUsuario, idTipoPublicacion, descripcion, fechaInicio, fechaFin, minimoSubasta, null, stock, seCobraEnvio, idRubros);
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

        internal static void filtrarPublicacionesPorRubro(SuperGrid superGrid1, DataTable idRubros, string descripcion)
        {
            SqlConnector.retrieveDT("filtrarPublicacionPorRubro", superGrid1, idRubros, descripcion,Persistencia.usuario.Id);
        }

        internal static void obtenerPublicacionesActivas(SuperGrid superGrid1)
        {
            DAO.SqlConnector.retrieveDT("obtenerPublicacionesActivas",superGrid1, Persistencia.usuario.Id);
        }

        internal static void filtrarPublicacionesPorDescripcion(SuperGrid superGrid1, string descripcion)
        {
            SqlConnector.retrieveDT("filtrarPublicacionPorDescripcion", superGrid1, descripcion, Persistencia.usuario.Id);
        }

        internal static List<TipoPublicacion> getTipoPublicacion()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getTipoPublicacion");
            var reader = cmd.ExecuteReader();
            List<TipoPublicacion> tipo = new List<TipoPublicacion>();
            TipoPublicacion t;
            while (reader.Read())
            {
                t = new TipoPublicacion();
                t.nombre = reader["tipoPublicacion_nombre"].ToString();
                t.tieneEnvio = Convert.ToInt32(reader["tipoPublicacion_tieneEnvio"]);
                tipo.Add(t);
            }
            return tipo;
        }
    }
}