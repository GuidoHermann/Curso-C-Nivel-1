using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio
            // si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int A, B, C, suma, producto;

            Console.WriteLine("Ingresa un nro");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro");
            C = int.Parse(Console.ReadLine());

            suma = A + B;
            producto = B * C;

            if (suma > producto)
            {
                Console.WriteLine("Es mayor");
            }else
            {
                Console.WriteLine("No es mayor");
            }
            
            

        }
    }
}
