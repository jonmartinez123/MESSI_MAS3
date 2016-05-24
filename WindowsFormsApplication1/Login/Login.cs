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
using MercadoEnvio.DAO;
using MercadoEnvio.Utils;
using MercadoEnvio.Modelo;
using MaterialSkin;
namespace MercadoEnvio.Login
{
    public partial class Login : MaterialForm
    {
        public int cantidadIntentos { get; set; }

        public Login() {

          InitializeComponent();
          var materialSkinManager = MaterialSkinManager.Instance;
          materialSkinManager.AddFormToManage(this);
          materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        /* private void IniciarSesion_Click(object sender, EventArgs e)
         {
             if (this.validateNotNullForAll(Controls))
             {
                 if (!DAO.DAOLogin.existeUsuario(Usuario.value))
                 {
                     MessageBox.Show("El usuario no es válido");
                     return;
                 }

                 Model.Usuario user = new Model.Usuario(Usuario.value, pass.value);
                 user.Intentos = DAO.DAOLogin.getIntentos(user);
                 user.Estado = user.Intentos >= 3 ? false : true;
                 user.Rol = DAO.DAOLogin.obtenerRolUsuario(user);
                 user.IDRol = DAO.DAOLogin.obtenerIDRolUsuario(user);

                 if (!user.Estado)
                 {
                     MessageBox.Show("El usuario está inhabilitado!");
                     Extensions.cleanAll(this.Controls);
                     return;
                 }

                 if (user.IDRol != 0) {
                     MessageBox.Show("El usuario no es administrativo, por lo tanto no puede loguearse");
                     return;
                 }


                 if (DAO.DAOLogin.validarUsername(user.Username, user.Password) == 1)
                 {
                     user.Intentos = DAO.DAOLogin.vaciarIntentos(user);
                     List<Decimal> funcionalidades = DAO.DAORol.getIdFuncionalidades(user.IDRol);
                     this.openInNewWindow(new MainMenu(funcionalidades, user.IDRol));
                     this.Close();
                     return;
                 }

                 user.Intentos = DAO.DAOLogin.aumentarIntentos(user);
                 if (user.Intentos == 3) { MessageBox.Show("Usuario inhabilitado!"); return; }
                 MessageBox.Show("Usuario o password incorrecto. Vuelva a intentar. Intentos restantes: " + (3 - user.Intentos));



             }
         }


         private void Cerrar_Click(object sender, EventArgs e)
         {
             this.Close();
         }
        */

         private void iniciarSesion_Click(object sender, EventArgs e)
         {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
             if ( !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(usuario)) 
             {
                 Usuario user = new Usuario(usuario, pass);
                 int respuesta = DAO.Login.validarUsuario(user);
                 if ( respuesta == 1)
                 {
                     MessageBox.Show("EXISTE");
                     int cantidadIntentos = DAO.Login.traerIntentos(user);
                     if (cantidadIntentos <= 3)
                     {

                     }
                     else {
                        MessageBox.Show("Contactar al ADMIN por superacion de" + cantidadIntentos + "intentos");
                     }
                     
                     user.Intentos = DAO.Login.vaciarIntentos(user);
                    // List<Decimal> funcionalidades = DAO.DAORol.getIdFuncionalidades(user.IDRol);
                     //this.openInNewWindow(new MainMenu(funcionalidades, user.IDRol));
                     this.Close();
                     return;
                 }
                 /*
                 user.Intentos = DAO.Login.getIntentos(user);
                 user.Estado = user.Intentos >= 3 ? false : true;
                 user.Rol = DAO.Login.obtenerRolUsuario(user);
                 user.IDRol = DAO.Login.obtenerIDRolUsuario(user);




                 if (!user.Estado)
                 {
                     MessageBox.Show("El usuario está inhabilitado!");
                     return;
                 }

                 user.Intentos = DAO.Login.aumentarIntentos(user);
                 if (user.Intentos == 3) { MessageBox.Show("Usuario inhabilitado!"); return; }*/
             }
             MessageBox.Show("El usuario o la contraseña no son correctas");

         }
         private void Login_Load(object sender, System.EventArgs e)
         {
         }

         private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
         {
             this.allowAlphanumericOnly(e);
         }

         private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
         {
             this.allowAlphanumericOnly(e);
             this.allowMaxLenght(txtPass,16, e);
         }

    }
}




