using System;
using System.Collections.Generic;

namespace TiposDeDatosApp
{
    public class Helper
    {
        public void MostrarTiposDeDatos()
        {
            int entero = 25;
            double decimalDoble = 3.1416;
            float decimalFlotante = 1.5f;
            long enteroLargo = 123456789L;
            char caracter = 'A';
            string texto = "Hola, C#";
            bool esVerdadero = true;
            DateTime fechaActual = DateTime.Now;
            var mensaje = "Tipo inferido";
            int[] numeros = { 1, 2, 3, 4, 5 };
            List<string> frutas = new List<string> { "Manzana", "Pera", "Banano" };

            Console.WriteLine("===== TIPOS DE DATOS EN C# =====");
            Console.WriteLine($"int: {entero}");
            Console.WriteLine($"double: {decimalDoble}");
            Console.WriteLine($"float: {decimalFlotante}");
            Console.WriteLine($"long: {enteroLargo}");
            Console.WriteLine($"char: {caracter}");
            Console.WriteLine($"string: {texto}");
            Console.WriteLine($"bool: {esVerdadero}");
            Console.WriteLine($"DateTime: {fechaActual}");
            Console.WriteLine($"var: {mensaje}");
            Console.WriteLine($"array: {string.Join(", ", numeros)}");
            Console.WriteLine($"List<string>: {string.Join(", ", frutas)}");
        }
    }
}