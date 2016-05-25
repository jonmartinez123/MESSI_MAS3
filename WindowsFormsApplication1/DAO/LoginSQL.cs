using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;
namespace MercadoEnvio.DAO

{
    class LoginSQL
    {
        public static int validarUsuario(string username, string pass)
        {

            return SqlConnector.executeProcedure("validar_usuario", username, EncriptadorSHA.encodear(pass));
        }
        /*SqlConnection connection = new SqlConnection(ConnectionString);

command = new SqlCommand("TestProcedure", connection);
command.CommandType = System.Data.CommandType.StoredProcedure;
connection.Open();


gvGrid.DataSource = TestList;
gvGrid.DataBind();

        public static List<Rol> obtenerRoles(Modelo.Usuario usuario)
        {
            reader = command.ExecuteReader();

List<Test> TestList = new List<Test>();
Test test;

while (reader.Read())
{
    test = new Test();
    test.ID = int.Parse(reader["ID"].ToString());
    test.Name = reader["Name"].ToString();
    TestList.Add(test);
}
        }*/

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
        /*public static Modelo.Usuario ObtenerPorUserName(string userName)
        {
            //Traigo el usuario cuyo nombre de usuario coincida con el del parametro
            var param = new List<SPParameter> { new SPParameter("User", userName) };
            var sp = new StoreProcedure("getUserPorNombre", param);

            List<Modelo.Usuario> users = sp.ExecuteReader<Modelo.Usuario>();

            if (users == null || users.Count == 0)
                return null;

            return users[0];
        }*/
        internal static int getID()
        {
            return SqlConnector.executeProcedure("getID",Persistencia.usuario.NombreUsuario);
        }
        internal static String getMail()
        {
            return SqlConnector.ejecutarYDevolverString("getMail", Persistencia.usuario.Id);
        }
    }
}
