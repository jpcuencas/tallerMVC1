using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tallerMVC1.Models
{
    public static class Oficinas
    {
        public static List<Oficina> dameSucursales()
        {
            var oficinas = new List<Oficina>();

            Oficina aux = new Oficina();
            aux.id = 1;
            aux.nombre = "Centro";
            aux.telefonos = "965, 966, 967";
            aux.direccion = "Calle del pez, 2";
            aux.poblacion = "Alicante";
            aux.url = "http://www.google.com";
            oficinas.Add(aux);

            aux = new Oficina();
            aux.id = 2;
            aux.nombre = "Playa";
            aux.telefonos = "96526, 96621, 96716";
            aux.direccion = "Calle del pulpo, 2";
            aux.poblacion = "Playa de San Juan";
            aux.url = "http://www.ua.es";
            oficinas.Add(aux);

            aux = new Oficina();
            aux.id = 3;
            aux.nombre = "Barrio alto";
            aux.telefonos = "96510, 96611, 9612";
            aux.direccion = "Calle del monte, 2";
            aux.poblacion = "Sant Joan";
            aux.url = "http://www.dlsi.ua.es";
            oficinas.Add(aux);


            return oficinas;
        }

        public static Oficina dameDatosOficina(int id)
        {
            Oficina ofi = Oficinas.dameSucursales().ToList().Where(o => o.id == id).First();
            
            return ofi;            
        }
    }
}