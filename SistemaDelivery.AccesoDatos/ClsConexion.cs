using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.AccesoDatos {
    class ClsConexion {

        private string BD;

        private string server;

        private string user;

        private string clave;

        private bool autenticacion = true;

        private static ClsConexion cnx = null;

        private ClsConexion() {
            this.BD = "DB_RESTAURANTE";
            this.server = "PCW10ALX";
            this.user = "sa";
            this.clave = "Alex1234";
        }

        public SqlConnection establecerConexion() {
            SqlConnection url = new SqlConnection();
            try {
                url.ConnectionString = "Server=" + this.server + ";" + "Database=" + this.BD + ";";
                if (this.autenticacion) {
                    url.ConnectionString += "Integrated Security = SSPI";
                }
                else {
                    url.ConnectionString += "User Id=" + this.user + ";" + "Password=" + this.clave;
                }
            }
            catch (Exception ex) {
                url = null;
                throw ex;
            }
            return url;
        }

        public static ClsConexion getInstancia() {
            if (cnx == null) {
                cnx = new ClsConexion();
            }
            return cnx;
        }
    }
}
