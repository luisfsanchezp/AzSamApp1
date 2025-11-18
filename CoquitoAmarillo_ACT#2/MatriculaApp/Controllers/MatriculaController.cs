using Microsoft.AspNetCore.Mvc;
using MatriculaApp.Models;
using System.Text.Json;

namespace MatriculaApp.Controllers
{
    [Route("Matricula")]
    public class MatriculaController : Controller
    {
        [HttpPost("Guardar")]
        public IActionResult Guardar(Matricula datos)
        {
            var json = JsonSerializer.Serialize(datos);
            System.IO.File.WriteAllText("matricula.json", json);

            return Content("Matrícula guardada correctamente en matricula.json");
        }
    }
}
