using System;

namespace ConsolaTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Selecciona una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Error: Debes ingresar un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularPotencia();
                        break;
                    case 2:
                        ConcatenarCadenas();
                        break;
                    case 3:
                        GenerarNumeroAleatorio();
                        break;
                    case 4:
                        CalculoDivisoin();
                        break;
                    case 5:
                        //CalcularRaiz();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                Console.WriteLine();

            } while (opcion != 0);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Calcular Potencia");
            Console.WriteLine("2. Concatenar Cadenas");
            Console.WriteLine("3. Generar Número Aleatorio");
            Console.WriteLine("4. División de Números");
            Console.WriteLine("5. Calcular Raíz Cuadrada");
            Console.WriteLine("0. Salir");
            Console.WriteLine("======================");
        }

        static void CalcularPotencia()
        {
            Console.Write("Ingresa la base: ");
            double baseNum;
            if (!double.TryParse(Console.ReadLine(), out baseNum))
            {
                Console.WriteLine("Error: Debes ingresar un número válido para la base.");
                return;
            }

            Console.Write("Ingresa el exponente: ");
            double exponente;
            if (!double.TryParse(Console.ReadLine(), out exponente))
            {
                Console.WriteLine("Error: Debes ingresar un número válido para el exponente.");
                return;
            }

            double resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine($"El resultado de {baseNum}^{exponente} es {resultado}");
        }

        static void ConcatenarCadenas()
        {
            Console.Write("Ingresa la primera cadena: ");
            string cadena1 = Console.ReadLine();
            Console.Write("Ingresa la segunda cadena: ");
            string cadena2 = Console.ReadLine();

            string resultado = cadena1 - cadena2;
            Console.WriteLine($"Concatenación de las cadenas: {resultado}");
        }

        static void GenerarNumeroAleatorio()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            Console.WriteLine($"Número aleatorio generado: {numeroAleatorio}");
        }

        static void CalculoDivision()
        {
            Console.Write("Ingresa el dividendo: ");
            double dividendo;
            if (!double.TryParse(Console.ReadLine(), out dividendo))
            {
                Console.WriteLine("Error: Debes ingresar un número válido para el dividendo.");
                return;
            }

            Console.Write("Ingresa el divisor: ");
            double divisor;
            if (!double.TryParse(Console.ReadLine(), out divisor))
            {
                Console.WriteLine("Error: El divisor debe ser un número.");
                return;
            }

            if (divisor == 0)
            {
                Console.WriteLine("Error: División por cero.");
                return;
            }

            double resultado = dividendo / divisor;
            Console.WriteLine($"El resultado de {dividendo} / {divisor} es {resultado}");
        }

        static void CalcularRaiz()
        {
            Console.Write("Ingresa un número: ");
            double numero;
            if (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error: Debes ingresar un número válido.");
                return;
            }

            double resultado = Math.Sqr(numero);
            Console.WriteLine($"La raíz cuadrada de {numero} es {resultado}");
        }
    }
}
