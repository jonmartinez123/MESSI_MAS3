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

using MaterialSkin;
using MercadoEnvio.DAO;

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
            asignarFuncionalidades();
            int tieneMasDe3Calificaciones;
            tieneMasDe3Calificaciones = DAO.SqlConnector.executeProcedure("tieneMasde3calificacionesPendientesSegun", Persistencia.usuario.Id);
            if (tieneMasDe3Calificaciones == 1) {
                var window = MessageBox.Show(this, "Existen mas de 3 calificaciones pendientes, califique para proseguir", "Calificaciones pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Calificar.Calif cal = new Calificar.Calif();
                cal.ShowDialog();
                this.Close();
                                                
            }
        }
        private void asignarFuncionalidades() { 
            var administracion = false;
            var publicar = false;
            var comprarOfertar = false;
            var historialDeCliente = false;
            var calificarVendedor = false;
            var consultarFacturas = false;
            var listadoEstadistico = false;
            Persistencia.usuario.Rol.getFuncionalidades = RolSQl.getFuncionalidades(Persistencia.usuario.Rol);
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
                        publicacionesToolStripMenuItem.Visible = true;
                        publicar=true;
                    break;
                }
            }

            //borro menu cuenta si no es empresa o admin
           // if (Persistencia.usuario.Tipo == null) menuHome.Items.Remove(cuentaToolStripMenuItem);

            //Si no posee ninguna funcionalidad de administración borro el menu item
            if (!administracion) menuHome.Items.Remove(administracionToolStripMenuItem);
            if (!publicar) menuHome.Items.Remove(publicacionesToolStripMenuItem);
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
            this.Close();
        }

        private void abm_usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Usuario.Usuario usuario = new ABM_Usuario.Usuario();
            usuario.ShowDialog();
            this.Close();
        }

        private void abm_rubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Rubro.Rubro rub = new ABM_Rubro.Rubro();
            rub.ShowDialog();
            this.Close();
        }

        private void abm_visibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABM_Visibilidad.Visibilidad visibilidad = new ABM_Visibilidad.Visibilidad();
            visibilidad.ShowDialog();
        }

        private void publicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void comprarOfertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarOfertar.ComprarOfertar comp = new ComprarOfertar.ComprarOfertar();
            comp.ShowDialog();
            this.Close();
        }

        private void historialDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Cliente.HistorialCliente historial = new Historial_Cliente.HistorialCliente();
            historial.ShowDialog();
            this.Close();
        }

        private void calificarAlVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificar.Calif cal = new Calificar.Calif();
            cal.ShowDialog();
            this.Close();
        }

        private void consultarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas.ConsultarFacturas facturas = new Facturas.ConsultarFacturas();
            facturas.ShowDialog();
            this.Close();
        }

        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.ListadoEstadistico listado = new Listado_Estadistico.ListadoEstadistico();
            listado.ShowDialog();
            this.Close();
        }

        private void cerrarSesiontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Persistencia.usuario = null;
            Login.Login lg = new Login.Login();
            lg.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Publicar.Listado lis = new Publicar.Listado();
            lis.Show();
        }

        private void generarPublicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publicar.Publicar pub = new Publicar.Publicar();
            pub.ShowDialog();
        }

        private void salirtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}