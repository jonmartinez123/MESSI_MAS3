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
using MercadoEnvio.Modelo;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class CrearUsuario : MaterialForm
    {

        private Modelo.Usuario usuarioGlobal;

        public CrearUsuario()
        {
            inicializar();
            txtUsuario.Enabled = true;
            usuarioGlobal = new Modelo.Usuario();
            usuarioGlobal.Id = -1;
        }

        private void inicializar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public CrearUsuario(Modelo.Usuario unUsuario)
        {
            inicializar();
            usuarioGlobal = unUsuario;
            txtUsuario.Text = usuarioGlobal.NombreUsuario;
            txtUsuario.Enabled = false;
            cmbTipo.Enabled = false;
        }

        private void crearUsuario_Load(object sender, System.EventArgs e)
        {
            this.BringToFront();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            try
            {
                #region Validaciones
                var exceptionMessage = string.Empty;

                if (string.IsNullOrEmpty(txtUsuario.Text) && usuarioGlobal.Id == -1 && string.IsNullOrEmpty(txtPass.Text) && string.IsNullOrEmpty(txtPassRepetida.Text))
                    throw new Exception("No puede haber campos vacíos");

                if (string.IsNullOrEmpty(txtUsuario.Text) && usuarioGlobal.Id == -1)
                    throw new Exception("Debe completar el nombre de usuario");

                if (string.IsNullOrEmpty(txtPass.Text))
                    throw new Exception("Debe completar la password");

                if (string.IsNullOrEmpty(txtPassRepetida.Text))
                    throw new Exception("Debe confirmar la password");

                if (txtPassRepetida.Text != txtPass.Text)
                    throw new Exception("Las passwords no coinciden");

                

                #endregion

                if (usuarioGlobal.Id == -1)
                {
                    validarUsername(txtUsuario.Text);

                    if (cmbTipo.Text == "Cliente")
                    {
                        Modelo.Cliente unCliente = new Modelo.Cliente(-1, txtUsuario.Text, txtPass.Text);
                        CrearCliente cCliente = new CrearCliente(unCliente);
                        cCliente.ShowDialog();
                    }
                    else if (cmbTipo.Text == "Empresa")
                    {
                        CrearEmpresa cEmpresa = new CrearEmpresa(new Modelo.Empresa(-1, txtUsuario.Text, txtPass.Text));
                        cEmpresa.ShowDialog();
                    }
                    else {
                        throw new Exception("Debe seleccionar un tipo de usuario");
                    }

                    this.Hide();
                }
                else { 
                    DAO.UsuarioSQL.cambiarPassword(usuarioGlobal.Id, txtPass.Text);
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
            if (DAO.LoginSQL.existeUsuario(username)) throw new Exception("El nombre de usuario no esta disponible");
        }
    }
}
