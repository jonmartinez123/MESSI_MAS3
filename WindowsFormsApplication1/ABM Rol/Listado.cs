using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MercadoEnvio.Utils;

namespace MercadoEnvio.ABM_Rol
{
    public partial class Listado : MaterialForm
    {

        //Metodos para customizar el formulario
        public Listado()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Rol_Load(object sender, EventArgs e)
        {

        }

       //

        public Listado(Decimal rol)
        {
           
            InitializeComponent();
            this.rol = rol;
        }

        public Decimal rol { get; set; }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Extension.openInNewWindow(this, new AltaRol(this)); //peligrosa linea
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RolListado_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void modificar_Click(object sender, EventArgs e){
            if (ListadoRoles.Rows.Count > 0)
            {
                Extension.openInNewWindow(this,new Modificacion(this, getCurrentRol())); //probar
                
            }
        }
    public Modelo.Rol getCurrentRol(){
        return new Modelo.Rol(Convert.ToDecimal(Extension.cellValue(ListadoRoles, "col_id")),
            Convert.ToString(Extension.cellValue(this.ListadoRoles, "col_rol")),
            Convert.ToBoolean(Extension.cellValue(this.ListadoRoles, "col_habilitado")));
    }

    public void reload() {
        DAO.RolSQl.getAllRoles(ListadoRoles);
    }





  

  


    }
}
