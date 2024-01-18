
using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero
            // y devuelva 1 si el número es primo o cero si no lo es.
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
            // Informar el promedio teniendo en cuenta sólo los números primos.

            int numero;
            
            int contadorTotal = 0;
            double promedio;
            int acumuladorPrimo = 0;
            
            Console.WriteLine("Ingrese un nro: ");
            numero = int.Parse(Console.ReadLine());

             while (numero != 0)
             {
                if (primo(numero) == 1)
                {
                    contadorTotal++;
                    acumuladorPrimo += numero;
                }




                Console.WriteLine("Ingrese un nro: ");
                numero = int.Parse(Console.ReadLine());
             }
            promedio = acumuladorPrimo / contadorTotal;

            Console.WriteLine("El promedio de numeros primos es de: " + promedio);

        }


        static int primo(int numeroEntero){
            int resultado;
            int contadorPrimo = 0;
            for (int x = 1; x <= numeroEntero; x++)
            {
                if (numeroEntero % x == 0)                
                    contadorPrimo++;                
            }
            if (contadorPrimo == 2)            
                resultado = 1;
            else
                resultado = 0;
            
            return resultado;
        }
    }
}
