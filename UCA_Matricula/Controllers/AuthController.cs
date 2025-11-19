using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace UCA_Matricula.Controllers
{
    [Route("Auth")]
    public class AuthController : Controller
    {
        private readonly string userFile = "Data/usuarios.json";

        [HttpPost("CrearCuenta")]
        public IActionResult CrearCuenta([FromForm] string Usuario, [FromForm] string Contrasena)
        {
            if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");

            List<Dictionary<string, string>> usuarios = new();

            if (System.IO.File.Exists(userFile))
            {
                var data = System.IO.File.ReadAllText(userFile);
                if (!string.IsNullOrWhiteSpace(data))
                    usuarios = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(data);
            }

            usuarios.Add(new Dictionary<string, string>
            {
                {"Usuario", Usuario },
                {"Contrasena", Contrasena }
            });

            System.IO.File.WriteAllText(userFile, JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true }));

            return Content("Cuenta creada. Ahora puedes iniciar sesión.");
        }

        [HttpPost("Login")]
        public IActionResult Login([FromForm] string Usuario, [FromForm] string Contrasena)
        {
            if (!System.IO.File.Exists(userFile))
                return Content("No hay usuarios registrados.");

            var data = System.IO.File.ReadAllText(userFile);
            var usuarios = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(data);

            var existe = usuarios.FirstOrDefault(u =>
                u["Usuario"] == Usuario && u["Contrasena"] == Contrasena
            );

            if (existe == null)
                return Content("Usuario o contraseña incorrectos");

            return Redirect("/Principal");
        }
    }
}
