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
using MaterialSkin.Controls;

namespace MercadoEnvio.Historial_Cliente
{
    public partial class HistorialCliente : MaterialForm
    {
        public HistorialCliente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void reload()
        {
            
            DataTable dt = DAO.HistorialClienteSQL.getHistorial(superGrid1);
            superGrid1.SetPagedDataSource(dt, bindingNavigator1);
            
            DAO.HistorialClienteSQL.getResumen(resumenGrid);
        }



    }
}
