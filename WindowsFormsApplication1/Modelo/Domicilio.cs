using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Domicilio
    {
        private string calle;
        private int altura;
        private int piso;
        private string departamento;
        private Localidad localidad;
        private string ciudad;
        public string Calle { get { return calle; } set { calle = value; } }
        public int Altura { get { return altura; } set { altura = value; } }
        public int Piso { get { return piso; } set { piso = value; } }
        public string Departamento { get { return departamento; } set { departamento = value; } }
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }
        public Localidad Localidad { get { return localidad; } set { localidad = value; } }
    }
}
