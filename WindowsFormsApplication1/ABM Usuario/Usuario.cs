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

namespace MercadoEnvio.ABM_Usuario
{
    public partial class Usuario : MaterialForm
    {
        public Usuario()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario cUsuario = new CrearUsuario();
            cUsuario.ShowDialog();
        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {

            int dni;
            if (!Int32.TryParse(txtDni.Text, out dni)) MessageBox.Show("El DNI debe contener caracteres numericos" , "Atención");

            DAO.UsuarioSQL.getClientesFiltadros(dgvClientes, txtNombre.Text, txtApellido.Text, txtMailCliente.Text, dni);
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1){
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];
                int hab = Convert.ToInt16(row.Cells["colHabilitado"].Value);
                if (hab == 1){
                    btnHabilitadoCliente.Text = "Dar de Baja";
                }
                else{
                    btnHabilitadoCliente.Text = "Dar de Alta";
                }
            }
        }

        private void btnHabilitadoCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1){
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];
                int hab = Convert.ToInt16(row.Cells["colHabilitado"].Value);
                int id = Convert.ToInt16(row.Cells["colId"].Value);
                if (hab == 1){
                    DAO.UsuarioSQL.darDeBajaUsuario(id);
                }
                else{
                    DAO.UsuarioSQL.darDeAltaUsuario(id);
                }
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1){
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];

                Modelo.Cliente unCliente = new Modelo.Cliente();
                unCliente.Id = Convert.ToInt16(row.Cells["colId"].Value);

                CrearCliente cCliente = new CrearCliente(unCliente);
                cCliente.ShowDialog();
            }
        
            
        }

        private void btnCambiarPassCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];

                Modelo.Usuario unUsuario = new Modelo.Usuario();
                unUsuario.Id = Convert.ToInt16(row.Cells["colId"].Value);
                unUsuario.NombreUsuario = row.Cells["colUsuario"].Value.ToString();

                CrearUsuario cCliente = new CrearUsuario(unUsuario);
                cCliente.ShowDialog();
            }
        }

    }
}
