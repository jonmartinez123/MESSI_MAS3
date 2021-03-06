﻿using MaterialSkin.Controls;
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
using MercadoEnvio.Modelo;
using MaterialSkin;

namespace MercadoEnvio.Login
{
    public partial class Login: MaterialForm
    {
        private List<Rol> roles;
        public Login() {
          InitializeComponent();
          var materialSkinManager = MaterialSkinManager.Instance;
          materialSkinManager.AddFormToManage(this);
          materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void loguear(string username,string pass){
           if (DAO.LoginSQL.existeUsuario(username))
                {
                    int idUsuario = DAO.LoginSQL.getID(username);
                    int cantidadIntentos = DAO.LoginSQL.traerIntentos(idUsuario);
                    if (cantidadIntentos < 3)
                    {
                        if (DAO.LoginSQL.validarUsuario(username, pass) == 1)
                        {
                            Persistencia.usuario = new Usuario(idUsuario,username, pass);
                            this.cargarDatosUsuarioLogueado();
                            if(roles.Count() != 0 ){
                                if (roles.Count > 1)
                                {
                                    this.Hide();
                                    SeleccionRol sr = new SeleccionRol(roles);
                                    sr.ShowDialog();
                                    Close();
                                }else{
                                    Rol rolSeleccionado = roles.First();
                                    MessageBox.Show("Usted esta entrando como el rol de " + rolSeleccionado.Nombre, "Ingreso");
                                    Persistencia.usuario.Rol = rolSeleccionado;
                                    List<Funcionalidad> funcionalidades = RolSQl.getFuncionalidades(rolSeleccionado);
                                    if (funcionalidades.Count() > 0)
                                    {
                                        this.Hide();
                                        Persistencia.usuario.Rol.getFuncionalidades = funcionalidades;
                                        Funcionalidades.MenuUsuario menuUsuario = new Funcionalidades.MenuUsuario();
                                        menuUsuario.ShowDialog();
                                    }else{
                                        MessageBox.Show("No se encontraron funcionalidades para el rol " + rolSeleccionado.Nombre, "Atención");
                                    }
                                }
                             }else{
                                    MessageBox.Show("No se encontraron roles activos para " + username, "Atención");
                            }
                        }else{
                            DAO.LoginSQL.aumentarIntentos(idUsuario);
                            MessageBox.Show("Usuario o contraseñia incorrecta, se aumento la cantidad de intentos para " + username,"Atención");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contactar al ADMIN por superacion de 3 intentos","Atención");
                    }

                }
                else
                {
                    MessageBox.Show("El usuario no existe","Validacion");
                }
        }
         private void iniciarSesion_Click(object sender, EventArgs e)
         {
            string username = txtUsuario.Text;
            string pass = txtPass.Text;
            if (!string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(username))
            {
                if (username.Contains('-'))
                {
                    if (Validaciones.tieneDosGuiones(username))
                    {
                        if (username.Length == 14)
                        {
                            loguear(username, pass);
                        }
                        else {
                            MessageBox.Show("El cuit debe tener 12 digitos", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El cuit debe contener dos guiones", "Error");
                    }
                }
                else {
                    loguear(username, pass);
                } 
            }else {
                MessageBox.Show("Los campos usuario y contraseña deben estar completos","Validacion");
            }
         }
         private void cargarDatosUsuarioLogueado()
         {
             int id =  DAO.LoginSQL.getID(Persistencia.usuario.NombreUsuario);
             Persistencia.usuario.Id = id;
             //Persistencia.usuario.Mail = DAO.LoginSQL.getMail(id);
             //Persistencia.usuario.Telefono = DAO.LoginSQL.getTelefono(id);
             DAO.LoginSQL.vaciarIntentos(id);
             roles = DAO.LoginSQL.getRoles(id);
         }
         private void Login_Load(object sender, System.EventArgs e)
         {
         }

         private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
         {
             this.allowAlphanumericOnlyYGuion(e);
         }

         private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
         {
             this.allowAlphanumericOnly(e);
             if (e.KeyChar != 8) this.allowMaxLenght(txtPass, 15, e);
         }

    }
}




