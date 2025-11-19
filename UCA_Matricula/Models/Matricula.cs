namespace UCA_Matricula.Models
{
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public string? Programa { get; set; }
        public string? NombreEstudiante { get; set; }
        public decimal Valor { get; set; }
        public string? Periodo { get; set; }
        public string? Descripcion { get; set; }
    }
}
