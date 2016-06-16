using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
using MercadoEnvio.Config;
using System.Web;
using MercadoEnvio.Modelo;


namespace MercadoEnvio.DAO
{
    public static class SqlConnector
    {

        private static string infoConexion()
        {
            return MercadoEnvio.Config.ConfiguracionVariable.ConnectionString;

        }

        /*Abre la conexion con la base*/
        public static void conexion(SqlConnection conn, SqlCommand command)
        {
            try
            {

                String info = infoConexion();
                conn.ConnectionString = info;
                command.Connection = conn;
                conn.Open();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }


        public static List<String> retrieveList(String procedure, String dt_col, params object[] param)
        {
            List<String> list = new List<String>();
            foreach (DataRow row in SqlConnector.retrieveDT(procedure, param).Rows)
            {
                list.Add(row[dt_col].ToString());
            }
            return list;
        }

        public static DataTable retrieveDTToBeConverted(String sp, params Object[] values)
        {

            SqlDataAdapter da = new SqlDataAdapter(generateCommand(sp, values));


            DataTable dt = new DataTable();
            da.Fill(dt);
            

            return dt;
        }


        // metodo que permite cargar una sola fila en el indice especificado de la grilla, si es que las columnas coinciden con 
        // el property name: hacer coincidir el nombre de property de las columnas interesadas con las columnas de la base. 
        public static void LoadWithRow(String sp, int dataRowIndex, DataGridView dg, params Object[] values)
        {
            DataTable dt = retrieveDTToBeConverted(sp, values);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                int index = indexOfCellWithSuchName(dg, dt.Columns[i].ColumnName);
                if (index != -1)
                {
                    dg.Rows[dataRowIndex].Cells[index].Value = dt.Rows[0].ItemArray[i];
                }
            }
        }

        //
        public static DataTable retrieveDTToBeConvertedParaComprarYOfertar(DataTable dtAUsar, String sp, params Object[] values)
        {
            SqlDataAdapter da = new SqlDataAdapter(generateCommand(sp, values));
            da.Fill(dtAUsar);
            return dtAUsar;
        }



        public static int indexOfCellWithSuchName(DataGridView dg, String columnName)
        {
            foreach (DataGridViewColumn col in dg.Columns)
            {
                if (col.DataPropertyName == columnName)
                {
                    return col.Index;
                }
            }
            return -1;

        }

        private static SqlCommand generateCommand(String sp, params Object[] values)
        {

            SqlConnection sqlcon = new SqlConnection(infoConexion());
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("MESSI_MAS3." + sp, sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            string[] param_names = generarParametros(sp);
            if (param_names.Count() != 0 && values.Count() != 0)
            {
                int i = 0;
                // agrega los parametros que encontro junto con los valores que le mandamos al command
                foreach (var val in values)
                {

                    cmd.Parameters.AddWithValue(param_names[i], values[i] == null ? System.DBNull.Value : values[i]);


                    i++;

                }
            }

            return cmd;

        }
        public static SqlCommand generarComandoYAbrir(String sp, params object[] values)
        {
            SqlCommand cmd = generateCommand(sp, values);
            SqlConnection sqlcon = new SqlConnection(infoConexion());
            sqlcon.Open();
            return cmd;
        }
        // ejecuta cualquier procedure, podemos obtener el valor que devuelven si se quiere 
        public static int executeProcedure(String sp, params object[] values)
        {
            SqlCommand cmd = generarComandoYAbrir(sp, values);
            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            return (int)returnParameter.Value;
        }
        public static DataTable retrieveDT(String sp, params Object[] values)
        {
            return retrieveDTToBeConverted(sp, values);
        }

        public static void bindNamesToDataTable(DataTable dt, DataGridView dg)
        {

            for (var i = 0; i < dg.Columns.Count; i++)
            {
                dg.Columns[i].DataPropertyName = dt.Columns[i].ColumnName;
            }
        }

        public static int retrieveDTAlreadyBinded(String sp, DataGridView dg, params Object[] values)
        {
            DataTable dt = retrieveDTToBeConverted(sp, values);
            if (dt == null)
            {
                return -1;
            }
            dg.DataSource = dt;
            return 1;


        }


        public static int retrieveDT(String sp, DataGridView dg, params Object[] values)
        {
            DataTable dt = retrieveDTToBeConverted(sp, values);
            if (dt == null)
            {
                return -1;
            }
            bindNamesToDataTable(dt, dg);
            dg.DataSource = dt;
            return 1;
        }

     //Modificado para el SUPERGRID PAGINADO
        public static DataTable retrieveDTPaginado(String sp, SuperGrid dg, params Object[] values)
        {
            DataTable dt = retrieveDTToBeConverted(sp, values);
            if (dt == null)
            {
                return dt;
            }
            bindNamesToDataTable(dt, dg);
            dg.DataSource = dt;
            return dt;
        }
        public static int retrieveDTParaComprarYOfertar(DataTable dtLoco, String sp, DataGridView dg, params Object[] values)
        {
            DataTable dt = retrieveDTToBeConvertedParaComprarYOfertar(dtLoco, sp, values);
            if (dt == null)
            {
                return -1;
            }
            bindNamesToDataTable(dt, dg);
            dg.DataSource = dt;
            return 1;
        }



        private static string[] generarParametros(string procedure)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();

            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='MESSI_MAS3' AND SPECIFIC_NAME='" + procedure + "'";
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                string[] argumentos = new string[dataTable.Rows.Count];
                int i = 0;
                foreach (DataRow d in dataTable.Rows)
                {

                    argumentos[i] = (d[0].ToString());
                    i++;
                }
                return argumentos;
            }
            catch (SqlException e)
            {
                throw e;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        // ejecuta una consulta a partir de un procedure y devuelve si encontró algo o no
        public static bool checkIfExists(string procedure, params object[] parametros)
        {
            string[] argumentos = generarParametros(procedure);
            return _verSiExiste(procedure, argumentos, parametros);
        }


        public static bool verSiExiste(string procedure)
        {
            return _verSiExiste(procedure, null, null);
        }

        // ejecuta un procedure y devuelve el valor resultante de ejecutarlo
        public static int ejecutarProcedureRetornaValor(string procedure, params object[] values)
        {
            string[] argumentos = generarParametros(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }

        // ejecuta el procedure dentro de nuestro schema
        private static void ejecutarProcedure(string procedure, string[] args, params object[] values)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();


            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "MESSI_MAS3." + procedure;
                if (chequearParametros(args, values))
                {
                    cargarComandosSql(args, values, command);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        private static bool _verSiExiste(string procedure, string[] argumentos, params object[] parametros)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();

            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "MESSI_MAS3." + procedure;
                if (chequearParametros(argumentos, parametros))
                {
                    cargarComandosSql(argumentos, parametros, command);
                }
                dataReader = command.ExecuteReader();
                return dataReader.HasRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        private static int _executeProcedureWithReturnValue(string procedure, string[] argumentos, params object[] parametros)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();


            try
            {
                conexion(connection, command);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "MESSI_MAS3." + procedure;
                if (chequearParametros(argumentos, parametros))
                {
                    cargarComandosSql(argumentos, parametros, command);
                }
                command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                return (int)command.Parameters["@RETURN_VALUE"].Value;
            }
            catch
            {
                return -1;
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private static bool chequearParametros(string[] argumentos, params object[] parametros)
        {
            //todo ver si hay que validar aca o en la clase que llame al metodo....
            if (argumentos != null && parametros != null)
            {
                if (argumentos.Length != parametros.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }

        private static void cargarComandosSql(string[] argumentos, object[] parametros, SqlCommand command)
        {
            for (int i = 0; i < argumentos.Length; i++)
            {
                command.Parameters.AddWithValue(argumentos[i], parametros[i]);
            }
        }

        internal static string ejecutarYDevolverString(String sp, params object[] values)
        {
            SqlCommand cmd = generarComandoYAbrir(sp, values);
            Object objeto = cmd.ExecuteScalar();
            if (objeto.GetType() != typeof(DBNull))
            {
                return (string)objeto;
            }
            return "NULL";
        }
    }





}

