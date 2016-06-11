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

        private void Listado_Load(object sender, EventArgs e)
        {
            ListadoRoles.MultiSelect = false;
            ListadoRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.reload();
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
            AltaRol alta = new AltaRol(this);
            alta.Show();
            this.Hide();
        }

        private void RolListado_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (ListadoRoles.Rows.Count > 0)
            {
                Modificacion mod = new Modificacion(this, getCurrentRol());
                mod.Show();
                this.Hide();
            }
        }
        public Utils.Rol getCurrentRol()
        {
            return new Utils.Rol(Convert.ToDecimal(Extension.cellValue(ListadoRoles, "col_id")),
                Convert.ToString(Extension.cellValue(this.ListadoRoles, "col_rol")),
                true,
                Convert.ToInt32(Extension.cellValue(this.ListadoRoles, "col_habilitado")));

            //Convert.ToBoolean(Extension.cellValue(this.ListadoRoles, "col_habilitado"))
        }

        public void reload()
        {
            DAO.RolSQl.getAllRoles(ListadoRoles);
        }

        private void ListadoRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
