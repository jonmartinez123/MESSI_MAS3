using MercadoEnvio.ABM_Rubro;
using MercadoEnvio.ABM_Visibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Publicacion
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string descripcion;
        private double minimoSubasta;
        private double precio;
        private int stock;
        private int tipoPublicidad;
        public Estado Estado;
        public Visibilidad Visibilidad;
        public Rubro Rubro;

        public int Id { get { return id; } set { id = value; } }
        public DateTime FechaInicio { get { return fechaInicio; } set { fechaInicio = value; } }
        public DateTime FechaFin { get { return fechaFin; } set { fechaFin = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public double MinimoSubasta { get { return minimoSubasta; } set { minimoSubasta = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int TipoPublicidad { get { return tipoPublicidad; } set { tipoPublicidad = value; } }
        
        public Publicacion(int publicacion_id, Estado estado, Visibilidad visibilidad, DateTime publicacion_fechaInicio, DateTime publicacion_fechaFin, string publicacion_descripcion, double publicacion_precio, Rubro rubro, int publicacion_stock)
        {
            this.Id = publicacion_id;
            this.Estado = estado;
            this.Visibilidad = visibilidad;
            this.fechaInicio = publicacion_fechaInicio; this.FechaFin = publicacion_fechaFin; this.Descripcion = publicacion_descripcion; this.Precio = publicacion_precio; this.Rubro = rubro; this.stock = publicacion_stock;
        }

        public Publicacion() { }
    }
}
