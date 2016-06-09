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

        Modelo.Empresa empresaGlobal;
        public CrearEmpresa(Modelo.Empresa unaEmpresa)
        {
            inicializar();
            empresaGlobal = unaEmpresa;
            cargarCombosBox();
            if (empresaGlobal.tieneId()) cargarFormularioParaModoficacion(unaEmpresa);
        }
 
        private void inicializar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void cargarCombosBox()
        {
            cmbLocalidad.DataSource = DAO.LocalidadSQL.getLocalidades();
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "Id";

            cmbRubro.DataSource = DAO.RubroSQL.getRubros();
            cmbRubro.DisplayMember = "descripcionCorta";
            cmbRubro.ValueMember = "Id";
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
                    string.IsNullOrEmpty(txtCodigoPostal.Text) && string.IsNullOrEmpty(txtNombreContacto.Text) && string.IsNullOrEmpty(txtCiudad.Text))
                    throw new Exception("No puede haber campos vacíos");

                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                    throw new Exception("Debe completar la razón social");

                validarRazonSocial(txtRazonSocial.Text);

                if (string.IsNullOrEmpty(txtCUIT.Text))
                    throw new Exception("Debe completar el número de CUIT");

                validarCUIT(txtCUIT.Text);

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

                if (string.IsNullOrEmpty(txtCiudad.Text))
                    throw new Exception("Debe comppletar la ciudad");

                

                #endregion

                Modelo.Empresa empresaConDatos = cargarEmpresa();
                if (empresaGlobal.tieneId()) {                            //Veo si es para modificar o crear
                    empresaConDatos.Id = empresaGlobal.Id;
                    DAO.UsuarioSQL.modificarEmpresa(empresaConDatos);
                    MessageBox.Show("La empresa se modifico con exito", "Atención");
                }
                else{
                    empresaConDatos.NombreUsuario = empresaGlobal.NombreUsuario;
                    empresaConDatos.Password = empresaGlobal.Password;
                    DAO.UsuarioSQL.crearEmpresa(empresaConDatos);
                    MessageBox.Show("La empresa se creo con exito", "Atención");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención");
            }
        }

        private Empresa cargarEmpresa()
        {
            Modelo.Empresa e = new Modelo.Empresa();

            e.RazonSocial = txtRazonSocial.Text;
            e.Cuit = txtCUIT.Text;
            e.RubroPrincipal = (Rubro)cmbRubro.SelectedItem;
            e.NombreContacto = txtNombreContacto.Text;
            e.Mail = txtMail.Text;

            int tel;
            if (!Int32.TryParse(txtTel.Text, out tel)) throw new Exception("El telefono solo debe contener caracteres numericos");
            e.Telefono = tel.ToString();

            e.Domicilio = new Domicilio();

            e.Domicilio.Calle = txtCalle.Text;

            int altura;
            if (!Int32.TryParse(txtAltura.Text, out altura)) throw new Exception("La altura solo debe contener caracteres numericos");
            e.Domicilio.Altura = altura;

            int piso;
            if (!Int32.TryParse(txtPiso.Text, out piso)) throw new Exception("El piso solo debe contener caracteres numericos");
            e.Domicilio.Piso = piso;

            e.Domicilio.Departamento = txtDepto.Text;

            e.Domicilio.Localidad = new Localidad();
            e.Domicilio.Localidad = (Localidad)cmbLocalidad.SelectedItem;

            int cp;
            if (!Int32.TryParse(txtCodigoPostal.Text, out cp)) throw new Exception("El código postal solo debe contener caracteres numericos");
            e.Domicilio.CodigoPostal = cp;

            e.Domicilio.Ciudad = txtCiudad.Text;

            return e;

        
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this.allowAlphanumericOnly(e);
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
            //this.allowNumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtCodigoPostal, 10, e);
        }

        private void txtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtDepto, 254, e);
        }

        private void cargarFormularioParaModoficacion(Modelo.Empresa unaEmpresa) {
            Modelo.Empresa e = DAO.UsuarioSQL.getEmpresa(unaEmpresa.Id);

            //ActiveForm.Text = "Modificar Usuario";
            btnOK.Text = "Modificar";

            txtRazonSocial.Text = e.RazonSocial;
            txtCUIT.Text = e.Cuit;
            if (e.RubroPrincipal.Id != -1) cmbRubro.SelectedValue = e.RubroPrincipal.Id;
            txtNombreContacto.Text = e.NombreContacto;
            txtMail.Text = e.Mail;
            txtTel.Text = e.Telefono.ToString();
            txtCalle.Text = e.Domicilio.Calle;
            txtAltura.Text = e.Domicilio.Altura.ToString();
            txtPiso.Text = e.Domicilio.Piso.ToString();
            txtDepto.Text = e.Domicilio.Departamento.ToString();
            if (e.Domicilio.Localidad.Id != -1) cmbLocalidad.SelectedValue = e.Domicilio.Localidad.Id;
            txtCiudad.Text = e.Domicilio.Ciudad;
            txtCodigoPostal.Text = e.Domicilio.CodigoPostal.ToString();
    
        }

        void validarRazonSocial(string razon){
            if (DAO.UsuarioSQL.existeRazonSocial(razon)) throw new Exception("La razón social ingresada ya existe");
        }

        void validarCUIT(string cuit)
        {
            if (DAO.UsuarioSQL.existeCUIT(cuit)) throw new Exception("El CUIT ingresado ya existe");
        }
    }
}

