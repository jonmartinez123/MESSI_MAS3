using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.DAO;

namespace MercadoEnvio.Modelo
{
    public class Usuario
    {
        private int id;
        private String nombreUsuario;
        private String contrasenia;
        private String mail;
        private int telefono;
        private Rol rol;
        private TipoUsuario tipo;
        //private List<Rol> roles;
        //private int intentos;
        public int Id { get { return id; } set {id=value;}}
        public String NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        //public int Intentos { get { return 0; }}
        public String Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public String Mail { get { return mail; } set { mail = value; } }
        public Rol Rol { get { return rol; } set { rol = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public TipoUsuario Tipo { get { return tipo; } set { tipo = value; } }

        public Usuario(int id,String username, String password)
        {
            this.id = id;
            this.nombreUsuario = username;
            this.contrasenia = password;
        }

        public Usuario(String username, String password)
        {
            this.nombreUsuario = username;
            this.contrasenia = password;
        }

    }
}
