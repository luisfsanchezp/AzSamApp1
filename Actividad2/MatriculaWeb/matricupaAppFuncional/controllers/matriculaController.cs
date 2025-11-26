using Microsoft.AspNetCore.Mvc;
using MatriculaApp.Models;
using System.Text.Json;

namespace MatriculaApp.Controllers
{
    [Route("Matricula")]
    public class MatriculaController : Controller
    {
        [HttpPost("enviar")]
        public IActionResult enviar(Matricula datos)
        {
            var json = JsonSerializer.Serialize(datos);
            System.IO.File.WriteAllText("matricula.json", json);

            return Content("Matrícula enviada con exito");
        }
    }
}