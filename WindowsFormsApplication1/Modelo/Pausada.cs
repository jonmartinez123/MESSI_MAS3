using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Modelo
{
    public class Pausada:Estado
    {
        public Pausada(int id) {
            this.id = id;
        }

        public override void aplicarAccion(Publicar.Listado form,TipoPublicacion tipo) {
            form.controlPausar(false);
            form.controlModificar(false);
            form.controlFinalizar(false);
            form.controlActivar(true);
           
            //VALIDAR PARA QUE NO SE PUEDA COMPRAR NI OFERTAR
        }
    }
}
