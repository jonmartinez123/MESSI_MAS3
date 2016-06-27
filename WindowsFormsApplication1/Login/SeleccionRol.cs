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

namespace MercadoEnvio.Login
{
    public partial class SeleccionRol : MaterialForm
    {
        private List<Rol> roles;
        public SeleccionRol(List<Rol> rs)
        {
            InitializeComponent();
            roles = rs;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar algun rol para ingresar");
            }
            else {
                Rol rolSeleccionado = (Rol)cmbRol.SelectedItem;
                List<Funcionalidad> funcionalidades = RolSQl.getFuncionalidades(rolSeleccionado);
                if (funcionalidades.Count() > 0)
                {
                    Persistencia.usuario.Rol = rolSeleccionado;
                    Persistencia.usuario.Rol.getFuncionalidades = funcionalidades;
                    
                    Funcionalidades.MenuUsuario menuUsuario = new Funcionalidades.MenuUsuario();
                    menuUsuario.ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("El rol " + rolSeleccionado + " no tiene funcionalidades, elija otro");
                }
            }
        }
    }
}
