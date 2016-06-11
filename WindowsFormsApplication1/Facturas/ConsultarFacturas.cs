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

namespace MercadoEnvio.Facturas
{
    public partial class  ConsultarFacturas : MaterialForm
    {
        public ConsultarFacturas()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void ConsultarFacturas_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void reload()
        {

        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fechaDesdetxt.Enabled = true;
                fechaHastatxt.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                fechaDesdetxt.Enabled = false;
                fechaHastatxt.Enabled = false;
            }
        }

        private void consultar_button_Click(object sender, EventArgs e)
        {

            if (fechaDesdetxt.Enabled & !importeBajotxt.Enabled & !detallePublitxt.Enabled) { }

            if (!fechaDesdetxt.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled) { }

            if (!fechaDesdetxt.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled) { }

            if (fechaDesdetxt.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled) { }

            if (fechaDesdetxt.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled) { }

            if (!fechaDesdetxt.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled) { }

            if (fechaDesdetxt.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled) { }

            //tendria que tirar un if por cada una de las combinaciones posibles, y segun eso hacer lo sp con cada combinacion, 3!
            //son 6 combinaciones. Si esta la fecha,importe o detalle, luego fecha-importe, fecha-detalle o detalle-importe
            //DataTable dt = DAO.ConsultarFacturasSQL.get(superGrid1);
            //superGrid1.SetPagedDataSource(dt, bindingNavigator1);
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                importeAltotxt.Enabled = true;
                importeBajotxt.Enabled = true;
            }
            if (!checkBox2.Checked)
            {
                importeAltotxt.Enabled = false;
                importeBajotxt.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                detallePublitxt.Enabled = true;
            }
            if (!checkBox3.Checked)
            {
                detallePublitxt.Enabled = false;
            }
        }
    }
}
