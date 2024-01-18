using System;

namespace Ejercicio3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char letraActual;
            char letraNueva;

            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("La cadena nueva es: ");
            Console.Write(frase);
        }
    }
}
