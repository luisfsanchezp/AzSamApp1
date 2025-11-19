namespace UCA_Matricula.Models
{
    public class DatosEstudiante
    {
        public int IdDatoEstudiante { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int AdjuntoId { get; set; } // FK a DocumentoEstudiante
    }
}
