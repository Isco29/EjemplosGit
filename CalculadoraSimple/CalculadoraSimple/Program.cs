using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Simple");
                Console.WriteLine("------------------");
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");

                Console.Write("Ingrese el número de la operación deseada: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                    break;
                }

                double resultado = 0.0;

                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("Resultado: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("Resultado: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("Resultado: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
                        break;
                }
            }

        }
    }
}
