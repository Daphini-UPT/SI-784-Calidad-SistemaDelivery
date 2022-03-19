using SistemaDelivery.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.Negocio
{
    public class UsuarioNegocio
    {

        public static DataTable loguear(string id, string password)
        {
            return new UsuarioDatos().loguear(id, password);
        }

    }
}
