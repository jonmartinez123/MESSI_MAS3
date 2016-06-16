﻿using System;
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
    public partial class Alta : MaterialForm
    {
        private int codigo;
        private string descripcion;
        private double precio;
        private double costoEnvio;
        private double porcentaje;
        public Alta()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtCodigo.Text = "";
            txtPorcentaje.Text = "";
            txtPrecio.Text = "";
            txtCostoEnvio.Text = "";
        }
        private void txtCostoEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtCostoEnvio, 18, e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtPorcentaje, 18, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
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
        private void actualizarGrilla()
        {
            ListadoVisibilidades.Rows.Clear();
            ListadoVisibilidades.Rows.Add(codigo, descripcion, precio, porcentaje, costoEnvio);
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtCodigo.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtPorcentaje.Text) && !string.IsNullOrWhiteSpace(txtCostoEnvio.Text))
            {
                seteoCampos();
                actualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Visibilidad vis = new Visibilidad();
            vis.ShowDialog();
            this.Close();
        }
        private void seteoCampos()
        {
            descripcion = txtDescripcion.Text;
            codigo = Convert.ToInt32(txtCodigo.Text);
            porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            precio = Convert.ToDouble(txtPrecio.Text); ;
            costoEnvio = Convert.ToDouble(txtCostoEnvio.Text);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtCodigo.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtPorcentaje.Text) && !string.IsNullOrWhiteSpace(txtCostoEnvio.Text))
            {
                seteoCampos();
                actualizarGrilla();
                DAO.VisibilidadSQL.agregarVisibilidad(codigo, descripcion, porcentaje, precio, costoEnvio);
                MessageBox.Show("Se ha agregado correctamente la visibilidad", "Exito");
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            ListadoVisibilidades.MultiSelect = false;
            ListadoVisibilidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}


