using System.Collections.Generic;
using EJ1.Models.Entities;

namespace EJ1.Models.DAL
{
    public static class clsListadoPersonasDAL
    {
        #region Funciones y Métodos
        public static List<clsDepartamento> ObtenerListadoDepartamentos()
        {
            return new List<clsDepartamento>
            {
                new clsDepartamento(1, "Recursos Humanos"),
                new clsDepartamento(2, "Desarrollo"),
                new clsDepartamento(3, "Finanzas"),
                new clsDepartamento(4, "Marketing"),
                new clsDepartamento(5, "Soporte")
            };
        }

        public static List<clsPersona> ObtenerListadoPersonas()
        {
            List<clsDepartamento> deps = ObtenerListadoDepartamentos();
            return new List<clsPersona>
            {
                new clsPersona("Ana", "Gómez López", 25, "ana.gomez@example.com", deps[0]),
                new clsPersona("Carlos", "Martín Ruiz", 32, "carlos.martin@example.com", deps[1]),
                new clsPersona("Elena", "Sánchez Díaz", 29, "elena.sanchez@example.com", deps[2]),
                new clsPersona("Miguel", "Torres Fernández", 40, "miguel.torres@example.com", deps[1]),
                new clsPersona("Laura", "Vargas Pérez", 22, "laura.vargas@example.com", deps[3]),
                new clsPersona("Diego", "Romero Castillo", 36, "diego.romero@example.com", deps[4])
            };
        }

        public static clsPersona? ObtenerPersonaPorPosicion(int posicion)
        {
            List<clsPersona> listado = ObtenerListadoPersonas();
            if (listado != null && posicion >= 0 && posicion < listado.Count)
            {
                return listado[posicion];
            }
            return null;
        }
        #endregion
    }
}
