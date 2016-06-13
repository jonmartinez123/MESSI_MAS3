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

namespace MercadoEnvio.ComprarOfertar
{
    public partial class Ofertar : MaterialForm
    {
        Utils.Usuario usuarioGobal;
        Modelo.Publicacion publicacionGlobal;
        Modelo.Oferta ultimaOferta;

        public Ofertar(Modelo.Publicacion p, Utils.Usuario usuario)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            usuarioGobal = usuario;
            ultimaOferta = DAO.PublicacionSQL.getUltimoValorOferta(p.Id);
            lblValorActual.Text = "ARS $ " + ultimaOferta.Id.ToString();
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            try{
                if (string.IsNullOrEmpty(txtValorOfertado.Text))
                    throw new Exception("Debe completar el nombre");

                double valorOferta;
                if(!double.TryParse(txtValorOfertado.Text.ToString(), out valorOferta))
                    throw new Exception("El valor ingresado debe ser numerico");

                if(ultimaOferta.Valor >= valorOferta){
                    throw new Exception("El valor ofertado debe ser mayor al valor minimo");
                }else{
                    Modelo.Oferta oferta = new Modelo.Oferta(double.Parse(txtValorOfertado.Text.ToString()), usuarioGobal.Id, publicacionGlobal.Id);
                    DAO.PublicacionSQL.crearOferta(oferta);
                    MessageBox.Show("La oferta se creo con exito", "Atención");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención");
            }
        }

    }
}
