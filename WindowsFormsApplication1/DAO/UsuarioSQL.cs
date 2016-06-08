using MercadoEnvio.Utils;
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

        public static int getClientesFiltadros(DataGridView dg, string nombre, string apellido, string mail, string dni)
        {
            if (dni == "")
            {
                return SqlConnector.retrieveDT("get_clientesFiltrados", dg, nombre, apellido, mail, null);
            }
            else {
                return SqlConnector.retrieveDT("get_clientesFiltrados", dg, nombre, apellido, mail, Int32.Parse(dni));
            }
            
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
            SqlConnector.executeProcedure("cambiarPassword", idUsuario, EncriptadorSHA.encodear(password));
        }


        public static void modificarCliente(Modelo.Cliente c)
        {
            SqlConnector.executeProcedure("modificar_cliente", c.Id, c.Nombre, c.Apellido, c.Mail, c.DNI, c.FechaNacimiento, c.Telefono, c.TipoDocumento.Id, c.Domicilio.Localidad.Id, c.Domicilio.Calle, c.Domicilio.Altura, c.Domicilio.Piso, c.Domicilio.Departamento, c.Domicilio.Ciudad, c.Domicilio.CodigoPostal.ToString());
        }

        public static void crearCliente(Modelo.Cliente c)
        {
            SqlConnector.executeProcedure("modificar_cliente",c.NombreUsuario, EncriptadorSHA.encodear(c.Password), c.Nombre, c.Apellido, c.Mail, c.DNI, c.FechaNacimiento, c.Telefono, c.TipoDocumento.Id, c.Domicilio.Localidad.Id, c.Domicilio.Calle, c.Domicilio.Altura, c.Domicilio.Piso, c.Domicilio.Departamento, c.Domicilio.Ciudad, c.Domicilio.CodigoPostal.ToString());
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

                c.FechaNacimiento = DateTime.Parse(reader["cliente_fechaNacimiento"].ToString());
            }
            return c;
        }

    }
}
