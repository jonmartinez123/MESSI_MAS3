using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Modelo
{
    public class Activa:Estado
    {
        public Activa(int id) {
            this.id = id;
        }
        public override void aplicarAccion(Publicar.Listado form,TipoPublicacion tipo) {
            form.controlModificar(false);
            form.controlActivar(false);
            form.controlPausar(true);
            form.controlFinalizar(true);
        }
    }
}
