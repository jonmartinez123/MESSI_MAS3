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
using MercadoEnvio.Utils;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class CrearUsuario : MaterialForm
    {
        public CrearUsuario()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void crearUsuario_Load(object sender, System.EventArgs e)
        {
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            try
            {
                #region Validaciones
                var exceptionMessage = string.Empty;

                if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtPass.Text) && string.IsNullOrEmpty(txtPassRepetida.Text))
                    throw new Exception("No puede haber campos vacíos");

                if (string.IsNullOrEmpty(txtUsuario.Text))
                    throw new Exception("Debe completar el nombre de usuario");

                if (string.IsNullOrEmpty(txtPass.Text))
                    throw new Exception("Debe completar la password");

                if (string.IsNullOrEmpty(txtPassRepetida.Text))
                    throw new Exception("Debe confirmar la password");

                if (txtPassRepetida.Text != txtPass.Text)
                    throw new Exception("Las passwords no coinciden");

                validarUsername(txtUsuario.Text);

                #endregion

                Modelo.Cliente unCliente = new Modelo.Cliente(-1, txtUsuario.Text, txtPass.Text);

                this.Hide();

                if (cmbTipo.Text == "Cliente")
                {
                    //Extension.openInNewWindow(this, new CrearCliente(unCliente));
                    CrearCliente cCliente = new CrearCliente(unCliente);
                    cCliente.ShowDialog();
                }
                else if (cmbTipo.Text == "Empresa")
                {
                    // CrearEmpresa cCliente = new CrearEmpresa(unUsuario);
                    //cCliente.ShowDialog();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención");
            }
        }

        void validarUsername(string username)
        {
            //Buscar en la base a ver si existe (SP)
        }
    }
}
