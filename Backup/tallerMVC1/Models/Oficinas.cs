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
            oficinas.Add(aux);

            aux = new Oficina();
            aux.id = 2;
            aux.nombre = "Playa";
            aux.telefonos = "96526, 96621, 96716";
            oficinas.Add(aux);

            aux = new Oficina();
            aux.id = 3;
            aux.nombre = "Barrio alto";
            aux.telefonos = "96510, 96611, 9612";
            oficinas.Add(aux);


            return oficinas;
        }

        public static Oficina dameDatosOficina(int id)
        {
            var ofi = new Oficina();
            ofi.id = id;
            ofi.nombre = "Centro";
            ofi.direccion="Calle del pez, s/n";
            ofi.poblacion = "Alicante";
            ofi.telefonos = "965, 966, 9655645643";

            return ofi;            
        }
    }
}