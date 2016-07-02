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
using MercadoEnvio.DAO;

namespace MercadoEnvio.Publicar
{
    public partial class Publicar : MaterialForm
    {
        public Publicacion pub;
        private int indice = 0;
        public Publicar()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            listadoRubro.MultiSelect = false;
            listadoRubro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListadoVisibilidades.MultiSelect = false;
            ListadoVisibilidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cargarTipoPublicacion();
        }

        private void traerPublicacion()
        {
            txtDescripcion.Text = pub.Descripcion;
            txtPrecio.Text = Convert.ToString(pub.Precio);
            txtStock.Text =  Convert.ToString(pub.Stock);
            dtInicio.Value= pub.FechaInicio;
            dtFin.Value=pub.FechaFin;
            foreach(Rubro r in pub.Rubros){
                listadoRubro.Rows.Add(r.Id, r.DescripcionCorta, r.DescripcionLarga);
            }
            Visibilidad v = pub.Visibilidad;
            foreach (DataGridViewRow row in ListadoVisibilidades.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value)==v.Id)
                {
                    indice =row.Index;
                    break;
                }
            }
            if (pub.QuisoEnvio == 1) { cbEnvio.Checked = true; } else { cbEnvio.Checked = false; }
            if(pub.tipoPublicacion.nombre=="Subasta"){
                 txtSubastaMinima.Text=pub.MinimoSubasta.ToString();
                 rbSubasta.Checked = true;
            }else{
                rbOferta.Checked = true;
            }
        }
        private void aplicarDefault()
        {
            DateTime minFin = ConfiguracionVariable.FechaSistema.AddDays(1);
            dtFin.MinDate=minFin;
            dtFin.Value = minFin;
            DateTime minInicio = ConfiguracionVariable.FechaSistema;
            dtInicio.MinDate = minInicio;
            dtInicio.Value = minInicio;
            rbOferta.Select();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Listado l = new Listado();
            l.Show();
            l.Activate();
            l.Focus();
            l.BringToFront();
            //Application.OpenForms["MenuUsuario"].SendToBack();
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void rbSubasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSubasta.Checked)
            {
                gbSubasta.Visible = true;
                habilitarEnvio("Subasta");
                gbPrecio.Visible = false;
            }
        }

        private void habilitarEnvio(string nombre)
        {
                foreach (TipoPublicacion tipo in tipoPublicacion)
                {
                    if (tipo.nombre == nombre)
                    {
                        if (tipo.tieneEnvio == 1)
                        {
                            cbEnvio.Visible = true;
                        }
                        else { cbEnvio.Visible = false; }
                    }
                }
         }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado la publicacion con exito, ahora esta visible a todos","Exito");
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
            DataTable idRubros = new DataTable("Rubros");
            idRubros.Columns.Add("idRubro", typeof(Int32));
            foreach (DataGridViewRow row in listadoRubro.Rows)
            {
                idRubros.Rows.Add(Convert.ToInt32(row.Cells[0].Value));
            }
            int seCobraEnvio;
            if(cbEnvio.Checked==true){
                seCobraEnvio = 1;
            }else{
                seCobraEnvio = 0;
            }
            //INSERTO
            if (pub == null)
            {
                //SUBASTA
                if (idTipoPublicacion == 1)
                {
                    SqlConnector.executeProcedure("insertarPublicacion", 1, idVisibilidad, Persistencia.usuario.Id, idTipoPublicacion, txtDescripcion.Text, dtInicio.Value, dtFin.Value, Convert.ToDouble(txtSubastaMinima.Text), null, Convert.ToInt32(txtStock.Text), seCobraEnvio,idRubros);
                }
                //OFERTA
                else if (idTipoPublicacion == 2) {
                    SqlConnector.executeProcedure("insertarPublicacion", 1, idVisibilidad, Persistencia.usuario.Id, idTipoPublicacion, txtDescripcion.Text, dtInicio.Value, dtFin.Value, null, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), seCobraEnvio,idRubros);
                }
                MessageBox.Show("Se ha guardado la publicacion con exito", "Exito");
            }
            else {
                //SUBASTA
                if (idTipoPublicacion == 1)
                {
                    SqlConnector.executeProcedure("updatearPublicacion", pub.Id, 1, idVisibilidad, Persistencia.usuario.Id, idTipoPublicacion, txtDescripcion.Text, dtInicio.Value, dtFin.Value, Convert.ToDouble(txtSubastaMinima.Text), null, Convert.ToInt32(txtStock.Text), seCobraEnvio, idRubros);
                }
                //OFERTA
                else if (idTipoPublicacion == 2) {
                    SqlConnector.executeProcedure("updatearPublicacion", pub.Id, 1, idVisibilidad, Persistencia.usuario.Id, idTipoPublicacion, txtDescripcion.Text, dtInicio.Value, dtFin.Value, null, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), seCobraEnvio, idRubros);
                }
                MessageBox.Show("Se ha modificado la publicacion con exito", "Exito");
            }
            Listado p = new Listado();
            p.Show();
            this.Close();
        }
        private bool sePuedeConvertirADouble(string convertir) {
            try {
                Convert.ToDouble(convertir);
            }catch { return false; }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int valido = 1;
            string texto = "Complete:  \n";
            
            if (listadoRubro.Rows.Count <= 0) {
                texto += "Seleccione algun rubro \n";
                valido = 0;
            }
            if(string.IsNullOrWhiteSpace(txtDescripcion.Text) ){
                texto += "Escriba alguna descripcion \n";
                valido = 0;
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                texto += "Escriba el stock \n";
                valido = 0;
            }
            if(!Extension.anySelected(ListadoVisibilidades)){
                texto += "Seleccione alguna visibilidad \n";
                valido = 0;
            }

            if (gbSubasta.Visible == true)
            {
                if (rbSubasta.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtSubastaMinima.Text))
                    {
                        texto += "Complete la subasta minima \n";
                        valido = 0;
                    }
                    if (!string.IsNullOrWhiteSpace(txtSubastaMinima.Text) && !sePuedeConvertirADouble(txtSubastaMinima.Text)) {
                        texto += "Use una sola coma en la subasta minima \n";
                        valido = 0;
                    }
                }
            }
            if (gbPrecio.Visible == true) {
                if (rbOferta.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                    {
                        texto += "Complete el precio \n";
                        valido = 0;
                    }
                    if (!string.IsNullOrWhiteSpace(txtPrecio.Text) && !sePuedeConvertirADouble(txtPrecio.Text))
                    {
                        texto += "Use una sola coma en el precio \n";
                        valido = 0;
                    }
                }
            }
            if (valido == 1)
            {
                guardar();
            }
            else { MessageBox.Show(texto, "Validacion"); }
        }
        #region validaciones
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnlyParaDouble(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }

        private void txtSubastaMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnlyParaDouble(e);
            this.allowMaxLenght(txtPrecio, 10, e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowMaxLenght(txtDescripcion, 255, e);
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFin.MinDate = dtInicio.Value.AddDays(1);
            dtFin.Value = dtInicio.Value.AddDays(1);
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
            this.allowMaxLenght(txtPrecio, 18, e);
        }
        #endregion
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
        List<TipoPublicacion> tipoPublicacion = new List<TipoPublicacion>();
        private void cargarTipoPublicacion() {
            tipoPublicacion = DAO.PublicacionSQL.getTipoPublicacion();
        }

        public void seleccionarGrilla()
        {
            ListadoVisibilidades.FirstDisplayedScrollingRowIndex = indice;
            ListadoVisibilidades.Rows[indice].Selected = true;
        }

        private void Publicar_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            reload();
            if (pub == null)
            {
                aplicarDefault();
            }
            else
            {
                traerPublicacion();
                seleccionarGrilla();
            }
        }

        private void rbOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOferta.Checked)
            {
                gbSubasta.Visible = false;
                habilitarEnvio("Oferta");
                gbPrecio.Visible = true;
            }
        }
    }
}
