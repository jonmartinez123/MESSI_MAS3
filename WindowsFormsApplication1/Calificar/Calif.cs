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
using MercadoEnvio.Modelo;

namespace MercadoEnvio.Calificar
{
    public partial class Calif : MaterialForm
    {
        public Calif()
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
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
        }

        public void reload() {
            DAO.CalificacionSQL.getCalificacionesPendientes(calificacionesPendientes);
          DAO.CalificacionSQL.getHistoricoCalificaciones(historicoCalificacionesUltimas);
           DAO.CalificacionSQL.getComprasXEstrellas(comprasxEstrellas);
        }

        private void calificar_button_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount =
        calificacionesPendientes.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 1)
            {

                Extension.openInNewWindow(this, (new darCalificacion(this, getCurrentCalificacion())));
            }


        }

        private Modelo.Calificacion getCurrentCalificacion()
        {
            return new Modelo.Calificacion(Convert.ToDecimal(Extension.cellValue(this.calificacionesPendientes, "idCalif")));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Calif_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (calificacionesPendientes.Rows.Count > 2)
            {
                var window = MessageBox.Show(this, "Existen mas de 3 calificaciones pendientes, califique para proseguir", "Calificaciones pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (window == DialogResult.OK)
                { e.Cancel = true; }
            }
        }
    }
}
