using MaterialSkin;
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
using MercadoEnvio.Modelo;

namespace MercadoEnvio.Publicar
{
    public partial class Detalles : MaterialForm
    {
        public Publicacion publicacion;
        public Detalles()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void cargarDatos() {
            lblPublicacion.Text = publicacion.Descripcion;
            foreach (Rubro r in publicacion.Rubros)
            {
                listadoRubro.Rows.Add(r.Id, r.DescripcionCorta, r.DescripcionLarga);
            }
        }
        private void Detalles_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
