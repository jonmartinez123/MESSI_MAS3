﻿using MercadoEnvio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MercadoEnvio.DAO
{
    class RolSQl
    {
        internal static List<Funcionalidad> getFuncionalidades(Rol rol)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getFuncionalidadesFuncionalidades", rol.getid);
            var reader = cmd.ExecuteReader();

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            Funcionalidad func;
            while (reader.Read())
            {
                func = new Funcionalidad();
                func.Id = int.Parse(reader["funcionalidad_id"].ToString());
                func.Descripcion = reader["funcionalidad_descripcion"].ToString();
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }


       public static int getAllRoles(DataGridView dg)
        {

            return SqlConnector.retrieveDT("get_roles", dg);
        }
        public static List<String> getAllFuncionalidades()
        {

            return SqlConnector.retrieveList("get_all_funcionalidades", "funcionalidad_descripcion");
        }

        public static List<Decimal> getIdFuncionalidades(Decimal rolID)
        {
            return SqlConnector.retrieveList("get_funcionalidades", "funcionalidad_id", rolID).AsEnumerable().ToList().ConvertAll(x => Convert.ToDecimal(x));
        }

        public static List<String> getFuncionalidadesQueNoTiene(Modelo.Rol rol)
        {
            return SqlConnector.retrieveList("get_funcionalidades_que_no_tiene", "funcionalidad_descripcion", rol.nombre);
        }

        public static int getFuncionalidadesRol(Modelo.Rol rol, DataGridView dg)
        {
            return SqlConnector.retrieveDT("get_funcionalidades", dg, rol.nombre);
        }

        public static int getIdFuncionalidad(int func) {
            return SqlConnector.executeProcedure("get_id_funcionalidad", func);
        }


        public static int agregarFuncionalidad(Modelo.Rol rol, String funcionalidad)
        {
            return SqlConnector.executeProcedure("asignar_funcionalidad_a_rol", rol.nombre, funcionalidad);
        }

        public static int eliminarFuncionalidad(Modelo.Rol rol, String funcionalidad)
        {
            return SqlConnector.executeProcedure("borrar_funcionalidad", rol.nombre, funcionalidad);
        }

        public static int cambiarEstadoRol(Modelo.Rol rol)
        {
            if (rol.habilitado)
            {
                return SqlConnector.executeProcedure("habilitar_rol", rol.nombre);
            }
            return SqlConnector.executeProcedure("bajar_rol", rol.nombre);
        }

        public static int modificarNombreRol(Modelo.Rol rol, String nuevoNombre)
        {

            return SqlConnector.executeProcedure("modificar_nombre_rol", rol.nombre, nuevoNombre);
        }

        public static int yaExisteRol(String nombre_nuevo)
        {

            return SqlConnector.executeProcedure("existe_rol", nombre_nuevo);
        }

        public static void crearNuevoRol(Modelo.Rol rol, DataGridView dg)
        {

          rol.getid =  SqlConnector.executeProcedure("crear_rol", rol.nombre, rol.habilitado ? 1 : 0);
            foreach (DataGridViewRow row in dg.Rows)
            {
                agregarFuncionalidad(rol, Convert.ToString(row.Cells["col_funcionalidades"].Value));
            }


        }

        public static Boolean rolEstaHabilitado(int idRol)
        {
            return SqlConnector.executeProcedure("get_if_rol_habilitado", idRol) == 1? true : false;
        }

        internal static void darDeAltaRol(int id)
        {
            SqlConnector.executeProcedure("darDeAltaRol", id);
        }

        internal static void darDeBajaRol(int id)
        {
            SqlConnector.executeProcedure("darDeBajaRol", id);
        }
        public static List<Rol> getRolesActivos()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getRolesActivos");
            var reader = cmd.ExecuteReader();

            List<Rol> roles = new List<Rol>();
            Rol r;
            while (reader.Read())
            {
                r = new Rol();
                r.Id = int.Parse(reader["rol_id"].ToString());
                r.nombre = reader["rol_nombre"].ToString();
                roles.Add(r);
            }
            return roles;
        }
    }
}
   
