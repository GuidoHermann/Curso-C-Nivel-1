using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero
            // y devuelva 1 si es par o cero si no lo es.
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int numeros;
            int contadorPar = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                numeros = int.Parse(Console.ReadLine());
                if (par(numeros) == 1)
                {
                    contadorPar++;
                }

            }
            Console.WriteLine("La cantidad de numeros pares es: " + contadorPar);
        }


        static int par(int numeroEntero){
            int resultado;
            if (numeroEntero % 2 == 0)
            {
                //es par
                resultado = 1;
            }else{
                // es impar
                resultado = 0;
            }
            return resultado;
        }
    }
}
