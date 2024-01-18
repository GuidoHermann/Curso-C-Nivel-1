
using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite 10 números enteros y los guarde en un vector.
           // Luego recorrer los elementos y determinar e informar cuál es el
           // valor máximo y su posición dentro del vector.

            int numero, numeroMaximo;
            int[] vectorNumero = new int[10];
            int posicionMaxima = 0;

            
            
            for (int x = 0; x < 10; x++)
            {
                
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                vectorNumero[x] = numero;
                
            }
            numeroMaximo = vectorNumero[0];
            for (int y = 0; y < 10; y++)
            {
                
                if(vectorNumero[y] > numeroMaximo)
                {

                    numeroMaximo = vectorNumero[y];
                    posicionMaxima = y + 1;
                }
            }
            Console.WriteLine("El valor maximo es " + numeroMaximo +" y su posicion dentro del vector es " + posicionMaxima);

        }
    }
}
