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
using MaterialSkin;

namespace MercadoEnvio.Funcionalidades
{
    public partial class MenuUsuario : MaterialForm
    {
        public MenuUsuario()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            
        }
        private void asignarFuncionalidades() { 
            
        }

    }
}