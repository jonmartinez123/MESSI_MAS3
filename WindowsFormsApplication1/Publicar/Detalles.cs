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

namespace MercadoEnvio.Publicar
{
    public partial class Detalles : MaterialForm
    {
        Modelo.Publicacion publicacion;
        public Detalles(Modelo.Publicacion publi)
        {
            this.publicacion = publi;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Detalles_Load(object sender, EventArgs e)
        {

        }
    }
}
