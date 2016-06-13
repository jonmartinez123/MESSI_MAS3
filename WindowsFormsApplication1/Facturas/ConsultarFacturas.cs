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
using MercadoEnvio.Utils;

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
            fechaDesde.Format = DateTimePickerFormat.Custom;
            fechaDesde.CustomFormat = "dd-MM-yyyy";
            fechaHasta.Format = DateTimePickerFormat.Custom;
            fechaHasta.CustomFormat = "dd-MM-yyyy";
        }

        private void reload()
        {

        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fechaDesde.Enabled = true;
                fechaHasta.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                fechaDesde.Enabled = false;
                fechaHasta.Enabled = false;
            }
        }

        private void consultar_button_Click(object sender, EventArgs e)
        {
            DateTime datedesde;
            DateTime datehasta;
            String dateDesde;
            String dateHasta;
            if (fechaDesde.Enabled & !importeBajotxt.Enabled & !detallePublitxt.Enabled) {
                dateDesde = Convert.ToString(fechaDesde.Value.Day + "/" + fechaDesde.Value.Month + "/" + fechaDesde.Value.Year);
                dateHasta = Convert.ToString(fechaHasta.Value.Day + "/" + fechaHasta.Value.Month + "/" + fechaHasta.Value.Year);

            }

            if (!fechaDesde.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled) {
                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text))
                {
                    //llamo al sp
                }
            }

            if (!fechaDesde.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled) {
                if (!String.IsNullOrEmpty(detallePublitxt.Text))
                {
                    //llamo al sp
                }
            
            }

            if (fechaDesde.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled) {
                dateDesde = Convert.ToString(fechaDesde.Value.Day + "/" + fechaDesde.Value.Month + "/" + fechaDesde.Value.Year);
                dateHasta = Convert.ToString(fechaHasta.Value.Day + "/" + fechaHasta.Value.Month + "/" + fechaHasta.Value.Year);

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text))
                {
                    //llamo al sp
                }
            }

            if (fechaDesde.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled) {
                dateDesde = Convert.ToString(fechaDesde.Value.Day + "/" + fechaDesde.Value.Month + "/" + fechaDesde.Value.Year);
                dateHasta = Convert.ToString(fechaHasta.Value.Day + "/" + fechaHasta.Value.Month + "/" + fechaHasta.Value.Year);
                if (!String.IsNullOrEmpty(detallePublitxt.Text))
                {
                    //llamo al sp
                }
            }

            if (!fechaDesde.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled) { }

            if (fechaDesde.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled) {
                dateDesde = Convert.ToString(fechaDesde.Value.Day + "/" + fechaDesde.Value.Month + "/" + fechaDesde.Value.Year);
                dateHasta = Convert.ToString(fechaHasta.Value.Day + "/" + fechaHasta.Value.Month + "/" + fechaHasta.Value.Year);

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text) & !String.IsNullOrEmpty(detallePublitxt.Text))
                {
                    //llamo al sp
                }
            }

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

        private void importeBajotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void importeBajotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void importeAltotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
