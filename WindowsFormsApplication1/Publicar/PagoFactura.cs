using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Modelo;
using System.Windows.Forms;

namespace MercadoEnvio.Publicar
{
    public partial class PagoFactura : MaterialForm
    {
        public Publicacion publicacion;
        public PagoFactura(Publicacion publicacion)
        {
            this.publicacion = publicacion;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void PagoFactura_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            lblDescripcion.Text = publicacion.Descripcion;
            lblPrecio.Text = publicacion.Visibilidad.Precio.ToString();
            lblVisibilidad.Text = publicacion.Visibilidad.Descripcion;
            cargarMediosDePago();
        }
        private void cargarMediosDePago() {
            cmbMedioDePago.DataSource = DAO.FormaDePago.getFormasDePago();
            cmbMedioDePago.DisplayMember = "Nombre";
            cmbMedioDePago.ValueMember = "Id";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbMedioDePago.SelectedIndex != -1) {
                Modelo.FormaDePago f = (Modelo.FormaDePago)cmbMedioDePago.SelectedItem;
                if (f != null) {
                    int idFactura = DAO.PublicacionSQL.activarPublicacion(publicacion.Id,publicacion.FechaInicio,Persistencia.usuario.Id,f.Id,publicacion.Visibilidad.Precio);
                    DAO.PublicacionSQL.updetearEstado(publicacion.Id,2);
                    VisualizadorFactura vis = new VisualizadorFactura(idFactura);
                    vis.Show();
                    vis.BringToFront();
                    this.Close();
                }
            }
        }
    }
}
