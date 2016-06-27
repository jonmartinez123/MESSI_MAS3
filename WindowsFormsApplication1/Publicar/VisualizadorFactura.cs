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
    public partial class VisualizadorFactura :  MaterialForm
    {
        private int idFactura;
        public VisualizadorFactura(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void VisualizadorFactura_Load(object sender, EventArgs e)
        {
           // DAO.VisualizarFacturaSQL.getFactura(idFactura);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
