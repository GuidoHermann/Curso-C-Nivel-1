using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite 10  números enteros y los guarde en un vector.
           // Luego recorrer ese vector para calcular el promedio.
           // Mostrar por pantalla los valores que son mayores al promedio.


            int[] vectorNumeros = new int[10];
            int acumuladorVector = 0;
            int contadorVector = 0;
            double promedio;
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                vectorNumeros[x] = int.Parse(Console.ReadLine());
                
            }

            for (int x = 0; x < 10; x++)
            {
                acumuladorVector += vectorNumeros[x];
                contadorVector ++;

            }

            promedio = acumuladorVector / contadorVector;
            
            for (int x = 0; x < 10; x++)
            {
                if(vectorNumeros[x] > promedio)
                {
                    Console.WriteLine("Los numeros mayores al promedio son: " + vectorNumeros[x]);
                    
                }
            }


        }
    }
}
