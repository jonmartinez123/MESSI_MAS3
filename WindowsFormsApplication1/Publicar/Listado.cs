using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Publicar
{
    public partial class Listado : MaterialForm
    {
        public Listado()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            //listadoPublicaciones.Sort(Salida, System.ComponentModel.ListSortDirection.Ascending);
        }
        private void reload() {
            DAO.PublicacionSQL.getPublicaciones(listadoPublicaciones, Persistencia.usuario.Id);
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            reload();
            listadoPublicaciones.MultiSelect = false;
            listadoPublicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

     

        private void listadoPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            Detalles d = new Detalles();
            d.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listadoPublicaciones.Rows.Count > 0)
            {
                //abrir form modificar
                this.Close();
            }
        }

    }
}
