﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DAO;
using MercadoEnvio.Config;

namespace MercadoEnvio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfiguracionVariable.Iniciar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DAO.PublicacionSQL.cambiarEstadoDeSubastasVencidas(Config.ConfiguracionVariable.FechaSistema);
            Application.Run(new Login.Login());
        }
    }
}
