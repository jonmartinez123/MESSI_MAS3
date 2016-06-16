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
            this.Close();
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            //listadoPublicaciones.Sort(Salida, System.ComponentModel.ListSortDirection.Ascending);
        }
        private void reload() {
            DAO.PublicacionSQL.getPublicaciones(listadoPublicaciones, Persistencia.usuario.Id);
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            reload();
            listadoPublicaciones.MultiSelect = false;
            listadoPublicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            if (listadoPublicaciones.SelectedRows.Count != 0)
            {
                Detalles d = new Detalles(getSeleccionado());
                d.Show();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listadoPublicaciones.Rows.Count > 0)
            {
                //abrir form modificar
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
            return new Modelo.Visibilidad((Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "VisiblidadId"))),
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
            return new Modelo.Publicacion(id,crearTipoPublicacion(),crearEstado(), crearVisibilidad(), crearRubros(id),
                Convert.ToDateTime(Extension.cellValue(listadoPublicaciones, "FechaInicio")),
                Convert.ToDateTime(Extension.cellValue(listadoPublicaciones, "FechaFin")),
                Convert.ToString(Extension.cellValue(listadoPublicaciones, "Descripcion")),
                Convert.ToDouble(Extension.cellValue(listadoPublicaciones, "Precio")),
                Convert.ToInt32(Extension.cellValue(listadoPublicaciones, "Stock")));
        }
        private void listadoPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            publicacion= this.getSeleccionado();
            publicacion.Estado.aplicarAccion(this,publicacion.tipoPublicacion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void listadoPublicaciones_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            publicacion = null;
        }
    }
}
