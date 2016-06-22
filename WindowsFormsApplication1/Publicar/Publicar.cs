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
using MercadoEnvio.Config;
using MaterialSkin.Controls;
using MaterialSkin;

namespace MercadoEnvio.Publicar
{
    public partial class Publicar : MaterialForm
    {
        public Publicar()
        {
            InitializeComponent();
            aplicarDefault();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void aplicarDefault()
        {
            listadoRubro.MultiSelect = false;
            listadoRubro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListadoVisibilidades.MultiSelect = false;
            ListadoVisibilidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DateTime minFin = ConfiguracionVariable.FechaSistema.AddDays(1);
            dtFin.MinDate=minFin;
            dtFin.Value = minFin;
            DateTime minInicio = ConfiguracionVariable.FechaSistema;
            dtInicio.MinDate = minInicio;
            dtInicio.Value = minInicio;
            rbOferta.Select();
            reload();
        }
        private void Publicar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Funcionalidades.MenuUsuario f = new Funcionalidades.MenuUsuario();
            f.Show();
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void rbCompra_CheckedChanged(object sender, EventArgs e)
        {
            gbSubasta.Visible = false;
        }

        private void rbSubasta_CheckedChanged(object sender, EventArgs e)
        {
            gbSubasta.Visible = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado la publicacion con exito, ahora esta visible a todos","Exito");
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }
        private void cargarCLB()
        {
            cmbRubro.DataSource = DAO.RubroSQL.getRubros();
            cmbRubro.DisplayMember = "descripcionCorta";
            cmbRubro.ValueMember = "Id";
        }
        private void reload()
        {
            DAO.VisibilidadSQL.getVisibilidades(ListadoVisibilidades);
            cargarCLB();
        }
        private void guardar() {
            var checkedButton = gbRadio.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int rowindex = ListadoVisibilidades.CurrentCell.RowIndex;
            int idTipoPublicacion = DAO.TipoPublicacionSQL.getId(checkedButton.Text);
            int idVisibilidad = Convert.ToInt32(ListadoVisibilidades.Rows[rowindex].Cells[0].Value);
            int seCobraEnvio;
            if(cbEnvio.Checked==true){
                seCobraEnvio = 1;
            }else{
                seCobraEnvio = 0;
            }
            double subastaMinima;
            if (string.IsNullOrEmpty(txtSubastaMinima.Text))
            {
                subastaMinima = -1;
            }
            else { subastaMinima = Convert.ToDouble(txtSubastaMinima.Text); } 
            DAO.PublicacionSQL.insertarPublicacion(1, idVisibilidad, Persistencia.usuario.Id, idTipoPublicacion,txtDescripcion.Text,dtInicio.Value,dtFin.Value,subastaMinima,Convert.ToDouble(txtPrecio.Text),Convert.ToInt32(txtStock.Text),seCobraEnvio);
            MessageBox.Show("Se ha guardado la publicacion con exito", "Exito");
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Extension.anySelected(ListadoVisibilidades, "una visibilidad") && listadoRubro.Rows.Count > 0 && !string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtStock.Text)){
                if(rbSubasta.Checked && !string.IsNullOrWhiteSpace(txtSubastaMinima.Text)){
                    guardar();
                }
                guardar();
            }else{
                MessageBox.Show("Por favor complete todos los campos","Error");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
            this.allowMaxLenght(txtDescripcion, 255, e);
        }
        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }
        private void btnAgregarRubro_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedIndex != -1){
                Rubro r = (Rubro)cmbRubro.SelectedItem;
                if (r != null)
                {
                    foreach (DataGridViewRow row in listadoRubro.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == r.Id)
                        {
                            MessageBox.Show("Ya agregó este rubro!");
                            return;
                        }
                    }
                    listadoRubro.Rows.Add(r.Id, r.DescripcionCorta, r.DescripcionLarga);
                }
            }else{
                MessageBox.Show("Debe seleccionar al menos un rubro","Error");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (Extension.anySelected(listadoRubro, "un rubro"))
            {
                listadoRubro.Rows.RemoveAt(listadoRubro.CurrentRow.Index);
            }
        }

        private void ListadoVisibilidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
