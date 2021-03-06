﻿using System;
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
using MercadoEnvio.Funcionalidades;

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
            this.BringToFront();
            cmbTipoDocumento.DataSource = DAO.TipoDocumentoSQL.getTipoDocumentos();
            cmbTipoDocumento.DisplayMember = "Descripcion";
            cmbTipoDocumento.ValueMember = "Id";
            
            filtrarClientes();
            filtrarEmpresas();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario cUsuario = new CrearUsuario();
            cUsuario.ShowDialog();
            filtrarClientes();
            filtrarEmpresas();
        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            filtrarClientes();
        }

        private void filtrarClientes()
        {
            int dni;
            if (!Int32.TryParse(txtDni.Text, out dni) && txtDni.Text != ""){
                MessageBox.Show("El DNI debe contener caracteres numericos", "Atención");
            }
            else {
                DAO.UsuarioSQL.getClientesFiltadros(dgvClientes, txtNombre.Text, txtApellido.Text, txtMailCliente.Text, txtDni.Text, (Modelo.TipoDocumento)cmbTipoDocumento.SelectedItem);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                btnHabilitadoCliente.Enabled = true; 
                btnCambiarPassCliente.Enabled = true;
                btnModificarCliente.Enabled = true;

                DataGridViewRow row = this.dgvClientes.SelectedRows[0];
                int hab = Convert.ToInt16(row.Cells["colHabilitado"].Value);
                if (hab == 1)
                {
                    btnHabilitadoCliente.Text = "Dar de Alta";
                }
                else
                {
                    btnHabilitadoCliente.Text = "Dar de Baja";
                }
            }
            else{
                btnHabilitadoCliente.Enabled = false;
                btnCambiarPassCliente.Enabled = false;
                btnModificarCliente.Enabled = false;
            }
        }

        private void btnHabilitadoCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1){
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];
                int hab = Convert.ToInt32(row.Cells["colHabilitado"].Value);
                int id = Convert.ToInt32(row.Cells["colId"].Value);
                if (hab == 0){
                    DAO.UsuarioSQL.darDeBajaUsuario(id);
                }
                else{
                    DAO.UsuarioSQL.darDeAltaUsuario(id);
                }
            }
            filtrarClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1){
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];

                Modelo.Cliente unCliente = new Modelo.Cliente();
                unCliente.Id = Convert.ToInt16(row.Cells["colId"].Value);

                CrearCliente cCliente = new CrearCliente(unCliente);
                cCliente.ShowDialog(); 
                filtrarClientes();
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

        private void btnLogicoEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dgvEmpresas.SelectedRows[0];
                int hab = Convert.ToInt16(row.Cells["colHabilitadoEmpresa"].Value);
                int id = Convert.ToInt16(row.Cells["colIdEmpresa"].Value);
                if (hab == 1)
                {
                    DAO.UsuarioSQL.darDeBajaUsuario(id);
                }
                else
                {
                    DAO.UsuarioSQL.darDeAltaUsuario(id);
                }
            }
            filtrarEmpresas();
        }

        private void filtrarEmpresas()
        {
            DAO.UsuarioSQL.getEmpresasFiltradas(dgvEmpresas, txtRazonSocial.Text, txtCUIT.Text, txtMailEmpresa.Text);
        }

        private void btnFiltrarEmpresas_Click(object sender, EventArgs e)
        {
            filtrarEmpresas();
        }

        private void dgvEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count == 1)
            {
                btnLogicoEmpresa.Enabled = true;
                btnCambiarPassEmpresa.Enabled = true;
                btnModificarEmpresa.Enabled = true;

                DataGridViewRow row = this.dgvEmpresas.SelectedRows[0];
                int hab = Convert.ToInt32(row.Cells["colHabilitadoEmpresa"].Value);
                if (hab == 1)
                {
                    btnLogicoEmpresa.Text = "Dar de Alta";
                }
                else
                {
                    btnLogicoEmpresa.Text = "Dar de Baja";
                }
            }
            else
            {
                btnLogicoEmpresa.Enabled = false;
                btnCambiarPassEmpresa.Enabled = false;
                btnModificarEmpresa.Enabled = false;
            }
        }

        private void btnCambiarPassEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dgvEmpresas.SelectedRows[0];

                Modelo.Usuario unUsuario = new Modelo.Usuario();
                unUsuario.Id = Convert.ToInt32(row.Cells["colIdEmpresa"].Value);
                unUsuario.NombreUsuario = row.Cells["colUsuarioEmpresa"].Value.ToString();

                CrearUsuario cCliente = new CrearUsuario(unUsuario);
                cCliente.ShowDialog();
            }
        }

        private void btnModificarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dgvEmpresas.SelectedRows[0];

                Modelo.Empresa unaEmpresa = new Modelo.Empresa();
                unaEmpresa.Id = Convert.ToInt32(row.Cells["colIdEmpresa"].Value);

                CrearEmpresa cCliente = new CrearEmpresa(unaEmpresa);
                cCliente.ShowDialog();
                filtrarEmpresas();
            }
        }

        private void btnLimpiarEmpresa_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text = "";
            txtMailEmpresa.Text = "";
            txtCUIT.Text = "";
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtMailCliente.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetearIntentosEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count == 1) {
                DataGridViewRow row = this.dgvEmpresas.SelectedRows[0];
                DAO.UsuarioSQL.resetearIntentos(Convert.ToInt32(row.Cells["colIdEmpresa"].Value));
                filtrarEmpresas();
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dgvClientes.SelectedRows[0];
                DAO.UsuarioSQL.resetearIntentos(Convert.ToInt32(row.Cells["colId"].Value));
                filtrarClientes();
            }
        }
    }
}
