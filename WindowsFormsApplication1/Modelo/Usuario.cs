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
        private String password;
        private Rol rol;

        public int Id { get { return id; } set { id = value; } }
        public String NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public String Password { get { return password; } set { password = value; } }
        public Rol Rol { get { return rol; } set { rol = value; } }

        //private List<Rol> roles;
        //private int intentos;
        //public int Intentos { get { return 0; }}

        public Usuario()
        {
        }

        public Usuario(int id,String username, String password)
        {
            this.id = id;
            this.nombreUsuario = username;
            this.password = password;
        }

        public Usuario(String username, String password)
        {
            this.nombreUsuario = username;
            this.password = password;
        }

        public bool tieneId(){
            return this.Id != -1;
        }

    }
}
