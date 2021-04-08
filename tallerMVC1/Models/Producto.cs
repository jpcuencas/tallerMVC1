using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tallerMVC1.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int categoria { get; set; }

        public string nombreCategoria { get; set; }

        public Producto()
        {
            id = 0;
            nombre = "";
            descripcion = "";
            precio = 0.0;
            categoria = 0;
            nombreCategoria = "";
        }
    }
}