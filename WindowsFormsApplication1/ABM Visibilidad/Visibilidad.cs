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
using MercadoEnvio.Utils;
using MaterialSkin;
namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class Visibilidad : MaterialForm
    {
        public Visibilidad()
        {
            InitializeComponent();
            reload();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListadoVisibilidades.MultiSelect = false;
            ListadoVisibilidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void reload()
        {
            DAO.VisibilidadSQL.getVisibilidades(ListadoVisibilidades);
        }

        private Modelo.Visibilidad getSeleccionado()
        {
            return new Modelo.Visibilidad((Convert.ToInt32(Extension.cellValue(this.ListadoVisibilidades, "Id"))),
                Convert.ToInt32(Extension.cellValue(this.ListadoVisibilidades, "Codigo")),
           Convert.ToString(Extension.cellValue(this.ListadoVisibilidades, "Descripcion")),
           Convert.ToDouble(Extension.cellValue(this.ListadoVisibilidades, "Precio")),
           Convert.ToDouble(Extension.cellValue(this.ListadoVisibilidades, "Porcentaje")),
           Convert.ToDouble(Extension.cellValue(this.ListadoVisibilidades, "CostoEnvio"))
           );
        }
        private void modificar_Click(object sender, EventArgs e)
        {
            if (ListadoVisibilidades.Rows.Count > 0)
            {
                Modificacion mod = new Modificacion(getSeleccionado());
                mod.Show();
                this.Close();
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Alta al = new Alta();
            al.Show();
            this.Close();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListadoVisibilidades.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.ListadoVisibilidades.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                int error = DAO.VisibilidadSQL.eliminarVisibilidad(id);
                if (error != -1)
                {
                    MessageBox.Show("Se ha eliminado correctamente", "Exito");
                    this.reload();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar, hay alguna publicacion con esta visibilidad", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una visibilidad primero", "Aviso");
            }
        }
    }
}
