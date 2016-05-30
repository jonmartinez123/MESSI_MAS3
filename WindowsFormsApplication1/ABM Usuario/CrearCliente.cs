﻿using MaterialSkin.Controls;
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
    public partial class CrearCliente : MaterialForm
    {
        Modelo.Usuario usuarioGlobal;

        public CrearCliente(Modelo.Usuario unUsuario)
        {
            inicializar();
            usuarioGlobal = unUsuario;
        }


        private void inicializar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if(e.KeyChar != 8) this.allowMaxLenght(txtNombre, 254, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtApellido, 254, e);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtDocumento, 17, e);
        }

        private bool esInvalidoMail(string mail)
        {
           return !(mail.Contains('@') && mail.Contains('.'));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try{
                #region Validaciones
                var exceptionMessage = string.Empty;

                if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text) && string.IsNullOrEmpty(txtDocumento.Text)
                    && string.IsNullOrEmpty(txtMail.Text) && string.IsNullOrEmpty(txtTel.Text) && string.IsNullOrEmpty(txtCalle.Text) &&
                    string.IsNullOrEmpty(txtPiso.Text) && string.IsNullOrEmpty(txtDepto.Text) && string.IsNullOrEmpty(cmbLocalidad.Text) &&
                    string.IsNullOrEmpty(txtCodigoPostal.Text))
                    throw new Exception("No puede haber campos vacíos");

                if (string.IsNullOrEmpty(txtNombre.Text))
                    throw new Exception("Debe completar el nombre");

                if (string.IsNullOrEmpty(txtApellido.Text))
                    throw new Exception("Debe completar el apellido");

                if (string.IsNullOrEmpty(txtDocumento.Text))
                    throw new Exception("Debe completar el número de documento");

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


                #endregion
            }
            catch (Exception ex){
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
        

    }
}