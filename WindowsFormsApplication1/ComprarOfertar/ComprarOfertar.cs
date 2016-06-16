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
            filtrar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            List<Modelo.Publicacion> pDeRubro = new List<Modelo.Publicacion>();
            DataTable dtAAcumular = new DataTable();
            superGrid1.SelectAll();
            superGrid1.ClearSelection();

            if (rubrosFiltrados.Count() > 0)
            {
                foreach (Rubro r in rubrosFiltrados)
                {
                    dtAAcumular = DAO.PublicacionSQL.filtrarPublicacionesPorRubro(dtAAcumular, r.Id, txtDescripcion.Text.ToString());
                }
            }
            else
            {
                dtAAcumular = DAO.PublicacionSQL.filtrarPubliacionesPorDescripcion(dtAAcumular, txtDescripcion.Text.ToString());
            }

            if (dtAAcumular.Rows.Count > 0)
            {
                DAO.SqlConnector.bindNamesToDataTable(dtAAcumular, superGrid1);
                superGrid1.DataSource = dtAAcumular;
                superGrid1.SetPagedDataSource(dtAAcumular, bindingNavigator1);
                superGrid1.Sort(this.superGrid1.Columns["colVisibilidadId"], ListSortDirection.Ascending);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            rubrosFiltrados.Clear();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (superGrid1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.superGrid1.SelectedRows[0];

                Modelo.Publicacion p = new Modelo.Publicacion();
                p.Id = Convert.ToInt16(row.Cells["colPublicacionId"].Value);

                if (row.Cells["colTipoPublicaion"].Value.ToString() == "Subasta"){
                    Ofertar po = new Ofertar(p);
                    po.ShowDialog();
                }else{
                    int stock = int.Parse(row.Cells["colStock"].Value.ToString());
                    if (stock > 0){
                        p.Stock = stock;
                        p.Descripcion = row.Cells["colDescripcion"].Value.ToString();
                        p.Precio = double.Parse(row.Cells["colPrecio"].Value.ToString());
                        Comprar po = new Comprar(p);
                        po.ShowDialog();
                    }
                    else {
                        MessageBox.Show("La publicacion seleccionda no tiene stock", "Atención");
                    }

                }

            }
            else {
                MessageBox.Show("Debe seleccionar una publicacion", "Atención");
            }
        }

        private void btnSeleccionarRubros_Click(object sender, EventArgs e)
        {
            SeleccionRubros sR = new SeleccionRubros(rubrosFiltrados);
            sR.Show();
        }

        private void superGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (superGrid1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.superGrid1.SelectedRows[0];
                string tipo = row.Cells["colTipoPublicaion"].Value.ToString();

                if (tipo == "Subasta")
                {
                    btnComprar.Text = "Ofertar";
                }
                else
                {
                    btnComprar.Text = "Comprar";
                }
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) this.allowMaxLenght(txtDescripcion, 254, e);
        }

    }
}
