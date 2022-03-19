using SistemaDelivery.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.AccesoDatos {
    public class PlatoDatos {

        public DataTable listar() {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = null;
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spListarPlatos", sqlCnx);
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

        public string insertar(PlatoEntidad plato) {
            string rpta = "";
            SqlConnection sqlCnx = null;

            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spInsertarPlato", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = plato.nombre;
                comando.Parameters.Add("@precio", SqlDbType.Float).Value = plato.precio;
                comando.Parameters.Add("@TPLcodigo", SqlDbType.Int).Value = plato.TipoPlatocodigo;
                comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = plato.estado;
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

        public string verificar(string nombre) {
            string rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spVerificarPlato", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
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

        public DataTable listarTiposDePlato() {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = null;
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spListarTiposDePlato", sqlCnx);
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

        public string actualizar(PlatoEntidad plato) {
            string rpta = "";
            SqlConnection sqlCnx = null;

            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spActualizarPlato", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@platoId", SqlDbType.Int).Value = plato.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = plato.nombre;
                comando.Parameters.Add("@precio", SqlDbType.Float).Value = plato.precio;
                comando.Parameters.Add("@TPLcodigo", SqlDbType.Int).Value = plato.TipoPlatocodigo;
                comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = plato.estado;
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
                SqlCommand comando = new SqlCommand("spEliminarPlato", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@platoId", SqlDbType.Int).Value = id;
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

        public DataTable buscar(string busqueda) {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCnx = null;
            try {
                sqlCnx = ClsConexion.getInstancia().establecerConexion();
                SqlCommand comando = new SqlCommand("spBuscarPlato", sqlCnx);
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
    }
}
