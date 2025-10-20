namespace EJ1.Models.Entities

{
    public class clsPersona
    {
        public string _nombre { get; set; }
        public string _apellidos { get; set; }
        public int _edad { get; set; }
        public string _email { get; set; }

        // Constructor
        public clsPersona(string nombre, string apellidos, int edad, string email)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            _edad = edad;
            _email = email;
        }

        // Getters y Setters
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Método para mostrar la información de la persona
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellidos: {Apellidos}, Edad: {Edad}, Email: {Email}";
        }
    }
}

