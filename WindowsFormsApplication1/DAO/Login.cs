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
        public static int validarUsuario(String usuario, string password)
        {

            return SqlConnector.executeProcedure("validar_usuario", usuario, EncriptadorSHA.encodear(password));
        }

        public static String obtenerRolUsuario(Modelo.Usuario usuario)
        {
            return SqlConnector.retrieveList("get_rol", "rol_nombre", usuario.Username).First();
        }

        internal static int aumentarIntentos(Modelo.Usuario user)
        {
            return SqlConnector.executeProcedure("aumentar_intentos", user.Username);
        }

        internal static int vaciarIntentos(Modelo.Usuario user)
        {
            return SqlConnector.executeProcedure("vaciar_intentos", user.Username);
        }

        internal static int traerIntentos(Modelo.Usuario user)
        {
            return SqlConnector.executeProcedure("traer_intentos", user.Username);
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
