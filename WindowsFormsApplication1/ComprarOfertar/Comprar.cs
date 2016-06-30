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
using MercadoEnvio.Modelo;
using MercadoEnvio.Publicar;

namespace MercadoEnvio.ComprarOfertar
{
    public partial class Comprar : MaterialForm
    {
        Modelo.Publicacion pGlobal;

        public Comprar(Modelo.Publicacion publicacion)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            pGlobal = publicacion;
            cargarDatos();
        }

        private void cargarDatos()
        {
            lblDescripcionProducto.Text = pGlobal.Descripcion;
            lblPrecioUnitario.Text = "ARS $" + pGlobal.Precio.ToString();
            lblPrecioTotal.Text = "ARS $" + pGlobal.Precio.ToString();

            for (int i = 1; i <= pGlobal.Stock; i++) cmbCantidad.Items.Add(i);

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try{
                int valorOferta;
                if (!int.TryParse(cmbCantidad.Text.ToString(), out valorOferta))
                    throw new Exception("Debe seleccionar la cantidad");

                int idFactura = DAO.PublicacionSQL.crearComprar(pGlobal.Id, Persistencia.usuario.Id, int.Parse(cmbCantidad.Text));
                
                VisualizadorFactura vis = new VisualizadorFactura(idFactura);
                vis.Show();
                this.Close();

            }catch (Exception ex){
                MessageBox.Show(ex.Message, "Atención");
            }
            
        }

        private void cmbCantidad_SelectedValueChanged(object sender, EventArgs e)
        {
            lblPrecioTotal.Text = "ARS $" + (pGlobal.Precio * int.Parse(cmbCantidad.Text)).ToString();
        }
    }
}
