using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Generics;

namespace AerolineaFrba.Abm_Rol
{
    public partial class Alta : Form
    {
        public Abm_Rol.RolListado launcher { get; set; }
        public Alta()
        {
            InitializeComponent();
        }

        public Alta(Abm_Rol.RolListado launcher)
        {
            InitializeComponent();
            this.launcher = launcher;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            launcher.reload();
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
           
            if (Nombre.isValid())
            { Model.Rol rol = new Model.Rol(this.Nombre.value, this.Estado.value);
                if (this.FuncionalidadesRol.Rows.Count == 0) { MessageBox.Show("El rol debe tener al menos una funcionalidad"); return; }
                DAO.DAORol.crearNuevoRol(rol, FuncionalidadesRol);
                MessageBox.Show("Rol creado con éxito!");
               // Nombre.clean(); Estado.clean(); Funcionalidad.Refresh();
                //this.FuncionalidadesRol.Rows.Clear();
                launcher.reload();
                this.Close();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Funcionalidad.isValid())
            {
                String func = Funcionalidad.SelectedItem.ToString();
                if (DAO.DAORol.yaExisteRol(this.Nombre.value) == 1) { MessageBox.Show("Ya existe un rol con ese nombre"); return; }
                foreach (DataGridViewRow row in this.FuncionalidadesRol.Rows)
                {
                    if (row.Cells["col_funcionalidades"].Value.ToString() == func)
                    {
                        MessageBox.Show("Ya agregó esa funcionalidad!");
                        return;
                    }
                }

                FuncionalidadesRol.Rows.Add(func);

                Funcionalidad.ResetText();
            }
        }

        private void FuncionalidadesRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            this.Funcionalidad.AddAll(DAO.DAORol.getAllFuncionalidades());
        }

        private void quitar_Click(object sender, EventArgs e)
        {
            if (FuncionalidadesRol.anySelected("una funcionalidad"))
            {
                this.FuncionalidadesRol.Rows.RemoveAt(this.FuncionalidadesRol.CurrentRow.Index);
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }
    }
}
