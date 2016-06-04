using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MercadoEnvio.Calificar
{
    public partial class Calificar : MaterialForm
    {
        public Calificar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Calificar_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void cerrarCalificacion_button_Click(object sender, EventArgs e)
        {
           
        }

        private void reload() {
            DAO.CalificacionSQL.getCalificacionesPendientes(calificacionesPendientes);
          DAO.CalificacionSQL.getHistoricoCalificaciones(historicoCalificacionesUltimas);
           DAO.CalificacionSQL.getComprasXEstrellas(comprasxEstrellas);
        }
    }
}
