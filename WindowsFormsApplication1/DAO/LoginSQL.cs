using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;
using System.Data.SqlClient;
namespace MercadoEnvio.DAO

{
    class LoginSQL
    {
        public static int validarUsuario(string username, string pass)
        {

            return SqlConnector.executeProcedure("validar_usuario", username, EncriptadorSHA.encodear(pass));
        }

        internal static int aumentarIntentos(int idUsuario)
        {
            return SqlConnector.executeProcedure("aumentar_intentos", idUsuario);
        }

        internal static void vaciarIntentos(int idUsuario)
        {
            SqlConnector.executeProcedure("vaciar_intentos", idUsuario);
        }

        internal static int traerIntentos(int idUsuario)
        {
            return SqlConnector.executeProcedure("traer_intentos", idUsuario);
        }

        internal static Boolean existeUsuario(string nombreUsuario)
        {
            return SqlConnector.executeProcedure("existe_usuario", nombreUsuario) == 1 ? true : false;
        }

        internal static int getID(string nombreUsuario)
        {
            return SqlConnector.executeProcedure("getID", nombreUsuario);
        }
        internal static List<Rol> getRoles(int id)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getRoles", id);
            var reader = cmd.ExecuteReader();

            List<Rol> roles = new List<Rol>();
            Rol rol;

            while (reader.Read())
            {
                rol = new Rol();
                rol.getid = int.Parse(reader["rol_id"].ToString());
                rol.Nombre = reader["rol_nombre"].ToString();
                roles.Add(rol);
            }
            return roles;
        }
        internal static String getMail(int id)
        {
            return SqlConnector.ejecutarYDevolverString("getMail", id);
        }
        internal static int getTelefono(int id) {
            return SqlConnector.executeProcedure("getTelefono", id);
        }
    }
}
