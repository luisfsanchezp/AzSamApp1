using System;

namespace TiposDeDatosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demostración Tipos de Datos en C#\n");

            Helper helper = new Helper();
            helper.MostrarTiposDeDatos();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}