// File: Controllers/HomeController.cs
using EJ1.Models.DAL;
using EJ1.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using EJ1.Models.ViewModels;

namespace EJ1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var hora = DateTime.Now.Hour;
            String saludo = hora < 12 ? "Buenos días" : hora < 20 ? "Buenas tardes" : "Buenas noches";

            List<clsDepartamento> departamentos = clsListadoPersonasDAL.ObtenerListadoDepartamentos();

            Random rnd = new Random();
            clsDepartamento? departamentoRandom = departamentos[rnd.Next(departamentos.Count)];

            // Ahora se crea la persona pasando el Id del departamento en lugar del objeto
            clsPersona persona = new clsPersona("Andrés", "Ojeda Rodríguez", 19, "andres.ojeda@iesnervion.es", departamentoRandom?.IdDepartamento);

            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            return View(persona);
        }

        public IActionResult ListadoPersonas()
        {
            return View(clsListadoPersonasDAL.ObtenerListadoPersonas());
        }

        public IActionResult PersonaPorPosicion()
        {
            return View(clsListadoPersonasDAL.ObtenerPersonaPorPosicion(3));
        }

        public IActionResult EditarPersona()
        {
            var vm = new EditarPersonaVM();
            return View(vm);
        }
    }
}
