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
using MercadoEnvio.Modelo;
using MaterialSkin;


namespace MercadoEnvio.ABM_Usuario
{
    public partial class CrearCliente : MaterialForm
    {
        Modelo.Cliente clienteGlobal;

        public CrearCliente(Modelo.Cliente unCliente)
        {
            inicializar();
            clienteGlobal = unCliente;
            if (clienteGlobal.tieneId()) cargarFormularioParaModoficacion(unCliente);
        }

        private void inicializar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            cargarCombosBox();
        }

        private void cargarCombosBox()
        {
            cmbLocalidad.DataSource = DAO.LocalidadSQL.getLocalidades();
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "Id";

            cmbTipo.DataSource = DAO.TipoDocumentoSQL.getTipoDocumentos();
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "Id";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            if (e.KeyChar != 8) this.allowMaxLenght(txtNombre, 254, e);
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
            try
            {
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

                Modelo.Cliente clienteConDatos = cargarCliente();
                if (clienteGlobal.tieneId()){                            //Veo si es para modificar o crear
                    clienteConDatos.Id = clienteGlobal.Id;
                    DAO.UsuarioSQL.modificarCliente(clienteConDatos);
                    MessageBox.Show("El cliente se modifico con exito", "Atención");
                }
                else {
                    clienteConDatos.NombreUsuario = clienteGlobal.NombreUsuario;
                    clienteConDatos.Password = clienteGlobal.Password;
                    DAO.UsuarioSQL.crearCliente(clienteConDatos);
                    MessageBox.Show("El cliente se creo con exito", "Atención");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención");
            }
        }

        private Cliente cargarCliente()
        {
            Modelo.Cliente unCliente = new Modelo.Cliente();

            unCliente.Nombre = txtNombre.Text;
            unCliente.Apellido = txtApellido.Text;
            unCliente.TipoDocumento = (TipoDocumento)cmbTipo.SelectedItem;

            int dni;
            if (!Int32.TryParse(txtDocumento.Text, out dni)) throw new Exception("El DNI solo debe contener caracteres numericos");
            unCliente.DNI = dni;

            unCliente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            unCliente.Mail = txtMail.Text;

            int tel;
            if (!Int32.TryParse(txtTel.Text, out tel)) throw new Exception("El telefono solo debe contener caracteres numericos");
            unCliente.Telefono = tel;

            unCliente.Domicilio = new Domicilio();

            unCliente.Domicilio.Calle = txtCalle.Text;

            int altura;
            if (!Int32.TryParse(txtAltura.Text, out altura)) throw new Exception("La altura solo debe contener caracteres numericos");
            unCliente.Domicilio.Altura = altura;

            int piso;
            if (!Int32.TryParse(txtPiso.Text, out piso)) throw new Exception("El piso solo debe contener caracteres numericos");
            unCliente.Domicilio.Piso = piso;

            unCliente.Domicilio.Departamento = txtDepto.Text;

            unCliente.Domicilio.Localidad = new Localidad();
            unCliente.Domicilio.Localidad = (Localidad)cmbLocalidad.SelectedItem;

            int cp;
            if (!Int32.TryParse(txtCodigoPostal.Text, out cp)) throw new Exception("El código postal solo debe contener caracteres numericos");
            unCliente.Domicilio.CodigoPostal = cp;

            return unCliente;

        }

        private void cargarFormularioParaModoficacion(Modelo.Cliente c)
        {
            Modelo.Cliente unCliente = DAO.UsuarioSQL.getCliente(c.Id);

            //ActiveForm.Text = "Modificar Usuario";
            btnOK.Text = "Modificar";

            txtNombre.Text = unCliente.Nombre;
            txtApellido.Text = unCliente.Apellido;
            cmbTipo.SelectedValue = unCliente.TipoDocumento.Id;
            txtDocumento.Text = unCliente.DNI.ToString();
            dtpFechaNacimiento.Text = unCliente.FechaNacimiento.ToShortDateString();
            txtMail.Text = unCliente.Mail;
            txtTel.Text = unCliente.Telefono.ToString();
            txtCalle.Text = unCliente.Domicilio.Calle;
            txtAltura.Text = unCliente.Domicilio.Altura.ToString();
            txtPiso.Text = unCliente.Domicilio.Piso.ToString();
            txtDepto.Text = unCliente.Domicilio.Departamento.ToString();
            if (unCliente.Domicilio.Localidad.Id != -1) cmbLocalidad.SelectedValue = unCliente.Domicilio.Localidad.Id;
            txtCodigoPostal.Text = unCliente.Domicilio.CodigoPostal.ToString();

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


    }
}

