using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tallerMVC1.Models;

namespace tallerMVC1.Controllers
{
    public class CatalogoController : Controller
    {
        //
        // GET: /Catalogo/

        public ActionResult Index(int categoria=-1)
        {
            List<Producto> productos = new List<Producto>();
            ViewBag.error = "";

            try
            {
                if (categoria == -1)
                {
                    productos = Productos.listadoProductos().OrderBy(p => p.nombre).ToList();
                }
                else
                {
                    productos = Productos.listadoProductos().Where(p=>p.categoria==categoria).OrderBy(p => p.nombre).ToList();
                }

                var categorias = Categorias.listadoCategorias().OrderBy(c => c.nombre);

                List<SelectListItem> listaCat = new SelectList(categorias, "id", "nombre").ToList();
                listaCat.Insert(0, new SelectListItem { Text = "Todas las categorías", Value = "-1" });

                ViewBag.categoria = listaCat;

            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
            }

            return View(productos);
        }

    }
}
