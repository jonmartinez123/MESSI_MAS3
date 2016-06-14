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
using MercadoEnvio.Utils;

namespace MercadoEnvio.ComprarOfertar
{
    public partial class ComprarOfertar : MaterialForm
    {
        public static List<Rubro> rubrosFiltrados;

        public ComprarOfertar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            rubrosFiltrados = new List<Rubro>();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Modelo.Publicacion> pDeRubro = new List<Modelo.Publicacion>();
            DataTable dtAAcumular = new DataTable();
            superGrid1.clean();

            if (rubrosFiltrados.Count() > 0) {
                foreach (Rubro r in rubrosFiltrados){
                   dtAAcumular = DAO.PublicacionSQL.filtrarPublicacionesPorRubro(dtAAcumular, r.Id, txtDescripcion.Text.ToString());
                }
            }
            else {
                dtAAcumular = DAO.PublicacionSQL.filtrarPubliacionesPorDescripcion(dtAAcumular, txtDescripcion.Text.ToString());
            }

            if (dtAAcumular.Rows.Count > 0)
            {
                DAO.SqlConnector.bindNamesToDataTable(dtAAcumular, superGrid1);
                superGrid1.DataSource = dtAAcumular;
                superGrid1.SetPagedDataSource(dtAAcumular, bindingNavigator1);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            rubrosFiltrados.Clear();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarRubros_Click(object sender, EventArgs e)
        {
            SeleccionRubros sR = new SeleccionRubros(rubrosFiltrados);
            sR.Show();
        }

    }
}
