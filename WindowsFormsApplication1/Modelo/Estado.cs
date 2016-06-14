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
        public int id;
        public string nombre;
        public abstract void aplicarAccion(Form form);
    }
}
