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
        private Rol rol;
        //private List<Rol> roles;
        //private int intentos;
        public int Id { get { return id; } set {id=value;}}
        public String NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        //public int Intentos { get { return 0; }}
        public String Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public String Mail { get { return mail; } set { mail = value; } }
        public Rol Rol { get { return rol; } set { rol = value; } }

        public Usuario(String username, String password)
        {
            this.nombreUsuario = username;
            this.contrasenia = password;
        }

    }
}
