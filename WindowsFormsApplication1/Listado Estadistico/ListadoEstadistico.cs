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
namespace MercadoEnvio.Listado_Estadistico
{
    public partial class ListadoEstadistico : MaterialForm
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2014");
            comboBox1.Items.Add("2015");
            comboBox1.Items.Add("2016");
            comboBox1.Items.Add("2017");
            comboBox2.Items.Add("Enero - Marzo");
            comboBox2.Items.Add("Abril - Junio");
            comboBox2.Items.Add("Julio - Septiembre");
            comboBox2.Items.Add("Octubre - Diciembre");
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;

            this.agregarVisibilidades(DAO.ListadoSQL.getVisibilidades());
            this.agregarRubros(DAO.RubroSQL.getRubros());
            visibilidades.SelectedIndex = 1;
            rubros.SelectedIndex = 1;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
        }

        private void agregarRubros(List<Modelo.Rubro> list)
        {
            foreach (Modelo.Rubro elem in list)
            {
                this.rubros.Items.Add(elem.DescripcionCorta);
            }
        }

        private void agregarVisibilidades(List<Modelo.Visibilidad> list)
        {
            foreach (Modelo.Visibilidad elem in list)
            {
                this.visibilidades.Items.Add(elem.Descripcion);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            //listado vendedores con mayor cantidad de productos no vendidos
            if (dataGridView1.Columns.Count > 0)
            {
                int cantidadColumnas = dataGridView1.Columns.Count;
                for (int i = 1; i <= cantidadColumnas; i++)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }

            }
            dataGridView1.Columns.Add("column1", "Usuario ID");
            dataGridView1.Columns.Add("column2", "Cantidad productos no vendidos");
            dataGridView1.Columns.Add("column3", "Nombre/Razon social");
            string anio = comboBox1.SelectedItem.ToString();
            string visibilidad = visibilidades.SelectedItem.ToString();
            DAO.ListadoSQL.get_top5vendedoresConMayorCantidadDeProductosNoVendidos(dataGridView1, anio, comboBox2.SelectedIndex, visibilidad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (dataGridView1.Columns.Count > 0)
            {
                int cantidadColumnas = dataGridView1.Columns.Count;
                for (int i = 1; i <= cantidadColumnas; i++)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }

            }
            dataGridView1.Columns.Add("column1", "Cliente ID");
            dataGridView1.Columns.Add("column2", "DNI");
            dataGridView1.Columns.Add("column3", "Nombre");
            dataGridView1.Columns.Add("column4", "Apellido");
            dataGridView1.Columns.Add("column5", "Cantidad Compras");
            string anio = comboBox1.SelectedItem.ToString();
            string rubro = rubros.SelectedItem.ToString();
            DAO.ListadoSQL.get_top5clientesConMasCompraSegunRubro(dataGridView1, anio, comboBox2.SelectedIndex, rubro);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Vendedores con mayor cantidad de facturas
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (dataGridView1.Columns.Count > 0)
            {
                int cantidadColumnas = dataGridView1.Columns.Count;
                for (int i = 1; i <= cantidadColumnas; i++)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }

            }
            dataGridView1.Columns.Add("column1", "Usuario ID");
            dataGridView1.Columns.Add("column2", "Nombre/Razon social");
            dataGridView1.Columns.Add("column3", "Cantidad facturas");
            string anio = comboBox1.SelectedItem.ToString();
            DAO.ListadoSQL.getTop5VendedoresConMasFacturas(dataGridView1, anio, comboBox2.SelectedIndex);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Vendedores con mayor monto facturado
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (dataGridView1.Columns.Count > 0)
            {
                int cantidadColumnas = dataGridView1.Columns.Count;
                for (int i = 1; i <= cantidadColumnas; i++)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }

            }

            dataGridView1.Columns.Add("column1", "Usuario ID");
            dataGridView1.Columns.Add("column1", "Nombre de usuario");
            dataGridView1.Columns.Add("column2", "Nombre/Razon social");
            dataGridView1.Columns.Add("column3", "Monto facturado");
            string anio = comboBox1.SelectedItem.ToString();
            DAO.ListadoSQL.getTop5ConMontoMasFacturado(dataGridView1, anio, comboBox2.SelectedIndex);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
