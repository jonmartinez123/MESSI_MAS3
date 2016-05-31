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
    public partial class Modificacion : MaterialForm
    {

        public Modelo.Rol rol { get; set; }
        public ABM_Rol.Listado launcher { get; set; }
        public Boolean checkeadoPorUsuario { get; set; }


        public Modificacion()
        {
            checkeadoPorUsuario = false;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public Modificacion(ABM_Rol.Listado launcher, Modelo.Rol rol)
        {
            checkeadoPorUsuario = false;
            InitializeComponent();
            this.launcher = launcher;
            this.rol = rol;
            DAO.RolSQl.getFuncionalidadesRol(rol, FuncionalidadesRol);
        }




        private void Agregar_Click(object sender, EventArgs e)
        {
            if (FuncionalidadSeleccion.isValid())
            {
                DAO.RolSQl.agregarFuncionalidad(rol, FuncionalidadSeleccion.SelectedItem.ToString());
                this.reload();
                reloadMenu();


            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            launcher.reload();
            this.Close();
        }


        private void Modificacion_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        public void reload()
        {
            this.Nombre.Text = rol.nombre;
            this.Estado.Checked = rol.habilitado;
            this.FuncionalidadSeleccion.Items.Clear();

            this.agregarFuncionalidades(DAO.RolSQl.getFuncionalidadesQueNoTiene(rol));

            DAO.RolSQl.getFuncionalidadesRol(rol, FuncionalidadesRol);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (FuncionalidadesRol.Rows.Count > 0)
            {
                Decimal idFuncionalidad = Convert.ToDecimal(Extension.cellValue(FuncionalidadesRol, "col_id"));
                // si la funcionalidad es la de ABMRol (1) y el id del rol que tiene el usuario es el mismo que modifico
                // no puedo quitarle esta funcionalidad 
                if (idFuncionalidad == 1 && rol.getid == launcher.rol)
                {
                    MessageBox.Show("No puede eliminar la funcionalidad de ABM de rol porque se encuentra en ella, y en su propio rol");
                    return;
                }

                DAO.RolSQl.eliminarFuncionalidad(rol, (String)Extension.cellValue(FuncionalidadesRol, "col_funcionalidades"));
                this.reload();
                reloadMenu();
                return;
            }


        }

        private void reloadMenu()
        {
            
            
            this.reload();
        }
        private void Estado_CheckedChanged(object sender, EventArgs e)
        {
            Decimal idFuncionalidad = Convert.ToDecimal(Extension.cellValue(FuncionalidadesRol, "col_id"));
            if (idFuncionalidad == 1 && rol.getid == launcher.rol && !Estado.Checked && checkeadoPorUsuario)
            { MessageBox.Show("No puede inhabilitarse a sí mismo!"); Estado.Checked = true; return; }
            // digo que la proxima vez que cambie el estado es porque fue el usuario y no la inicializacion
            checkeadoPorUsuario = true;
            rol.habilitado = Estado.Checked;
            DAO.RolSQl.cambiarEstadoRol(rol);
        }

        private void cambiarNombre_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Nombre.Text))
            {
                if (DAO.RolSQl.yaExisteRol(Nombre.Text) == 1)
                {
                    MessageBox.Show("El nombre del rol ya existe, elija otro");
                    return;
                }
                DAO.RolSQl.modificarNombreRol(rol, Nombre.Text);
                rol.nombre = Nombre.Text;
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }

        private void agregarFuncionalidades<T>(List<T> list)
        {
            foreach (T elem in list)
            {
                this.FuncionalidadSeleccion.Items.Add(elem);
            }
        }


    }
}
