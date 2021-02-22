using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int LADO1, LADO2, LADO3;
            string linea;
            Console.Write("DIGITE LADO 1 :"); linea = Console.ReadLine();
            LADO1 = int.Parse(linea);
            Console.Write("DIGITE LADO 2 :"); linea = Console.ReadLine();
            LADO2 = int.Parse(linea);
            Console.Write("DIGITE LADO 3 :"); linea = Console.ReadLine();
            LADO3 = int.Parse(linea);

            if ((LADO1 == LADO2) & (LADO2 == LADO3))
            {
                Console.WriteLine("TRIÁNGULO EQUILÁTERO. TODOS IGUALES");
            }
            else
            {
                if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
                {
                    Console.WriteLine("TRIÁNGULO ESCALENO. NINGUNO IGUAL");
                }
                else
                {
                    Console.WriteLine("TRIÁNGULO ISÓSCELES. DOS IGUALES");
                }
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}