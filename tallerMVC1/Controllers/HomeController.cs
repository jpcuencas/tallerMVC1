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

        public ActionResult masinfo()
        {

            var paises = Paises.listadoPaises().OrderBy(p => p.nombre);

            if (Paises.msgErr != "")
            {
                ViewBag.error = Paises.msgErr;
            } else {
                ViewBag.pais = new SelectList(paises, "id", "nombre", "1");
            }

            return View();
        }

        /*[HttpPost]
        public ActionResult masinfo(string nombre, string email, string solicitud, string pais, string[] departamento, string respuesta)
        {
            ViewBag.nombre = nombre;
            ViewBag.email = email;
            ViewBag.solicitud = solicitud;
            ViewBag.pais = pais;
            ViewBag.departamentos = departamento;
            ViewBag.respuesta = respuesta;

            return View("rMasInfo");
        }*/

        [HttpPost]
        public ActionResult masinfo(FormCollection formulario)
        {
            ViewBag.nombre = formulario["nombre"];
            ViewBag.email = formulario["email"];
            ViewBag.solicitud = formulario["solicitud"];
            ViewBag.pais = formulario["pais"];
            ViewBag.departamentos = formulario["departamento"].Split(',');
            ViewBag.respuesta = formulario["respuesta"];

            return View("rMasInfo");
        }

    }
}
