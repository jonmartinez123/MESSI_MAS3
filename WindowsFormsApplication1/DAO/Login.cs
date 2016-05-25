using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;
namespace MercadoEnvio.DAO
{
    class Login
    {
        public static int validarUsuario(string username, string pass)
        {

            return SqlConnector.executeProcedure("validar_usuario", username, EncriptadorSHA.encodear(pass));
        }

        public static String obtenerRolUsuario(Modelo.Usuario usuario)
        {
            return SqlConnector.retrieveList("get_rol", "rol_nombre", usuario.Username).First();
        }

        internal static int aumentarIntentos(string username)
        {
            return SqlConnector.executeProcedure("aumentar_intentos", username);
        }

        internal static void vaciarIntentos(Modelo.Usuario user)
        {
            SqlConnector.executeProcedure("vaciar_intentos", user.Username);
            Persistencia.usuario.Intentos = 0; 
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

        internal static int obtenerIDRolUsuario(Modelo.Usuario user)
        {
            return SqlConnector.executeProcedure("get_id_rol_usuario", user.Username);
        }
    }
}
