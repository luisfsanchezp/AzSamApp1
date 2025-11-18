namespace UCA_Matricula.Models
{
    public class Docente
    {
        public int IdDocente { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Tel { get; set; }
        public string? Cel { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
