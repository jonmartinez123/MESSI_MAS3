using MercadoEnvio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MercadoEnvio.DAO
{
    class RolSQl
    {
        internal static List<Funcionalidad> getFuncionalidades(Rol rol)
        {
            SqlCommand cmd = SqlConnector.generarComandoYAbrir("getFuncionalidades", rol.Id);
            var reader = cmd.ExecuteReader();

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            Funcionalidad func;
            while (reader.Read())
            {
                func = new Funcionalidad();
                func.Id = int.Parse(reader["funcionalidad_id"].ToString());
                func.Descripcion = reader["funcionalidad_descripcion"].ToString();
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }
    }
}
