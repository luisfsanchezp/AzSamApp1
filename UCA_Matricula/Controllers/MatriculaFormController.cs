using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using UCA_Matricula.Models;

namespace UCA_Matricula.Controllers
{
    public class MatriculaFormController : Controller
    {
        public IActionResult Index()
        {
            // Leer Programas
            var fileProgramas = Path.Combine("Data", "Programas.json");
            var jsonProgramas = System.IO.File.ReadAllText(fileProgramas);
            var programas = JsonSerializer.Deserialize<List<string>>(jsonProgramas);

            // Leer Periodos
            var filePeriodos = Path.Combine("Data", "Periodos.json");
            var jsonPeriodos = System.IO.File.ReadAllText(filePeriodos);
            var periodos = JsonSerializer.Deserialize<List<string>>(jsonPeriodos);

            // Crear el modelo
            var model = new MatriculaFormModel
            {
                Programas = programas ?? new List<string>(),
                Periodos = periodos ?? new List<string>()
            };

            return View(model);
        }
    }
}

