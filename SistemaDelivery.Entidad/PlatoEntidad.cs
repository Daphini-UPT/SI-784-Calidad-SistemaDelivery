using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDelivery.Entidad {
    public class PlatoEntidad {

        public int codigo { get; set; }

        public string nombre { get; set; }

        public float precio { get; set; }

        public int TipoPlatocodigo { get; set; }

        public string estado { get; set; }
    }
}
