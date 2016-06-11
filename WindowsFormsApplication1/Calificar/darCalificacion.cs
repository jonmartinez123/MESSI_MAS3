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

namespace MercadoEnvio.Calificar
{
    public partial class darCalificacion : MaterialForm
    {

        Utils.Calificacion calificacionADar { get; set; }
        MercadoEnvio.Calificar.Calif launcher { get; set; }
        
       
        public darCalificacion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
           
        }

        private void darCalificacion_Load(object sender, EventArgs e)
        {

        }


        public darCalificacion(Calif launcher, Utils.Calificacion calificacionActual)
        {
            InitializeComponent();
            this.launcher = launcher;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            calificacionADar = calificacionActual;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            launcher.reload();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //updatear calificacion_button
        {
            if (!(String.IsNullOrEmpty(mensajeCalificacion.Text)))
            {
                
                int cantidadEstrellasDadas;
                cantidadEstrellasDadas= this.getCantidadEstrellas();
                
                
                DAO.CalificacionSQL.actualizarCalificacion(calificacionADar.idCalificacion, this.mensajeCalificacion.Text, cantidadEstrellasDadas);
                
                MessageBox.Show("Calificacion recibida con éxito!");
                launcher.reload();
                this.Close();
            }
        }

        private int getCantidadEstrellas()
        {
            if (cantidad1.Checked) { return 1; }
            if (cantidad2.Checked) { return 2; }
            if (cantidad3.Checked) { return 3; }
            if (cantidad4.Checked) { return 4; }
            if (cantidad5.Checked) { return 5; }

            return 1;
        }
        
    }
}
