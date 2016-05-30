using MaterialSkin.Controls;
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
using MercadoEnvio.Utils;

using MaterialSkin;

namespace MercadoEnvio.Funcionalidades
{
    public partial class MenuUsuario : MaterialForm
    {
        public MenuUsuario()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            asignarFuncionalidades();
        }
        private void asignarFuncionalidades() { 
            var administracion = false;
            var publicar = false;
            var comprarOfertar = false;
            var historialDeCliente = false;
            var calificarVendedor = false;
            var consultarFacturas = false;
            var listadoEstadistico = false;

            //Obtengo todas las funcionalidades asignadas al rol del usuario logueado
            foreach (Funcionalidad fun in Persistencia.usuario.Rol.getFuncionalidades)
            {
                //Obtengo un objeto 'Funcionalidad' a partir de la descripción del rol (como aparece en la base)
                switch (Funcionalidad.obtenerEnum(fun.Descripcion))
                {
                    case Funcionalidad.Funcionalidades.ABM_Rol:
                        abm_rolToolStripMenuItem.Visible = true;
                        administracion = true;
                    break;

                    case Funcionalidad.Funcionalidades.ABM_Rubro:
                        abm_rubroToolStripMenuItem.Visible = true;
                        administracion = true;
                    break;

                    case Funcionalidad.Funcionalidades.ABM_Usuario:
                        abm_usuarioToolStripMenuItem.Visible = true;
                        administracion = true;
                    break;

                    case Funcionalidad.Funcionalidades.ABM_Visibilidad:
                        abm_visibilidadToolStripMenuItem.Visible = true;
                        administracion = true;
                    break;

                    case Funcionalidad.Funcionalidades.Calificar_Al_Vendedor:
                        calificarAlVendedorToolStripMenuItem.Visible = true;
                        calificarVendedor = true;
                    break;
                    case Funcionalidad.Funcionalidades.ComprarOfertar:
                        comprarOfertarToolStripMenuItem.Visible = true;
                        comprarOfertar = true;
                    break;
                    case Funcionalidad.Funcionalidades.Consultar_Facturas:
                        consultarFacturasToolStripMenuItem.Visible = true;
                        consultarFacturas = true;
                    break;
                    case Funcionalidad.Funcionalidades.Historial_De_Cliente:
                        historialDeClienteToolStripMenuItem.Visible = true;
                        historialDeCliente=true;
                    break;
                    case Funcionalidad.Funcionalidades.Listado_Estadistico:
                        listadoEstadisticoToolStripMenuItem.Visible = true;
                        listadoEstadistico=true;
                    break;
                    case Funcionalidad.Funcionalidades.Publicar:
                        publicarToolStripMenuItem.Visible = true;
                        publicar=true;
                    break;
                }
            }

            //borro menu cuenta si no es empresa o admin
            if (Persistencia.usuario.Tipo == null) menuHome.Items.Remove(cuentaToolStripMenuItem);

            //Si no posee ninguna funcionalidad de administración borro el menu item
            if (!administracion) menuHome.Items.Remove(administracionToolStripMenuItem);
            if (!publicar) menuHome.Items.Remove(publicarToolStripMenuItem);
            if (!historialDeCliente) menuHome.Items.Remove(historialDeClienteToolStripMenuItem);
            if (!consultarFacturas) menuHome.Items.Remove(consultarFacturasToolStripMenuItem);
            if (!comprarOfertar) menuHome.Items.Remove(comprarOfertarToolStripMenuItem);
            if (!calificarVendedor) menuHome.Items.Remove(calificarAlVendedorToolStripMenuItem);
            if (!listadoEstadistico) menuHome.Items.Remove(listadoEstadisticoToolStripMenuItem);
        }

        private void abm_rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Rol.Listado rol = new ABM_Rol.Listado();
            rol.ShowDialog();
        }

        private void abm_usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Usuario.Usuario usuario = new ABM_Usuario.Usuario();
            usuario.ShowDialog();
        }

        private void abm_rubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Rubro.Rubro rub = new ABM_Rubro.Rubro();
            rub.ShowDialog();
        }

        private void abm_visibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.Visibilidad visibilidad = new ABM_Visibilidad.Visibilidad();
            visibilidad.ShowDialog();
        }

        private void publicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicar.Publicar pub = new Publicar.Publicar();
            pub.ShowDialog();
        }

        private void comprarOfertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarOfertar.ComprarOfertar comp = new ComprarOfertar.ComprarOfertar();
            comp.ShowDialog();
        }

        private void historialDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Cliente.HistorialCliente historial = new Historial_Cliente.HistorialCliente();
            historial.ShowDialog();
        }

        private void calificarAlVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificar.Calificar cal = new Calificar.Calificar();
            cal.ShowDialog();
        }

        private void consultarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas.ConsultarFacturas facturas = new Facturas.ConsultarFacturas();
            facturas.ShowDialog();
        }

        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.ListadoEstadistico listado = new Listado_Estadistico.ListadoEstadistico();
            listado.ShowDialog();
        }

        private void cerrarSesiontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persistencia.usuario = null;
            this.Hide();
            Login.Login lg = new Login.Login();
            lg.ShowDialog();
        }
    }
}