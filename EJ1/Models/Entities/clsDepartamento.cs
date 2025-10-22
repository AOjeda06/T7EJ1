namespace EJ1.Models.Entities
{
    public class clsDepartamento
    {
        public clsDepartamento(int idDepartamento, string nombreDepartamento)
        {
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
        }

        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public override string ToString() => NombreDepartamento;
    }
}
