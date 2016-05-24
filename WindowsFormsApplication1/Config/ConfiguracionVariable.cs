using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MercadoEnvio.Config
{
    class ConfiguracionVariable
    {
        public static string ConnectionString { get; set; }
        public static DateTime FechaSistema { get; set; }
        private static bool _iniciado;
        public static void Iniciar()
        {
            try
            {
                if (!_iniciado)
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["DBStringDeConexion"].ConnectionString;
                    FechaSistema = DateTime.ParseExact(ConfigurationManager.AppSettings["FechaSistema"], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    _iniciado = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("No se pudo leer el archivo de configuracion");
            }

        }
    }
}