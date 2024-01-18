using System;

namespace Unidad2Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;

            Console.WriteLine("Ingrese un numero para sumar: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero para sumar: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2 ;

            Console.WriteLine("El resultado de la suma es: " + resultado);




        }
    }
}
