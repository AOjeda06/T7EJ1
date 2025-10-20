// Models/DAL/clsListadoPersonasDAL.cs
using System.Collections.Generic;
using EJ1.Models.Entities;

namespace EJ1.Models.DAL
{
    public static class clsListadoPersonasDAL
    {
        public static List<clsPersona> ObtenerListadoPersonas()
        {
            return new List<clsPersona>
            {
                new clsPersona("Ana", "Gómez López", 25, "ana.gomez@example.com"),
                new clsPersona("Carlos", "Martín Ruiz", 32, "carlos.martin@example.com"),
                new clsPersona("Elena", "Sánchez Díaz", 29, "elena.sanchez@example.com"),
                new clsPersona("Miguel", "Torres Fernández", 40, "miguel.torres@example.com"),
                new clsPersona("Laura", "Vargas Pérez", 22, "laura.vargas@example.com"),
                new clsPersona("Diego", "Romero Castillo", 36, "diego.romero@example.com")
            };
        }
    }
}
