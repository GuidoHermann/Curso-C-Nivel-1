﻿using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla
            // “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero”
            // si el número es igual a cero.

            int n1;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            if(n1 > 0){
                Console.WriteLine("Es positivo");
            }else if(n1 == 0){
                Console.WriteLine("Es cero");
            }else{
                Console.WriteLine("Es negativo");
            }


        }
    }
}
