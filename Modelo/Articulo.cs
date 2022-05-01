using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca idMarca { get; set; }
        public Categoria idCategoria { get; set; }
        public string imagenUrl { get; set; }
        public float precio { get; set; }
    }
}
