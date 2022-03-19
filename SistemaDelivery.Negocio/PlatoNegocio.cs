using SistemaDelivery.AccesoDatos;
using SistemaDelivery.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.Negocio {
    public class PlatoNegocio {

        public static DataTable listar() {
            return new PlatoDatos().listar();
        }

        public static string insertar(string nombre, float precio, int tipoPlatoCodigo, string estado) {
            PlatoDatos platoDatos = new PlatoDatos();
            string verificar = platoDatos.verificar(nombre);
            if (verificar.Equals("1")) {
                return "El plato ya se encuentra registrado en la Base de Datos";
            }
            else {
                PlatoEntidad platoEntidad = new PlatoEntidad();
                platoEntidad.nombre = nombre;
                platoEntidad.precio = precio;
                platoEntidad.TipoPlatocodigo = tipoPlatoCodigo;
                platoEntidad.estado = estado;
                return platoDatos.insertar(platoEntidad);
            }
        }

        public static DataTable listarTiposDePlato() {
            return new PlatoDatos().listarTiposDePlato();
        }

        public static string actualizar(int id, string nombre, float precio, int tipoPlatoCodigo, string estado) {
            PlatoEntidad platoEntidad = new PlatoEntidad();
            platoEntidad.codigo = id;
            platoEntidad.nombre = nombre;
            platoEntidad.precio = precio;
            platoEntidad.TipoPlatocodigo = tipoPlatoCodigo;
            platoEntidad.estado = estado;
            return new PlatoDatos().actualizar(platoEntidad);
        }

        public static string eliminar(int id) {
            return new PlatoDatos().eliminar(id);
        }

        public static DataTable buscar(string busqueda) {
            return new PlatoDatos().buscar(busqueda);
        }
    }
}
