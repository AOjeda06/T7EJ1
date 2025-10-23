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
        public clsDepartamento? Departamento { get; set; }
        #endregion

        #region Constructores
        public clsPersona()
        {
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
        #endregion

        #region Funciones y Métodos
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellidos: {Apellidos}, Edad: {Edad}, Email: {Email}, Departamento: {Departamento?.NombreDepartamento}";
        }
        #endregion
    }
}
