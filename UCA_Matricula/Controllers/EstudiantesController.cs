using Microsoft.AspNetCore.Mvc;
using UCA_Matricula.Models;
using System.Text.Json;

namespace UCA_Matricula.Controllers
{
    [Route("Estudiantes")]
    public class EstudiantesController : Controller
    {
        private readonly string filePath = "Data/estudiantes.json";

        [HttpPost("Crear")]
        public IActionResult Crear(Estudiante model)
        {
            List<Estudiante> lista = new();

            // crear carpeta si no existe
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");

            // cargar JSON existente
            if (System.IO.File.Exists(filePath))
            {
                var jsonData = System.IO.File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(jsonData))
                    lista = JsonSerializer.Deserialize<List<Estudiante>>(jsonData);
            }

            // agregar estudiante
            lista.Add(model);

            // guardar
            var jsonFinal = JsonSerializer.Serialize(lista, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            System.IO.File.WriteAllText(filePath, jsonFinal);

            return Content("Estudiante guardado correctamente.");
        }
    }
}
