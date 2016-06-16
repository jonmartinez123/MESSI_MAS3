using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Modelo
{
    public class Borrador:Estado
    {
        public Borrador(int id) {
            this.id = id;
        }
        public override void aplicarAccion(Publicar.Listado form,TipoPublicacion tipo)
        {
            form.controlModificar(true);
            form.controlActivar(true);
            form.controlPausar(false);
            form.controlFinalizar(false);
        }
    }
}
