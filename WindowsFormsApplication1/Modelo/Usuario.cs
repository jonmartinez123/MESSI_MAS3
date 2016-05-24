using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Usuario
    {
        private String username { get; set; }
        private String password { get; set; }
        private int intentos { get; set; }
        private Boolean estado { get; set; }
        private String rol { get; set; }
        public String Username { get { return username; } set { username = value; } }
        public String Password { get { return password; } set { password = value; } }
        public int Intentos { get { return intentos; } set { intentos = value; } }
        public  Boolean Estado { get { return estado; } set { estado = value; } }
        public String Rol { get { return rol; } set { rol = value; } }
        public int IDRol { get; set; }

        public Usuario(String username, String password)
        {
            this.username = username;
            this.password = password;
            this.intentos = 0;
        }
    }
}
