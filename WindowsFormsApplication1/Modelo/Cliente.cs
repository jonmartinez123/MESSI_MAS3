using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Utils
{
    public class Cliente : Utils.Usuario{
        private string nombre;
        private string apellido;
        private int dni;
        private TipoDocumento tipoDocumento;
        private String mail;
        private int telefono;
        private DateTime fechaNacimiento;
        private DateTime fechaCreacion;
        private Domicilio domicilio;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int DNI { get { return dni; } set { dni = value; } }
        public TipoDocumento TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
        public Domicilio Domicilio { get { return domicilio; } set { domicilio = value; } }

        public Cliente(int id, String username, String password) : base(id, username,password){

        }

        public Cliente() { }

    }
}
