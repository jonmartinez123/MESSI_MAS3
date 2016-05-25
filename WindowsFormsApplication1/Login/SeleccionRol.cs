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
using MercadoEnvio.DAO;
using MercadoEnvio.Utils;
using MercadoEnvio.Modelo;
using MaterialSkin;

namespace MercadoEnvio.Login
{
    public partial class SeleccionRol : MaterialForm
    {
        public SeleccionRol()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Persistencia.usuario.Roles;
        }
    }
}
