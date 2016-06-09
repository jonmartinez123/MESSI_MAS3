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
        private int idEstado;
        private int idVisibilidad;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string descripcion;
        private int idRubro;
        private double minimoSubasta;
        private double precio;
        private int stock;
        private int tipoPublicidad;
        public int Id { get { return id; } set { id = value; } }
        public int IdEstado  { get { return idEstado; } set { idEstado = value; } }
        public int IdVisibilidad  { get { return idVisibilidad; } set { idVisibilidad = value; } }
        public DateTime FechaInicio  { get { return fechaInicio; } set { fechaInicio = value; } }
        public DateTime FechaFin  { get { return fechaFin; } set {fechaFin = value; } }
        public string Descripcion  { get { return descripcion; } set { descripcion = value; } }
        public int IdRubro  { get { return idRubro; } set { idRubro = value; } }
        public double MinimoSubasta { get { return minimoSubasta; } set {minimoSubasta = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public int TipoPublicidad { get { return tipoPublicidad; } set { tipoPublicidad = value; } }
    }
}
