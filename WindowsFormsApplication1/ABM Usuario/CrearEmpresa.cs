using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DAO;
using MercadoEnvio.Utils;
using MercadoEnvio.Modelo;
using MaterialSkin;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class CrearEmpresa : MaterialForm
    {
        public CrearEmpresa()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private bool esInvalidoMail(string mail)
        {
            return !(mail.Contains('@') && mail.Contains('.'));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validaciones
                var exceptionMessage = string.Empty;

                if (string.IsNullOrEmpty(txtRazonSocial.Text) && string.IsNullOrEmpty(txtCUIT.Text) && string.IsNullOrEmpty(cmbRubro.Text)
                    && string.IsNullOrEmpty(txtMail.Text) && string.IsNullOrEmpty(txtTel.Text) && string.IsNullOrEmpty(txtCalle.Text) &&
                    string.IsNullOrEmpty(txtPiso.Text) && string.IsNullOrEmpty(txtDepto.Text) && string.IsNullOrEmpty(cmbLocalidad.Text) &&
                    string.IsNullOrEmpty(txtCodigoPostal.Text) && string.IsNullOrEmpty(txtNombreContacto.Text) && string.IsNullOrEmpty(cmbCiudad.Text))
                    throw new Exception("No puede haber campos vacíos");

                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                    throw new Exception("Debe completar la razón social");

                if (string.IsNullOrEmpty(txtCUIT.Text))
                    throw new Exception("Debe completar el número de CUIT");

                if (string.IsNullOrEmpty(cmbRubro.Text))
                    throw new Exception("Debe seleccionar el rubro principal");

                if (string.IsNullOrEmpty(txtMail.Text))
                    throw new Exception("Debe completar el mail");

                if (esInvalidoMail(txtMail.Text))
                    throw new Exception("El mail ingresado no es válido");

                if (string.IsNullOrEmpty(txtTel.Text))
                    throw new Exception("Debe completar el número de telefono");

                if (string.IsNullOrEmpty(txtCalle.Text))
                    throw new Exception("Debe completar el nombre de la calle");

                if (string.IsNullOrEmpty(txtPiso.Text))
                    throw new Exception("Debe completar el piso");

                if (string.IsNullOrEmpty(txtDepto.Text))
                    throw new Exception("Debe completar el número de departamento");

                if (string.IsNullOrEmpty(cmbLocalidad.Text))
                    throw new Exception("Debe seleccionar una localidad");

                if (string.IsNullOrEmpty(txtCodigoPostal.Text))
                    throw new Exception("Debe completar el código postal");

                if (string.IsNullOrEmpty(txtNombreContacto.Text))
                    throw new Exception("Debe completar el nombre del contacto");

                if (string.IsNullOrEmpty(cmbCiudad.Text))
                    throw new Exception("Debe seleccionar una ciudad");


                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención");
            }
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtMail, 254, e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtTel, 14, e);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtCalle, 99, e);
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtAltura, 17, e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtPiso, 17, e);
        }

        private void txtDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphaOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtDepto, 49, e);
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtCodigoPostal, 17, e);
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtDepto, 254, e);
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtCodigoPostal, 10, e);
        }

        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtDepto, 254, e);
        }


    }
}
