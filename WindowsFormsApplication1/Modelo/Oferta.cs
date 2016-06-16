using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Oferta
    {
        private int id;
        private double valor;
        private Modelo.Usuario usuario;
        private Modelo.Publicacion publicacion;

        public int Id { get { return id; } set { id = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public Modelo.Usuario Usuario { get { return usuario; } set { usuario = value; } }
        public Modelo.Publicacion Publicacion { get { return publicacion; } set { publicacion = value; } }

        public Oferta(double valor, int idUsuario, int idPublicacion) {
            this.Valor = valor;
            this.Usuario = new Modelo.Usuario();
            this.Usuario.Id = idUsuario;
            this.Publicacion = new Modelo.Publicacion();
            this.Publicacion.Id = idPublicacion;
        }

        public Oferta() { }
    }
}
