using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using UCA_Matricula.Models;

namespace UCA_Matricula.Pages
{
    public class MatriculaFormModel : PageModel
    {
        public List<string> Programas { get; set; } = new();
        public List<string> Periodos { get; set; } = new();

        public void OnGet()
        {
            // Ruta Programas
            var rutaProgramas = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Programas.json");
            if (System.IO.File.Exists(rutaProgramas))
                Programas = JsonSerializer.Deserialize<List<string>>(System.IO.File.ReadAllText(rutaProgramas)) ?? new();

            // Ruta Periodos
            var rutaPeriodos = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Periodos.json");
            if (System.IO.File.Exists(rutaPeriodos))
                Periodos = JsonSerializer.Deserialize<List<string>>(System.IO.File.ReadAllText(rutaPeriodos)) ?? new();
        }
    }
}
