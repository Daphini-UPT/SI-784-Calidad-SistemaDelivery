using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.AccesoDatos
{
    public class UsuarioDatos
    {
        public DataTable loguear(string id, string password)
        {
            SqlConnection sqlCnx = new SqlConnection();
            DataTable tabla = new DataTable();
            SqlDataReader resultado;
            try
            {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spComprobarUsuario", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                sqlCnx.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch(Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if(sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
        }
    }
}
