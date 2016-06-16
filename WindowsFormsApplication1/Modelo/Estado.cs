using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MercadoEnvio.Modelo
{
    public abstract class Estado
    {
        protected int id;
        public abstract void aplicarAccion(Publicar.Listado form,TipoPublicacion tipo);
        public static Estados? obtenerEnum(string func)
        {
            if (func == "Borrador") return Estados.Borrador;
            if (func == "Activa") return Estados.Activa;
            if (func == "Pausada") return Estados.Pausada;
            if (func == "Finalizada") return Estados.Finalizada;
            return null;
        }
        public enum Estados
        {
            Borrador,
            Activa,
            Pausada,
            Finalizada
        }
    }
}
