using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tallerMVC1.Models
{
    public class Categoria
    {

        public int id { get; set; }
        public string nombre { get; set; }

        public Categoria()
        {
            id = 0;
            nombre = "";
        }

    }
}