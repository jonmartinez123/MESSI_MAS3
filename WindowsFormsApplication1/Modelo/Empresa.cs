using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Empresa:Modelo.Usuario
    {
        private string razonSocial;
        private string cuit;
        private int calificacionPromedio;
        private DateTime fechaCreacion;
        private string mail;
        private Rubro rubroPrincipal;
        private string nombreContacto;
        private string telefono;
        private Domicilio domicilio;

        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public string Cuit { get { return cuit; } set { cuit = value; } }
        public int CalificacionPromedio { get { return calificacionPromedio; } set { calificacionPromedio = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public Rubro RubroPrincipal { get { return rubroPrincipal; } set { rubroPrincipal = value; } }
        public string NombreContacto { get { return nombreContacto; } set { nombreContacto = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public Domicilio Domicilio { get { return domicilio; } set { domicilio = value; } }

        public Empresa(int id, String username, String password) : base(id, username,password){

        }

        public Empresa() { }
    }
}
