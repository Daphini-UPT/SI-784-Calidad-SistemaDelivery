using SistemaDelivery.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.AccesoDatos {
    public class ClienteDatos {

        public DataTable listar() {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = null;
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spListarClientes", sqlCnx);
                sqlCnx.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (sqlCnx.State == ConnectionState.Open) {
                    sqlCnx.Close();
                }
            }
        }

        public DataTable buscar(string busqueda) {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = null;
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spBuscarCliente", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda;
                sqlCnx.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (sqlCnx.State == ConnectionState.Open) {
                    sqlCnx.Close();
                }
            }
        }

        public string insertar(ClienteEntidad cliente) {
            string rpta = "";
            SqlConnection sqlCnx = null;

            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spInsertarCliente", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.telefono;
                sqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "ERROR";
            }
            catch (Exception ex) {
                rpta = ex.Message;
            }
            finally {
                if (sqlCnx.State == ConnectionState.Open) {
                    sqlCnx.Close();
                }
            }
            return rpta;
        }

        public string actualizar(ClienteEntidad cliente) {
            string rpta = "";
            SqlConnection sqlCnx = null;

            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spActualizarCliente", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@clienteId", SqlDbType.Int).Value = cliente.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.telefono;
                sqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK. Registro Actualizado" : "No se pudo actualizar el registro";
            }
            catch (Exception ex) {
                rpta = ex.Message;
            }
            finally {
                if (sqlCnx.State == ConnectionState.Open) {
                    sqlCnx.Close();
                }
            }
            return rpta;
        }

        public string eliminar(int id) {
            string rpta = "";
            SqlConnection sqlCnx = null;

            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spEliminarCliente", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@clienteId", SqlDbType.Int).Value = id;
                sqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK. Registro Eliminado" : "No se pudo eliminar el registro";
            }
            catch (Exception ex) {
                rpta = ex.Message;
            }
            finally {
                if (sqlCnx.State == ConnectionState.Open) {
                    sqlCnx.Close();
                }
            }
            return rpta;
        }

        //Metodo Verificar
        public string verificar(string nombre, string apellidos) {
            string rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spVerificarCliente", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = apellidos;
                SqlParameter existe = new SqlParameter();
                existe.ParameterName = "@existe";
                existe.SqlDbType = SqlDbType.Int;
                existe.Direction = ParameterDirection.Output;
                comando.Parameters.Add(existe);
                sqlCnx.Open();
                rpta = Convert.ToString(existe.Value);
            }
            catch (Exception ex) {
                rpta = ex.Message;
            }
            finally {
                if (sqlCnx.State == ConnectionState.Open) {
                    sqlCnx.Close();
                }
            }
            return rpta;
        }

    }
}
