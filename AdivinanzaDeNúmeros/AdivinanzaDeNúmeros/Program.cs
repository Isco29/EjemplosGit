using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinanzaDeNúmeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 0;
            int intentoUsuario;

            Console.WriteLine("¡Bienvenido al juego de adivinanza!");
            Console.WriteLine("Adivina el número entre 1 y 100.");

            do
            {
                Console.Write("Ingresa tu intento: ");
                intentoUsuario = Convert.ToInt32(Console.ReadLine());
                intentos++;

                if (intentoUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor. ¡Inténtalo de nuevo!");
                }
                else if (intentoUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor. ¡Inténtalo de nuevo!");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                }
            } while (intentoUsuario != numeroAleatorio);
        
        }
    }
}
