using System;

namespace Unidad2Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            float promedio;

            Console.WriteLine("Ingrese la nota del Primer Parcial: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Segundo Parcial: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Tercer Parcial: ");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Tu promedio es de: " + promedio);

        }
    }
}
