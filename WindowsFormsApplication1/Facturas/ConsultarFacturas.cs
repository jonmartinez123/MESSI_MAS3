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
using MercadoEnvio.Modelo;

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

            String dateDesde;
            String dateHasta;

                DataTable dtNull = new DataTable();

                superGrid1.LimpiarPagedDataSource(dtNull,bindingNavigator1);
                superGrid1.Refresh();
            
           
           
            
            
            if (fechaDesde.Enabled & !importeBajotxt.Enabled & !detallePublitxt.Enabled & !dirigidotxt.Enabled) {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);
               
                DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreFechas(superGrid1, dateDesde, dateHasta);
                if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

            }

            if (!fechaDesde.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled & !dirigidotxt.Enabled)
            {
                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreImporte(superGrid1, Convert.ToInt32(importeBajotxt.Text),  Convert.ToInt32(importeAltotxt.Text));

                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }
                    

                    
                }
            }
            //hasta aca
            if (!fechaDesde.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled & !dirigidotxt.Enabled)
            {
                if (!String.IsNullOrEmpty(detallePublitxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasConPalabraEnDetalle(superGrid1, detallePublitxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }
                   
                }
            
            }

            if (!fechaDesde.Enabled & !importeBajotxt.Enabled & !detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                if (!String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasHacia(superGrid1, dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }

            }

            if (fechaDesde.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled & !dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreFechaEImporte(superGrid1, dateDesde, dateHasta, Convert.ToDouble(importeBajotxt.Text),Convert.ToDouble(importeAltotxt.Text));
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }
            }



            if (fechaDesde.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled & !dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);
                if (!String.IsNullOrEmpty(detallePublitxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreFechasYDetalle(superGrid1, dateDesde, dateHasta, detallePublitxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }
                }
            }

            if (fechaDesde.Enabled & !importeBajotxt.Enabled & !detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);
                if (!String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreFechasYDirigido(superGrid1, dateDesde, dateHasta, dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }
                }
            }

            if (!fechaDesde.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled & !dirigidotxt.Enabled)
            {
                if (!String.IsNullOrEmpty(detallePublitxt.Text) & !String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text)) {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreImporteYDetalle(superGrid1, Convert.ToDouble(importeBajotxt.Text),Convert.ToDouble(importeAltotxt.Text), detallePublitxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }
                
                
                }
             }

            if (!fechaDesde.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                if (!String.IsNullOrEmpty(dirigidotxt.Text) & !String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreImporteYDirigido(superGrid1, Convert.ToDouble(importeBajotxt.Text), Convert.ToDouble(importeAltotxt.Text), dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }


                }
            }

            if (!fechaDesde.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                if (!String.IsNullOrEmpty(detallePublitxt.Text) & !String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasEntreDetalleyDirigido(superGrid1, dirigidotxt.Text , detallePublitxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }


                }
            }



            if (fechaDesde.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled & !dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text) & !String.IsNullOrEmpty(detallePublitxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasConTodoLosFiltro(superGrid1, dateDesde, dateHasta, Convert.ToDouble(importeBajotxt.Text), Convert.ToDouble(importeAltotxt.Text), detallePublitxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }
            }

            if (fechaDesde.Enabled & importeBajotxt.Enabled & !detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text) & !String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasConFechaImporteYDirigido(superGrid1, dateDesde, dateHasta, Convert.ToDouble(importeBajotxt.Text), Convert.ToDouble(importeAltotxt.Text), dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }
            }



            if (fechaDesde.Enabled & !importeBajotxt.Enabled & detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);

                if (!String.IsNullOrEmpty(detallePublitxt.Text) & !String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasConFechaDetalleyDirigido(superGrid1, dateDesde, dateHasta, detallePublitxt.Text, dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }
            }

            if (!fechaDesde.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled & dirigidotxt.Enabled)
            {

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text) & !String.IsNullOrEmpty(detallePublitxt.Text) & !String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasConDetalleImporteYDirigido(superGrid1, Convert.ToDouble(importeBajotxt.Text), Convert.ToDouble(importeAltotxt.Text), detallePublitxt.Text, dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }
            }




            if (fechaDesde.Enabled & importeBajotxt.Enabled & detallePublitxt.Enabled & dirigidotxt.Enabled)
            {
                dateDesde = Convert.ToString(fechaDesde.Value.Year + "-" + fechaDesde.Value.Month + "-" + fechaDesde.Value.Day);
                dateHasta = Convert.ToString(fechaHasta.Value.Year + "-" + fechaHasta.Value.Month + "-" + fechaHasta.Value.Day);

                if (!String.IsNullOrEmpty(importeBajotxt.Text) & !String.IsNullOrEmpty(importeAltotxt.Text) & !String.IsNullOrEmpty(detallePublitxt.Text) & !String.IsNullOrEmpty(dirigidotxt.Text))
                {
                    DataTable dt = DAO.ConsultarFacturasSQL.getFacturasConTodoLosFiltrosMasDirigido(superGrid1, dateDesde, dateHasta, Convert.ToDouble(importeBajotxt.Text), Convert.ToDouble(importeAltotxt.Text), detallePublitxt.Text, dirigidotxt.Text);
                    if (dt.Rows.Count > 0) { superGrid1.SetPagedDataSource(dt, bindingNavigator1); }

                }
            }

           
            
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { dirigidotxt.Enabled = true;}
            if (!checkBox4.Checked) { dirigidotxt.Enabled = false; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
        }
    }
}
