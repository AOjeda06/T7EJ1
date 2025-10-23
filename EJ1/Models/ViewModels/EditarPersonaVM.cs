using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using EJ1.Models.Entities;
using EJ1.Models.DAL;

namespace EJ1.Models.ViewModels
{
    public class EditarPersonaVM
    {
        private static readonly Random _rnd = new Random();

        public EditarPersonaVM()
        {
            List<clsPersona> listado = clsListadoPersonasDAL.ObtenerListadoPersonas() ?? new List<clsPersona>();

            if (listado.Count > 0)
            {
                // uso de _rnd para evitar reseeding frecuente
                Persona = listado.ElementAt(_rnd.Next(listado.Count));
            }
            else
            {
                Persona = new clsPersona();
            }

            Departamentos = new List<clsDepartamento>();
            DepartamentoIdSeleccionado = Persona?.Departamento?.IdDepartamento;
        }

        public clsPersona Persona { get; set; }
        public IEnumerable<clsDepartamento> Departamentos { get; set; }
        public int? DepartamentoIdSeleccionado { get; set; }

        public SelectList DepartamentosSelectList
            => Departamentos != null
               ? new SelectList(Departamentos, "IdDepartamento", "NombreDepartamento", DepartamentoIdSeleccionado)
               : new SelectList(new List<clsDepartamento>(), "IdDepartamento", "NombreDepartamento", DepartamentoIdSeleccionado);
    }
}
