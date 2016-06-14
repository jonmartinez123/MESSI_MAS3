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
    public partial class SeleccionRubros : MaterialForm
    {
        List<Rubro> rSeleccionados;
        public SeleccionRubros(List<Rubro> seleccionado)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            rSeleccionados = seleccionado;
            cargarCLB();
            cargarSeleccionados();

        }

        private void cargarSeleccionados()
        {
            for (int i = 0; i < clbRubros.Items.Count; i++){
                if (estaEnSeleccionados((Rubro)clbRubros.Items[i])) clbRubros.SetItemChecked(i, true);
            }
        }

        private void cargarCLB()
        {
            clbRubros.DataSource = DAO.RubroSQL.getRubros();
            clbRubros.DisplayMember = "descripcionCorta";
            clbRubros.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarItemsSeleccionados();
            ComprarOfertar.rubrosFiltrados = rSeleccionados;
            this.Close();
        }

        private void guardarItemsSeleccionados()
        {
            rSeleccionados.Clear();
            foreach (object itemChecked in clbRubros.CheckedItems)
            {
                rSeleccionados.Add((Rubro)itemChecked);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRubros.Items.Count; i++)
                clbRubros.SetItemChecked(i, true);
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbRubros.Items.Count; i++)
                clbRubros.SetItemChecked(i, false);

            rSeleccionados.Clear();
        }

        private bool estaEnSeleccionados(Rubro rubro) {
            foreach (Rubro r in rSeleccionados) {
                if (r.Id == rubro.Id) return true;
            }
            return false;
        }
    }
}
