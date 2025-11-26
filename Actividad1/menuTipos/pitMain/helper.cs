using System;

namespace pitMain
{
    public class Helper
    {
        public void Menu()
        {
            int opcion = 0;
            while (opcion != 4)
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("1. Enteros");
                Console.WriteLine("2. Strings");
                Console.WriteLine("3. Arrays");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MenuEnteros();
                        break;
                    case 2:
                        MenuStrings();
                        break;
                    case 3:
                        MenuArrays();
                        break;
                }
            }
        }

        public void MenuEnteros()
        {
            int opcion = 0;
            while (opcion != 6)
            {
                Console.WriteLine("Menu Enteros");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Dividir");
                Console.WriteLine("4. multiplicacion y modulo");
                Console.WriteLine("5. Otra");
                Console.WriteLine("6. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("primero numero que se sumara: "); int a = int.Parse(Console.ReadLine());
                        Console.Write("segundo numero que se sumara: "); int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la suma es:  ", a + b);
                        break;
                    case 2:
                        Console.Write("primero numero que se restara: "); a = int.Parse(Console.ReadLine());
                        Console.Write("segundo numero que se restara: "); b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la resta es: ", a - b);
                        break;
                    case 3:
                        Console.Write("primero numero que se dividira: "); a = int.Parse(Console.ReadLine());
                        Console.Write("segundo numero que se dividira: "); b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la division es: ", b != 0 ? a / b : 0);
                        break;
                    case 4:
                        Console.Write("primero numero que se multiplicara y se usara modulo: "); a = int.Parse(Console.ReadLine());
                        Console.Write("segundo numero que se multiplicara y se usara modulo: "); b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la multiplicacion es: ", a * b);
                        Console.WriteLine("El resultado de el modulo es: ", a % b);
                        break;
                    case 5:
                        Console.WriteLine("El numero que sacaras raiz: "); a = int.Parse(Console.ReadLine());
                        double raiz = Math.Sqrt(a);
                        Console.Write("la raiz de tu numero es: " + a);
                        break;
                }
            }
        }

        public void MenuStrings()
        {
            int opcion = 0;
            while (opcion != 4)
            {
                Console.WriteLine("Menu String");
                Console.WriteLine("1. Concatenar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Formato");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Texto 1: "); string concatenacion1 = Console.ReadLine();
                        Console.Write("Texto 2: "); string concatenacion2 = Console.ReadLine();
                        Console.WriteLine("la concatenacion es: ", concatenacion1 + concatenacion2);
                        break;
                    case 2:
                        Console.Write("Texto: "); string textoBuscador = Console.ReadLine();
                        Console.Write("Buscar: "); string buscador = Console.ReadLine();
                        Console.WriteLine(textoBuscador.Contains(buscador) ? "El texto SI contiene la letra que buscaste" : "El texto NO contiene la letra que buscaste");
                        break;
                    case 3:
                        Console.Write("Escribe un texto: ");
                        string textoFormato = Console.ReadLine();
                        Console.WriteLine("Minúsculas: " + textoFormato.ToLower());
                        Console.WriteLine("Mayúsculas: " + textoFormato.ToUpper());
                        Console.WriteLine("Original: " + textoFormato);
                        break;
                }
            }
        }

        public void MenuArrays()
        {
            int opcion = 0; int[] arr = new int[0];
            while (opcion != 5)
            {
                Console.WriteLine("Menu Arrays");
                Console.WriteLine("1. Crear");
                Console.WriteLine("2. Ordenar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Agregar");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Tamaño: ");
                        int n = int.Parse(Console.ReadLine());
                        arr = new int[n];
                        for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Array.Sort(arr);
                        Console.WriteLine(string.Join(",", arr));
                        break;
                    case 3:
                        Console.Write("Número: ");
                        int x = int.Parse(Console.ReadLine());
                        int p = Array.IndexOf(arr, x);
                        Console.WriteLine(p >= 0 ? "Pos " + (p + 1) : "No");
                        break;
                    case 4:
                        Console.Write("Agregar: ");
                        int m = int.Parse(Console.ReadLine());
                        int[] nuevo = new int[arr.Length + m];
                        arr.CopyTo(nuevo, 0);
                        for (int i = arr.Length; i < nuevo.Length; i++) nuevo[i] = int.Parse(Console.ReadLine());
                        arr = nuevo;
                        break;
                }
            }
        }
    }
}