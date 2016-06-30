using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Modelo;

namespace MercadoEnvio.Publicar
{
    public partial class Listado : MaterialForm
    {
        Modelo.Publicacion publicacion;
        public Listado()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            FormCollection formsabiertos = Application.OpenForms;
            var booleanoMenuUsuarioAbierto = new Boolean();
            booleanoMenuUsuarioAbierto = false;

            foreach (Form frm in formsabiertos)
            {
                if (frm.Text == "MenuUsuario")
                {
                    booleanoMenuUsuarioAbierto = true;
                }
            }

            if (booleanoMenuUsuarioAbierto) {
                this.Close();
                return;
            }
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
           
            
        }

        private void reload() {
            DAO.PublicacionSQL.getPublicaciones(listadoPublicaciones, Persistencia.usuario.Id);
        }

        private void Listado_Load(object sender, EventArgs e)
        {

            
            reload();
            listadoPublicaciones.MultiSelect = false;
            listadoPublicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (listadoPublicaciones.Rows.Count > 0)
            {
                listadoPublicaciones.Rows[0].Selected = true;
            }
            else {
                gbControles.Visible = false;
            }
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            if (listadoPublicaciones.SelectedRows.Count != 0)
            {
                Detalles d = new Detalles();
                d.publicacion = getSeleccionado();
                d.ShowDialog();
            }
            else { MessageBox.Show("Debe seleccionar una publicacion para ver mas detalles", "Error"); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listadoPublicaciones.SelectedRows.Count != 0)
            {
                Publicar p = new Publicar();
                p.pub = getSeleccionado();
                p.ShowDialog();
                this.Close();
            }
        }
        private List<Rubro> crearRubros(int idPublicacion) {
            return DAO.PublicacionSQL.getRubrosPorPublicacion(idPublicacion);
        }
        private Modelo.Estado crearEstado(){
            Modelo.Estado estado = null;
            int idEstado = Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "EstadoId"));
            switch(Modelo.Estado.obtenerEnum(Convert.ToString(Extension.cellValue(listadoPublicaciones, "EstadoNombre")))){
                case Modelo.Estado.Estados.Borrador:
                    estado = new Borrador(idEstado);
                break;
                case Modelo.Estado.Estados.Activa:
                    estado = new Activa(idEstado);
                break;
                case Modelo.Estado.Estados.Pausada:
                    estado = new Pausada(idEstado);
                break;
                case Modelo.Estado.Estados.Finalizada:
                    estado = new Finalizada(idEstado);
                break;

            }
            return estado;
        }
         #region habilitar/deshabilitar
        public void controlModificar(Boolean enable)
        {
            btnModificar.Visible = enable;
        }
        public void controlActivar(Boolean enable) {
            btnActivar.Visible = enable;
        }
        public void controlPausar(Boolean enable) {
            btnPausar.Visible = enable;
        }
        public void controlFinalizar(Boolean enable)
        {
            btnFinalizar.Visible = enable;
        }
        #endregion 
        private Modelo.Visibilidad crearVisibilidad()
        {
            int idVisibilidad = Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "VisibilidadId"));
            return new Modelo.Visibilidad(idVisibilidad,
                Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "VisibilidadCodigo")),
           Convert.ToString(Extension.cellValue(listadoPublicaciones, "VisibilidadDescripcion")),
           Convert.ToDouble(Extension.cellValue(listadoPublicaciones, "VisibilidadPrecio")),
           Convert.ToDouble(Extension.cellValue(listadoPublicaciones, "VisibilidadPorcentaje")),
           Convert.ToDouble(Extension.cellValue(listadoPublicaciones, "VisibilidadCostoEnvio"))
           );
        }
        private Modelo.TipoPublicacion crearTipoPublicacion()
        {
            return new Modelo.TipoPublicacion((Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "TipoPublicacionId"))),
           Convert.ToString(Extension.cellValue(listadoPublicaciones, "TipoPublicacionNombre")),
           Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "TipoPublicacionTieneEnvio"))
           );
        }
        private Modelo.Publicacion getSeleccionado() {
            int id = Convert.ToInt32(Extension.cellValue(this.listadoPublicaciones, "Id"));
            return new Modelo.Publicacion(id,crearTipoPublicacion(),
                crearEstado(), 
                crearVisibilidad(), 
                crearRubros(id),
                Convert.ToDateTime(Extension.cellValue(listadoPublicaciones, "FechaInicio")),
                Convert.ToDateTime(Extension.cellValue(listadoPublicaciones, "FechaFin")),
                Convert.ToString(Extension.cellValue(listadoPublicaciones, "Descripcion")),
                Extension.cellValueParaNumeros(listadoPublicaciones, "MinimoSubasta"),
                Convert.ToDouble(Extension.cellValue(listadoPublicaciones, "Precio")),
                Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "QuisoEnvio")),
                Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "Stock")));
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Publicar p = new Publicar();
            p.Show();
            this.Close();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            PagoFactura p = new PagoFactura(publicacion);
            p.ShowDialog();
            int indice = listadoPublicaciones.SelectedRows[0].Index;
            reload();
            listadoPublicaciones.Rows[indice].Selected = true;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            DAO.PublicacionSQL.updetearEstado(publicacion.Id, 3);
            int indice = listadoPublicaciones.SelectedRows[0].Index;
            reload();
            listadoPublicaciones.Rows[indice].Selected = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DAO.PublicacionSQL.updetearEstado(publicacion.Id, 4);
            int indice = listadoPublicaciones.SelectedRows[0].Index;
            reload();
            listadoPublicaciones.Rows[indice].Selected = true;
        }

        private void listadoPublicaciones_SelectionChanged(object sender, EventArgs e)
        {
            publicacion = null;
            publicacion = this.getSeleccionado();
            publicacion.Estado.aplicarAccion(this, publicacion.tipoPublicacion);
        }
    }
}
