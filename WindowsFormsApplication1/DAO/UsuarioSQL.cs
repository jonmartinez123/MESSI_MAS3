using MercadoEnvio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercadoEnvio.DAO
{
    class UsuarioSQL
    {

        internal static List<Cliente> getClientes(string nombre, string apellido, int dni, string mail)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getClientes", nombre, apellido, dni, mail);
            var reader = cmd.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();
            Cliente c;
            while (reader.Read())
            {
                c = new Cliente();
                c.Id = int.Parse(reader["cliente_id"].ToString());
                c.Nombre = reader["cliente_nombre"].ToString();
                clientes.Add(c);
            }
            return clientes;
        }

        public static int getClientesFiltadros(DataGridView dg, string nombre, string apellido, string mail, int dni)
        {
            return SqlConnector.retrieveDT("get_clientesFiltrados", dg, nombre, apellido, mail, dni);
        }

        public static void darDeBajaUsuario(int idUsuario)
        {
            SqlConnector.executeProcedure("baja_usuario", idUsuario);
        }

        public static void darDeAltaUsuario(int idUsuario)
        {
            SqlConnector.executeProcedure("alta_usuario", idUsuario);
        }

        public static void cambiarPassword(string password)
        {
            SqlConnector.executeProcedure("cambiarPassword", password);
        }

    }
}
