using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tallerMVC1.Models;

namespace tallerMVC1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.subtitulo = "Bienvenida/o al sitio web";

            return View();
        }

        public ActionResult contacto()
        {
            ViewBag.subtitulo = "Contacta con nosotros";

            var oficinas = Oficinas.dameSucursales();

            return View(oficinas);
        }

        public ActionResult detalle(int id)
        {

            var oficina = Oficinas.dameDatosOficina(id);

            ViewBag.subtitulo = "Datos de nuestra oficina " + oficina.nombre;

            return View(oficina);
        }

        public ActionResult detalleAjax(int id)
        {

            var oficina = Oficinas.dameDatosOficina(id);

            ViewBag.subtitulo = "Datos de nuestra oficina " + oficina.nombre;

            return View(oficina);
        }

    }
}
