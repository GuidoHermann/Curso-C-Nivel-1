using System;

namespace Unidad2Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancia;
            float velocidad;
            float tiempo;

            Console.WriteLine("Ingrese la distancia entre dos ciudades: ");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio: ");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = distancia / velocidad; 

            Console.WriteLine("El tiempo que tarda entre las dos ciudades es: " + tiempo + " Horas");


        }
    }
}
