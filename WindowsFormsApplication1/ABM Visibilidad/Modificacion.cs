using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MercadoEnvio.Modelo;

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class Modificacion : MaterialForm
    {
        private Modelo.Visibilidad visibilidad { get; set; }

        public Modificacion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            setCamposDefault();
        }
        public Modificacion(Modelo.Visibilidad vi)
        {
            visibilidad = vi;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            setCamposDefault();
        }
        private void setCamposDefault()
        {
            txtDescripcion.Text = visibilidad.Descripcion;
            txtCodigo.Text = visibilidad.Codigo.ToString();
            txtPorcentaje.Text = visibilidad.Porcentaje.ToString();
            txtPrecio.Text = visibilidad.Precio.ToString();
            txtCostoEnvio.Text = visibilidad.CostoEnvio.ToString();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            setCamposDefault();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtCodigo.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtPorcentaje.Text) && !string.IsNullOrWhiteSpace(txtCostoEnvio.Text))
            {
                if (seteoCampos())
                {
                    actualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Aviso");
            }
        }
        private void actualizarGrilla()
        {
            ListadoVisibilidades.Rows.Clear();
            ListadoVisibilidades.Rows.Add(visibilidad.Codigo, visibilidad.Descripcion, visibilidad.Precio, visibilidad.Porcentaje,visibilidad.CostoEnvio);
        }
        #region Validaciones

        private void txtCostoEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnlyParaDouble(e);
            this.allowMaxLenght(txtCostoEnvio, 18, e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnlyParaDouble(e);
            this.allowMaxLenght(txtPorcentaje, 18, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnlyParaDouble(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtCodigo, 18, e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            this.allowMaxLenght(txtDescripcion, 255, e);
        }
        #endregion
        private bool seteoCampos()
        {
            visibilidad.Descripcion = txtDescripcion.Text;
            visibilidad.Codigo = Convert.ToInt32(txtCodigo.Text);
            try
            {
                visibilidad.Porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            }
            catch { MessageBox.Show("Escriba en formato apropiado el porcentaje", "Validacion"); return false; }
            try
            {
                visibilidad.Precio = Convert.ToDouble(txtPrecio.Text);
            }
            catch { MessageBox.Show("Escriba en formato apropiado el precio", "Validacion"); return false; }
            try
            {
                visibilidad.CostoEnvio = Convert.ToDouble(txtCostoEnvio.Text);
            }
            catch { MessageBox.Show("Escriba en formato apropiado el costo de envio", "Validacion"); return false; }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtCodigo.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtPorcentaje.Text) && !string.IsNullOrWhiteSpace(txtCostoEnvio.Text))
            {
                if (seteoCampos())
                {
                    actualizarGrilla();
                    int error = DAO.VisibilidadSQL.modificarVisibilidad(visibilidad.Id, visibilidad.Codigo, visibilidad.Descripcion, visibilidad.Porcentaje, visibilidad.Precio, visibilidad.CostoEnvio);
                    if (error == -1)
                    {
                        MessageBox.Show("Ingrese otro codigo, el " + visibilidad.Codigo + " ya se encuentra utilizado", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Se ha guardado la visibilidad con la informacion de la grilla", "Exito");
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Aviso");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Visibilidad vis = new Visibilidad();
            vis.ShowDialog();
            this.Close();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            ListadoVisibilidades.MultiSelect = false;
            ListadoVisibilidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
