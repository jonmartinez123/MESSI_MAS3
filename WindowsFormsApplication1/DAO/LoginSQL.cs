using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;
using MercadoEnvio.Modelo;
using System.Data.SqlClient;
namespace MercadoEnvio.DAO

{
    class LoginSQL
    {
        public static int validarUsuario(string username, string pass)
        {

            return SqlConnector.executeProcedure("validar_usuario", username, EncriptadorSHA.encodear(pass));
        }

        internal static int aumentarIntentos(string username)
        {
            return SqlConnector.executeProcedure("aumentar_intentos", username);
        }

        internal static void vaciarIntentos()
        {
            SqlConnector.executeProcedure("vaciar_intentos", Persistencia.usuario.NombreUsuario);
        }

        internal static int traerIntentos(string username)
        {
            return SqlConnector.executeProcedure("traer_intentos", username);
        }

        internal static Boolean existeUsuario(String username)
        {
            return SqlConnector.executeProcedure("existe_usuario", username) == 1 ? true : false;
        }

        internal static List<short> getFuncionalidades(int p)
        {
            throw new NotImplementedException();
        }

        internal static int getID()
        {
            return SqlConnector.executeProcedure("getID",Persistencia.usuario.NombreUsuario);
        }
        internal static List<Rol> getRoles()
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getRoles", Persistencia.usuario.Id);
            var reader = cmd.ExecuteReader();

            List<Rol> roles = new List<Rol>();
            Rol rol;

            while (reader.Read())
            {
                rol = new Rol();
                rol.Id = int.Parse(reader["rol_id"].ToString());
                rol.Nombre = reader["rol_nombre"].ToString();
                roles.Add(rol);
            }
            return roles;
        }
        internal static String getMail()
        {
            return SqlConnector.ejecutarYDevolverString("getMail", Persistencia.usuario.Id);
        }
    }
}
