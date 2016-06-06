using System;
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
using MercadoEnvio.Utils;

namespace MercadoEnvio.ABM_Rol
{
    public partial class AltaRol : MaterialForm
    {
        public AltaRol()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            this.agregarFuncionalidades(DAO.RolSQl.getAllFuncionalidades());
            
        }


    //Comienzo metodos
        public ABM_Rol.Listado launcher { get; set; }
    

        public AltaRol(ABM_Rol.Listado launcher)
        {
            InitializeComponent();
            this.launcher = launcher;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            launcher.reload();
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
           
            if (!(String.IsNullOrEmpty(Nombre.Text)))
            { Modelo.Rol rol = new Modelo.Rol(this.Nombre.Text, this.Estado.Checked); //linea peligrosa
                if (this.FuncionalidadesRol.Rows.Count == 0) { MessageBox.Show("El rol debe tener al menos una funcionalidad"); return; }
                DAO.RolSQl.crearNuevoRol(rol, FuncionalidadesRol);
                MessageBox.Show("Rol creado con éxito!");
                launcher.reload();
                this.Close();
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (Funcionalidad.SelectedIndex != -1)
            {
                String func = Funcionalidad.SelectedItem.ToString();
                if (DAO.RolSQl.yaExisteRol(this.Nombre.Text) == 1) { MessageBox.Show("Ya existe un rol con ese nombre"); return; }
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

        private void quitar_Click(object sender, EventArgs e)
        {
            if (Extension.anySelected(FuncionalidadesRol,"una funcionalidad")) //probar esto
            {
                this.FuncionalidadesRol.Rows.RemoveAt(this.FuncionalidadesRol.CurrentRow.Index);
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }


        private void agregarFuncionalidades<T>(List<T> list) {
            foreach (T elem in list)
            {
                this.Funcionalidad.Items.Add(elem);
            }
        }

}
}

        
