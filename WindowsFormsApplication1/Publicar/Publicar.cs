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
using MaterialSkin.Controls;
using MaterialSkin;

namespace MercadoEnvio.Publicar
{
    public partial class Publicar : MaterialForm
    {
        public Publicar()
        {
            InitializeComponent();
            aplicarDefault();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void aplicarDefault()
        {
            listadoRubro.MultiSelect = false;
            listadoRubro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListadoVisibilidades.MultiSelect = false;
            ListadoVisibilidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtFin.MinDate = Config.ConfiguracionVariable.FechaSistema.AddDays(1);
            dtInicio.MinDate = Config.ConfiguracionVariable.FechaSistema;
            rbCompra.Select();
        }
        private void Publicar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void rbCompra_CheckedChanged(object sender, EventArgs e)
        {
            gbSubasta.Visible = false;
        }

        private void rbSubasta_CheckedChanged(object sender, EventArgs e)
        {
            gbSubasta.Visible = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado la publicacion con exito, ahora esta visible a todos","Exito");
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha guardado la publicacion con exito","Exito");
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            this.allowMaxLenght(txtDescripcion, 255, e);
        }
    }
}
