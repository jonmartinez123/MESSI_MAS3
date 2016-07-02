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
        int estaFiltrando;

        public ComprarOfertar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            rubrosFiltrados = new List<Rubro>();
            estaFiltrando = 0;
            refresh();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            estaFiltrando = 1;
            List<Modelo.Publicacion> pDeRubro = new List<Modelo.Publicacion>();
            DataTable idRubros = new DataTable("Rubros");
            idRubros.Columns.Add("idRubro", typeof(Int32));
            foreach (Rubro r in rubrosFiltrados){
                idRubros.Rows.Add(r.Id);
            }
            if (cbRubro.Checked)
            {
                DAO.PublicacionSQL.filtrarPublicacionesPorRubro(superGrid1, idRubros, txtDescripcion.Text.ToString());
            }
            else
            {
                DAO.PublicacionSQL.filtrarPublicacionesPorDescripcion(superGrid1, txtDescripcion.Text.ToString());
            }
            superGrid1.Sort(this.superGrid1.Columns["colVisibilidadId"], ListSortDirection.Ascending);
        }

        private void obtenerTodasPublicaciones()
        {
            DAO.PublicacionSQL.obtenerPublicacionesActivas(superGrid1);
        }
        /*
        private void volcarDatosASuperGrid(DataTable dtAAcumular)
        {
            if (dtAAcumular.Rows.Count > 0)
            {
                DAO.SqlConnector.bindNamesToDataTable(dtAAcumular, superGrid1);
                superGrid1.DataSource = dtAAcumular;
                superGrid1.SetPagedDataSource(dtAAcumular, bindingNavigator1);
                superGrid1.Refresh();
                superGrid1.Sort(this.superGrid1.Columns["colVisibilidadId"], ListSortDirection.Ascending);
            }
        }
        */
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
                p.Id = int.Parse(row.Cells["colPublicacionId"].Value.ToString());

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
                        refresh();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
        }

        public void refresh() {
            if (estaFiltrando == 1){
                filtrar();

            }
            else {
                DAO.PublicacionSQL.obtenerPublicacionesActivas(superGrid1);
                superGrid1.Sort(this.superGrid1.Columns["colVisibilidadId"], ListSortDirection.Ascending);
            }
        }

        private void ComprarOfertar_Load(object sender, EventArgs e)
        {
            int tieneMasDe3Calificaciones;
            tieneMasDe3Calificaciones = DAO.SqlConnector.executeProcedure("tieneMasde3calificacionesPendientesSegun", Persistencia.usuario.Id);
            if (tieneMasDe3Calificaciones == 1)
            {
                var window = MessageBox.Show(this, "Existen mas de 3 calificaciones pendientes, califique para proseguir", "Calificaciones pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Calificar.Calif cal = new Calificar.Calif();
                cal.ShowDialog();
                this.Close();

            }
        }

        private void cbRubro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRubro.Checked)
            {
                btnSeleccionarRubros.Visible = true;
            }
            else {
                btnSeleccionarRubros.Visible = false;
            }
        }

    }
}
