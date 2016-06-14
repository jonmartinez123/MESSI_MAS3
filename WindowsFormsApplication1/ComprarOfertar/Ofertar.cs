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
using MercadoEnvio.Utils;

namespace MercadoEnvio.ComprarOfertar
{
    public partial class Ofertar : MaterialForm
    {
        Modelo.Publicacion publicacionGlobal;
        Modelo.Oferta ultimaOferta;

        public Ofertar(Modelo.Publicacion p){
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            ultimaOferta = DAO.PublicacionSQL.getUltimoValorOferta(p.Id);
            lblValorActual.Text = "ARS $ " + ultimaOferta.Valor.ToString();
            publicacionGlobal = p;
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            try{
                if (string.IsNullOrEmpty(txtValorOfertado.Text))
                    throw new Exception("Debe completar el nombre");

                int valorOferta;
                if(!int.TryParse(txtValorOfertado.Text.ToString(), out valorOferta))
                    throw new Exception("El valor ingresado debe ser numerico");

                if(ultimaOferta.Valor >= valorOferta){
                    throw new Exception("El valor ofertado debe ser mayor al valor minimo");
                }else{
                    Modelo.Oferta oferta = new Modelo.Oferta(double.Parse(txtValorOfertado.Text.ToString()), Utils.Persistencia.usuario.Id, publicacionGlobal.Id);
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

        private void txtValorOfertado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) this.allowMaxLenght(txtValorOfertado, 17, e);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtValorOfertado_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lblValorActual_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

    }
}
