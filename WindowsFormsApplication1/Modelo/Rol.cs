using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Rol
    {
        private int id;
        private String nombre;
        private List<Funcionalidad> funcionalidades;
        public List<Funcionalidad> Funcionalidades { get { return funcionalidades; } set { funcionalidades = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public int Id { get { return id; } set { id = value; } }

    }
}
