using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Utils
{
    public class Visibilidad
    {
        private int id;
        private int codigo;
        private string descripcion;
        private double precio;
        private double porcentaje;
        private double costoEnvio;
        public int Id { get { return id; } set { id = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public double Porcentaje { get { return porcentaje; } set { porcentaje = value; } }
        public double CostoEnvio { get { return costoEnvio; } set { costoEnvio = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public Visibilidad(int id, int codigo, string descripcion, double precio, double porcentaje, double costoEnvio)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Porcentaje = porcentaje;
            this.CostoEnvio = costoEnvio;
        }

        public Visibilidad()
        {
        }
    }
}
