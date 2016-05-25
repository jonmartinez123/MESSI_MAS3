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
    public partial class Login: MaterialForm
    {
        public Login() {

          InitializeComponent();
          var materialSkinManager = MaterialSkinManager.Instance;
          materialSkinManager.AddFormToManage(this);
          materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

         private void iniciarSesion_Click(object sender, EventArgs e)
         {
            string username = txtUsuario.Text;
            string pass = txtPass.Text;
            if (!string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(username))
            {
                if (DAO.LoginSQL.existeUsuario(username))
                {
                    int cantidadIntentos = DAO.LoginSQL.traerIntentos(username);
                    if (cantidadIntentos <= 3)
                    {
                        if (DAO.LoginSQL.validarUsuario(username, pass) == 1)
                        {
                            Persistencia.usuario = new Usuario(username, pass);
                            this.cargarDatosUsuarioLogueado();
                            // List<Decimal> funcionalidades = DAO.DAORol.getIdFuncionalidades(user.IDRol);
                            this.Hide();
                            if (Persistencia.usuario.Roles.Count > 1) {
                                SeleccionRol sr = new SeleccionRol();
                                sr.ShowDialog();
                            }else{
                                //ir a las funcionalidades directo
                            }
                            return;
                        }
                        else
                        {
                            DAO.LoginSQL.aumentarIntentos(username);
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

         private void cargarDatosUsuarioLogueado()
         {
             Persistencia.usuario.Id = DAO.LoginSQL.getID();
             Persistencia.usuario.Mail = DAO.LoginSQL.getMail();
             Persistencia.usuario.Roles = DAO.LoginSQL.getRoles();
             DAO.LoginSQL.vaciarIntentos();
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




