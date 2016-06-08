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

        public static void cambiarPassword(int idUsuario, string password)
        {
            SqlConnector.executeProcedure("cambiarPassword", idUsuario, password);
        }

        public static Cliente getCliente(int id){
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_cliente", id);
            var reader = cmd.ExecuteReader();

            Modelo.Cliente c = new Modelo.Cliente();

            while (reader.Read())
            {
                
                c.Nombre = reader["cliente_nombre"].ToString();
                c.Apellido = reader["cliente_apellido"].ToString();
                c.DNI = int.Parse(reader["cliente_DNI"].ToString());

                Modelo.TipoDocumento tipo = new Modelo.TipoDocumento();
                tipo.Id = int.Parse(reader["cliente_tipoDocumento_id"].ToString());
                c.TipoDocumento = tipo;

                c.Mail = reader["cliente_mail"].ToString();
                c.Telefono = int.Parse(reader["cliente_tel"].ToString());

                Modelo.Localidad l = new Modelo.Localidad();
                //l.Id = int.Parse(reader["domicilio_localidad_id"].ToString());
                int localidadId;
                if(!Int32.TryParse(reader["domicilio_localidad_id"].ToString(), out localidadId)){
                    l.Id = -1;
                }
                else{
                    l.Id = localidadId;
                }

                Modelo.Domicilio d = new Domicilio();
                d.Calle = reader["domicilio_calle"].ToString();
                d.Altura = int.Parse(reader["domicilio_altura"].ToString());
                d.Piso = int.Parse(reader["domicilio_piso"].ToString());
                d.Departamento = reader["domicilio_departamento"].ToString();
                d.CodigoPostal = int.Parse(reader["domicilio_codigoPostal"].ToString());
                d.Localidad = l;
                c.Domicilio = d;
            }
            return c;
        }

    }
}
