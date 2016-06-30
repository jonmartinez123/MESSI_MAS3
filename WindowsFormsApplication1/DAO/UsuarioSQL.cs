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


        //CLIENTE  
        public static int getClientesFiltadros(DataGridView dg, string nombre, string apellido, string mail, string dni, Modelo.TipoDocumento tipo)
        {
            if (dni == "")
            {
                return SqlConnector.retrieveDT("get_clientesFiltradosSinDocumento", dg, nombre, apellido, mail);
            }
            else
            {
                return SqlConnector.retrieveDT("get_clientesFiltrados", dg, nombre, apellido, mail, Int32.Parse(dni), tipo.Id);
            }

        }

        public static void modificarCliente(Modelo.Cliente c)
        {
            SqlConnector.executeProcedure("modificar_cliente", c.Id, c.Nombre, c.Apellido, c.Mail, c.DNI, c.FechaNacimiento, c.Telefono, c.TipoDocumento.Id, c.Domicilio.Localidad.Id, c.Domicilio.Calle, c.Domicilio.Altura, c.Domicilio.Piso, c.Domicilio.Departamento, c.Domicilio.CodigoPostal.ToString());
        }

        public static void crearCliente(Modelo.Cliente c)
        { 
            SqlConnector.executeProcedure("crear_cliente",c.NombreUsuario, EncriptadorSHA.encodear(c.Password), c.Nombre, c.Apellido, c.Mail, c.DNI, c.FechaNacimiento, c.Telefono, c.TipoDocumento.Id, c.Domicilio.Localidad.Id, c.Domicilio.Calle, c.Domicilio.Altura, c.Domicilio.Piso, c.Domicilio.Departamento, c.Domicilio.CodigoPostal.ToString());        
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


        //EMPRESA

        public static int getEmpresasFiltradas(DataGridView dg, string razonSocial, string cuit, string mail)
        {
            if (cuit == ""){
                return SqlConnector.retrieveDT("get_empresasFiltradasSinCUIT", dg, razonSocial, mail);
            }
            else{
                return SqlConnector.retrieveDT("get_empresasFiltradas", dg, razonSocial, mail, cuit);
            }
        }

        public static void modificarEmpresa(Modelo.Empresa e)
        {
            SqlConnector.executeProcedure("modificar_empresa", e.Id, e.RazonSocial, e.Mail, e.Cuit, e.Telefono, e.NombreContacto, e.Domicilio.Localidad.Id, e.Domicilio.Calle, e.Domicilio.Altura, e.Domicilio.Piso, e.Domicilio.Departamento, e.Domicilio.Ciudad, e.Domicilio.CodigoPostal.ToString(), e.RubroPrincipal.Id);
        }

        public static Empresa getEmpresa(int id)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("get_empresa", id);
            var reader = cmd.ExecuteReader();

            Modelo.Empresa e = new Modelo.Empresa();

            while (reader.Read())
            {
                //empresa_razonSocial, empresa_cuit, empresa_telefono, empresa_rubroId, empresa_mail, empresa_nombreContacto, domicilio_calle, domicilio_altura, domicilio_piso, domicilio_departamento, domicilio_codigoPostal, domicilio_localidad_id, domicilio_ciudad
                e.RazonSocial = reader["empresa_razonSocial"].ToString();
                e.Cuit = reader["empresa_cuit"].ToString();
                e.Telefono = reader["empresa_telefono"].ToString();
                e.Mail = reader["empresa_mail"].ToString();
                e.NombreContacto = reader["empresa_nombreContacto"].ToString();

                Modelo.Localidad l = new Modelo.Localidad();

                int localidadId;
                if (!Int32.TryParse(reader["domicilio_localidad_id"].ToString(), out localidadId))
                {
                    l.Id = -1;
                }
                else
                {
                    l.Id = localidadId;
                }

                Modelo.Rubro r = new Modelo.Rubro();

                int rubroId;
                if (!Int32.TryParse(reader["empresa_rubroId"].ToString(), out rubroId))
                {
                    r.Id = -1;
                }
                else
                {
                    r.Id = localidadId;
                }

                e.RubroPrincipal = r;

                Modelo.Domicilio d = new Domicilio();
                d.Calle = reader["domicilio_calle"].ToString();
                d.Altura = int.Parse(reader["domicilio_altura"].ToString());
                d.Piso = int.Parse(reader["domicilio_piso"].ToString());
                d.Departamento = reader["domicilio_departamento"].ToString();
                d.CodigoPostal = int.Parse(reader["domicilio_codigoPostal"].ToString());
                d.Ciudad = reader["domicilio_ciudad"].ToString();
                d.Localidad = l;
                e.Domicilio = d;

            }
            return e;
        }

        public static void crearEmpresa(Modelo.Empresa e)
        { 
            SqlConnector.executeProcedure("crear_empresa", e.NombreUsuario, EncriptadorSHA.encodear(e.Password), e.RazonSocial, e.Mail, e.Cuit, e.Telefono, e.NombreContacto, e.Domicilio.Localidad.Id, e.Domicilio.Calle, e.Domicilio.Altura, e.Domicilio.Piso, e.Domicilio.Departamento, e.Domicilio.Ciudad, e.Domicilio.CodigoPostal.ToString(), e.RubroPrincipal.Id);
        }

        internal static Boolean existeRazonSocial(string razon, int idUsuario)
        {
            return SqlConnector.executeProcedure("existe_razonSocial", razon, idUsuario) == 1 ? true : false;
        }

        internal static Boolean existeCUIT(string cuit, int idUsuario)
        {
            return SqlConnector.executeProcedure("existe_cuit", cuit, idUsuario) == 1 ? true : false;
        }

        internal static bool existeMailCliente(string p, int idUsuario)
        {
            return SqlConnector.executeProcedure("existe_mailCliente", p, idUsuario) == 1 ? true : false; 
        }

        internal static bool existeDocumento(string p, int idUsuario)
        {
            return SqlConnector.executeProcedure("existe_documentoCliente", p, idUsuario) == 1 ? true : false; 
        }

        internal static bool existeMailEmpresa(string p, int idUsuario)
        {
            return SqlConnector.executeProcedure("existe_mailEmpresa", p, idUsuario) == 1 ? true : false; 
        }

        internal static bool existeCuit(string p)
        {
            return SqlConnector.executeProcedure("existe_cuitEmpresa", p) == 1 ? true : false; 
        }
    }
}
