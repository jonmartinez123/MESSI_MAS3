using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Funcionalidad
    {
        private int id;
        private String descripcion;
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Id { get { return id; } set { id = value; } }

        public static Funcionalidades? obtenerEnum(string func)
        {
            if (func == "ABM ROL") return Funcionalidades.ABM_Rol;
            if (func == "ABM USUARIO") return Funcionalidades.ABM_Usuario;
            if (func == "ABM RUBRO") return Funcionalidades.ABM_Rubro;
            if (func == "ABM VISIBILIDAD") return Funcionalidades.ABM_Visibilidad;
            if (func == "PUBLICAR") return Funcionalidades.Publicar;
            if (func == "COMPRAR/OFERTAR") return Funcionalidades.ComprarOfertar;
            if (func == "HISTORIAL DE CLIENTE") return Funcionalidades.Historial_De_Cliente;
            if (func == "CALIFICAR AL VENDEDOR") return Funcionalidades.Calificar_Al_Vendedor;
            if (func == "CONSULTAR FACTURAS") return Funcionalidades.Consultar_Facturas;
            if (func == "Listado Estadistico") return Funcionalidades.Listado_Estadistico;
            return null;
        }
        public enum Funcionalidades
        {
            ABM_Rol,
            ABM_Usuario,
            ABM_Rubro,
            ABM_Visibilidad,
            Publicar,
            ComprarOfertar,
            Historial_De_Cliente,
            Calificar_Al_Vendedor,
            Consultar_Facturas,
            Listado_Estadistico
        }
    }
}
