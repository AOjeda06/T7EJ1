using System.ComponentModel.DataAnnotations;

namespace EJ1.Models.Entities
{
    public class clsPersona
    {
        public clsPersona() {
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Edad = 0;
            Email = string.Empty;
            Departamento = null;
        }

        public clsPersona(string nombre, string apellidos, int edad, string email, clsDepartamento departamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Email = email;
            Departamento = departamento;
        }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Range(0, 150)]
        public int Edad { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public clsDepartamento? Departamento { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellidos: {Apellidos}, Edad: {Edad}, Email: {Email}, Departamento: {Departamento?.NombreDepartamento}";
        }
    }
}
