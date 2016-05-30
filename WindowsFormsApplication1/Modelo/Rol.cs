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
        public String nombre;
        public Boolean habilitado;
        private List<Funcionalidad> funcionalidades;
        private List<String> funcionalidadesString; //Cambie de Funcionalidades a String
        public List<Funcionalidad> getFuncionalidades { get { return funcionalidades; } set { funcionalidades = value; } }
        public List<String> getFuncionalidadesString { get { return funcionalidadesString; } set { funcionalidadesString = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public int getid { get { return id; } set { id = value; } }

        //constructores

        public Rol() { }
        public Rol(String nombre, Boolean habilitado, List<String> funcionalidades)
        {
            this.nombre = nombre;
            this.habilitado = habilitado;
            this.funcionalidadesString = funcionalidades;

        }

        public Rol(String nombre, Boolean habilitado)
        {
            this.nombre = nombre;
            this.habilitado = habilitado;
        }

        public Rol(Decimal id, String nombre, Boolean habilitado)
        {
            this.id = Decimal.ToInt32(id);
            this.nombre = nombre;
            this.habilitado = habilitado;


        }

    }
}
