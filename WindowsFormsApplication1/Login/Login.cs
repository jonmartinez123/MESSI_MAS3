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
            string username = txtUsuario.Text;
            string pass = txtPass.Text;
            if (!string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(username))
            {
                if (DAO.Login.existeUsuario(username))
                {
                    int cantidadIntentos = DAO.Login.traerIntentos(username);
                    if (cantidadIntentos <= 3)
                    {
                        if (DAO.Login.validarUsuario(username, pass) == 1)
                        {
                            Persistencia.usuario = new Usuario(username, pass);
                            DAO.Login.vaciarIntentos(Persistencia.usuario);
                            // List<Decimal> funcionalidades = DAO.DAORol.getIdFuncionalidades(user.IDRol);
                            this.Hide();
                            ABM_Rol.Rol rol = new ABM_Rol.Rol();
                            rol.ShowDialog();
                            return;
                        }
                        else
                        {
                            DAO.Login.aumentarIntentos(username);
                            MessageBox.Show("Usuario o contraseñia incorrecta, se aumento la cantidad de intentos para " + username);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Contactar al ADMIN por superacion de " + cantidadIntentos + " intentos");
                    }

                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }else {
                MessageBox.Show("Los campos usuario y contraseña deben estar completos");
            }
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




