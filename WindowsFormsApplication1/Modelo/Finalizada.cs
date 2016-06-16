using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Modelo
{
    public class Finalizada:Estado
    {
        public Finalizada(int id) {
            this.id = id;
        }
        public override  void aplicarAccion(Publicar.Listado form,TipoPublicacion tipo) {
            form.controlFinalizar(false);
            form.controlModificar(false);
            form.controlActivar(false);
            form.controlPausar(false);
        }
    }
}
