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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
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
            dataGridView1.Columns.Add("column1","Nombre usuario");
            dataGridView1.Columns.Add("column2","Cantidad productos no vendidos");
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
            dataGridView1.Columns.Add("column1", "Nombre usuario");
            dataGridView1.Columns.Add("column2", "Cantidad facturas");
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
            string anio = comboBox1.SelectedItem.ToString();
            DAO.ListadoSQL.getTop5ConMontoMasFacturado(dataGridView1, anio, comboBox2.SelectedIndex);


        }
    }
}
