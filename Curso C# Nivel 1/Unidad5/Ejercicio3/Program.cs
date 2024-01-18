using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y
            // luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad = 0, mayor = 0, contador = 0, promedio;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());

                if (edad > 18)
                {
                    mayor+= edad;
                    contador++;

                }

            }
            promedio = mayor / contador;

            Console.WriteLine("El promedio es: " + promedio);

            

        }
    }
}
