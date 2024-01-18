using System;

namespace Unidad2Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int resultado;

           Console.WriteLine("Ingrese un numero para elevarlo al Cubo:");
           num1 = int.Parse(Console.ReadLine());

           resultado = num1 * num1 * num1;

           Console.WriteLine("Su numero elevado al cubo es: " + resultado);


        }
    }
}
