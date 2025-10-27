// File: Models/Entities/clsPersona.cs
using System.ComponentModel.DataAnnotations;

namespace EJ1.Models.Entities
{
    public class clsPersona
    {
        #region Atributos
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        // Cambio: almacenar ahora el Id del departamento en lugar del objeto Departamento
        public int? DepartamentoId { get; set; }
        #endregion

        #region Constructores
        public clsPersona()
        {
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Edad = 0;
            Email = string.Empty;
            DepartamentoId = null;
        }

        public clsPersona(string nombre, string apellidos, int edad, string email, int? departamentoId)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Email = email;
            DepartamentoId = departamentoId;
        }
        #endregion

        #region Funciones y Métodos
        public override string ToString()
        {
            // Dejar solo el Id en la representación; el nombre de departamento puede resolverse por quien muestre la entidad
            return $"Nombre: {Nombre}, Apellidos: {Apellidos}, Edad: {Edad}, Email: {Email}, DepartamentoId: {DepartamentoId}";
        }
        #endregion
    }
}
