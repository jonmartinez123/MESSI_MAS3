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
using MercadoEnvio.Modelo;
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
            Domicilio d;
            listadoItems.MultiSelect = false;
            listadoItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DAO.VisualizarFacturaSQL.getFacturaDetalles(listadoItems,idFactura);
            Factura factura = DAO.VisualizarFacturaSQL.getFacturaDetallesCabecera(idFactura);
            lblFecha.Text = factura.Fecha.ToString();
            lblImporteTotal.Text = factura.ImporteTotal.ToString();
            lblFormaDePago.Text = DAO.FormaDePago.getFormasDePago(factura.IdFormaDePago);
            lblNumeroDeFactura.Text = factura.Numero.ToString();
            if (DAO.VisualizarFacturaSQL.esCliente(factura.IdVendedor) == 1)
            {
                Cliente cliente = DAO.UsuarioSQL.getCliente(factura.IdVendedor);
                lblCliente.Text = cliente.Nombre + " " + cliente.Apellido;
                lblIdUsuario.Text = cliente.DNI.ToString();
                d = cliente.Domicilio;

            }
            else
            {
                Empresa empresa = DAO.UsuarioSQL.getEmpresa(factura.IdVendedor);
                lblCliente.Text = empresa.RazonSocial;
                lblIdUsuario.Text = empresa.Cuit.ToString();
                d = empresa.Domicilio;
            }
            lblCalleYAltura.Text = "Calle: " + d.Calle + " " + d.Altura + " Depto: " + d.Departamento + " Piso: " + d.Piso;
            lblCiudad.Text = d.Ciudad;
            lblCodigoPostal.Text = d.CodigoPostal.ToString();
            lblLocalidad.Text = d.Localidad.Nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
