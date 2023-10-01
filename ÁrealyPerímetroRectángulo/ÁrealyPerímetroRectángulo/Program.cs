using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrealyPerímetroRectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo del Área y Perímetro de un Rectángulo");
            Console.Write("Ingrese la longitud del lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            double area = lado1 * lado2;
            double perimetro = 2 * (lado1 + lado2);

            Console.WriteLine("El área del rectángulo es: {area}");
            Console.WriteLine("El perímetro del rectángulo es: {perimetro}");
        }
    }
}
