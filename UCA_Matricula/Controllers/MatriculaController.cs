using Microsoft.AspNetCore.Mvc;
using UCA_Matricula.Models;
using System.Text.Json;

namespace UCA_Matricula.Controllers
{
    [Route("Matricula")]
    public class MatriculaController : Controller
    {
        private readonly string filePath = "Data/matriculas.json";

        [HttpPost("Guardar")]
        public IActionResult Guardar(
            [FromForm] string Programa,
            [FromForm] string IdEstudiante,
            [FromForm] decimal Valor,
            [FromForm] string Periodo,
            [FromForm] string FormularioMatricula
        )
        {
            var nuevaMatricula = new Matricula
            {
                IdMatricula = new Random().Next(1000, 9999),
                Programa = Programa,                     
                NombreEstudiante = IdEstudiante,         
                Valor = Valor,
                Periodo = Periodo,
                Descripcion = FormularioMatricula 
            };
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");

            List<Matricula> lista = new List<Matricula>();

            if (System.IO.File.Exists(filePath))
            {
                string contenido = System.IO.File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(contenido))
                    lista = JsonSerializer.Deserialize<List<Matricula>>(contenido);
            }

            lista.Add(nuevaMatricula);

            string json = JsonSerializer.Serialize(
                lista,
                new JsonSerializerOptions { WriteIndented = true }
            );

            System.IO.File.WriteAllText(filePath, json);

            return Content("Matrícula guardada correctamente.");
        }
    }
}
