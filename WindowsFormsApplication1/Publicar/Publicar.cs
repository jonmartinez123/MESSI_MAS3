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

namespace MercadoEnvio.Publicar
{
    public partial class Publicar : MaterialForm
    {
        public Publicar()
        {
            InitializeComponent();
            dtFin.MinDate = Config.ConfiguracionVariable.FechaSistema;
            dtInicio.MinDate = Config.ConfiguracionVariable.FechaSistema;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Publicar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void rbCompra_CheckedChanged(object sender, EventArgs e)
        {
            gbSubasta.Visible = false;
        }

        private void rbSubasta_CheckedChanged(object sender, EventArgs e)
        {
            gbSubasta.Visible = true;
        }


    }
}
