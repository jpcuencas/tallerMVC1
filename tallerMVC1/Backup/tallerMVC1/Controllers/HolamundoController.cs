using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tallerMVC1.Controllers
{
    public class HolamundoController : Controller
    {
        //
        // GET: /Holamundo/

        public ActionResult Index()
        {
            ViewBag.Saludo = "Hola mundo desde el controlador";
            return View();
        }

    }
}
