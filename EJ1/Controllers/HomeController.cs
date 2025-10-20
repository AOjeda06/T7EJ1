// Controllers/HomeController.cs
using EJ1.Models.DAL;
using EJ1.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EJ1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hora = DateTime.Now.Hour;
            string saludo = hora < 12
                ? "Buenos días"
                : hora < 20
                    ? "Buenas tardes"
                    : "Buenas noches";

            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            var persona = new clsPersona("Andrés", "Ojeda Rodríguez", 19, "andres.ojeda@iesnervion.es");
            return View(persona);
        }

        public ActionResult ListadoPersonas()
        {
            var listado = clsListadoPersonasDAL.ObtenerListadoPersonas();
            return View(listado);
        }

        public ActionResult PersonaPorPosicion()
        {
            var listado = clsListadoPersonasDAL.ObtenerListadoPersonas();

            if (listado.Count >= 3)
            {
                // Tercera persona del listado (índice 2)
                clsPersona persona = listado[2];
                return View(persona);
            }
            return View("Error" );
        }
    }
}
