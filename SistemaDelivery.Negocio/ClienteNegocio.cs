using SistemaDelivery.AccesoDatos;
using SistemaDelivery.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.Negocio {
    public class ClienteNegocio {

        public static DataTable listar() {
            return new ClienteDatos().listar();
        }

        public static DataTable buscar(string busqueda) {
            return new ClienteDatos().buscar(busqueda);
        }

        public static string insertar(string nombre, string apellidos, string direccion, string telefono) {
            ClienteDatos clienteDatos = new ClienteDatos();
            string verificar = clienteDatos.verificar(nombre, apellidos);
            if (verificar.Equals("1")) {
                return "El cliente ya se encuentra registrado en la Base de Datos";
            }
            else {
                ClienteEntidad clienteEntidad = new ClienteEntidad();
                clienteEntidad.nombre = nombre;
                clienteEntidad.apellidos = apellidos;
                clienteEntidad.direccion = direccion;
                clienteEntidad.telefono = telefono;
                return clienteDatos.insertar(clienteEntidad);
            }
        }

        public static string actualizar(int id, string nombre, string apellidos, string direccion, string telefono) {
            ClienteEntidad clienteEntidad = new ClienteEntidad();
            clienteEntidad.codigo = id;
            clienteEntidad.nombre = nombre;
            clienteEntidad.apellidos = apellidos;
            clienteEntidad.direccion = direccion;
            clienteEntidad.telefono = telefono;
            return new ClienteDatos().actualizar(clienteEntidad);
        }

        public static string eliminar(int id) {
            return new ClienteDatos().eliminar(id);
        }
    }
}
