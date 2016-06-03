using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    class Calificacion
    {
        public int idCalificacion;
        public String detalleCalif;
        public int idVendedor;
        public String tipoPubli;
        public int idClienteCalificador;
        public int getid { get { return idCalificacion; } set { idCalificacion = value; } }
        public int cantidadEstrellas;


        //Constructores
        public Calificacion() { }
        public Calificacion(Int32 id, String detalle, String tipo, Int32 estrellas)
        {
            this.idCalificacion = id;
            this.detalleCalif = detalle;
            this.tipoPubli = tipo;
            this.cantidadEstrellas = estrellas;
        }

        public Calificacion(Int32 id, String detalle, Int32 estrellas)
        {
            this.idCalificacion = id;
            this.detalleCalif = detalle;
            this.cantidadEstrellas = estrellas;
        }


    }
}
