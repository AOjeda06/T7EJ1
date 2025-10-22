using EJ1.Models.DAL;
using EJ1.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace EJ1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var hora = DateTime.Now.Hour;
            var saludo = hora < 12 ? "Buenos días" : hora < 20 ? "Buenas tardes" : "Buenas noches";

            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            var departamentos = clsListadoPersonasDAL.ObtenerListadoDepartamentos();
            var departamentoPorDefecto = departamentos != null && departamentos.Count > 0 ? departamentos[0] : null;

            var persona = new clsPersona("Andrés", "Ojeda Rodríguez", 19, "andres.ojeda@iesnervion.es", departamentoPorDefecto);
            return View(persona);
        }

        public IActionResult ListadoPersonas()
        {
            var listado = clsListadoPersonasDAL.ObtenerListadoPersonas() ?? new System.Collections.Generic.List<clsPersona>();
            return View(listado);
        }

        public IActionResult PersonaPorPosicion()
        {
            var listado = clsListadoPersonasDAL.ObtenerListadoPersonas();

            if (listado == null || listado.Count < 3)
            {
                return View("Error");
            }

            var persona = listado.ElementAtOrDefault(2);
            if (persona == null)
            {
                return View("Error");
            }

            return View(persona);
        }

        public IActionResult EditarPersona()
        {
            var listado = clsListadoPersonasDAL.ObtenerListadoPersonas();
            var departamentos = clsListadoPersonasDAL.ObtenerListadoDepartamentos();

            if (listado == null || listado.Count == 0)
            {
                return View("Error");
            }

            var rnd = new Random();
            int posicion = rnd.Next(0, listado.Count);
            var persona = listado[posicion];

            ViewBag.Departamentos = new SelectList(departamentos, "IdDepartamento", "NombreDepartamento", persona.Departamento?.IdDepartamento);
            return View(persona);
        }
    }
}
