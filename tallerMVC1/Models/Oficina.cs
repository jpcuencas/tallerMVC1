using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tallerMVC1.Models
{
    public class Oficina
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string poblacion { get; set; }
        public string telefonos { get; set; }

        public string url { get; set; }

        public Oficina()
        {
            id = 0;
            nombre = "";
            direccion = "";
            poblacion = "";
            telefonos = "";
            url = "";
        }
    }
}