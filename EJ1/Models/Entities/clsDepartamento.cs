namespace EJ1.Models.Entities
{
    public class clsDepartamento
    {
        #region Atributos
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public override string ToString() => NombreDepartamento;
        #endregion

        #region Constructores
        public clsDepartamento(int idDepartamento, string nombreDepartamento)
        {
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
        }
        public clsDepartamento()
        {
            IdDepartamento = 0;
            NombreDepartamento = string.Empty;
        }
        #endregion
    }
}
