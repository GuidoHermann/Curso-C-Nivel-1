

using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            // El programa deberá generar una cadena donde todas las ocurrencias
            // del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla.

            // Ejemplo:

            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadenaCaracter = new char[51];
            char primerCaracter, segundoCaracter;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una frase letra por letra(termina con punto)");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && indice < 50)
            {
                cadenaCaracter[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;

            }
            cadenaCaracter[indice] = '\0';

            Console.WriteLine("Ingrese UN solo caracter: ");
            primerCaracter = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro caracter");
            segundoCaracter = char.Parse(Console.ReadLine());

            indice = 0;
            while (cadenaCaracter[indice] != '\0')
            {
                if (cadenaCaracter[indice] == primerCaracter)
                {
                    cadenaCaracter[indice] = segundoCaracter;
                }
                indice++;
            }


            indice = 0;
            while (cadenaCaracter[indice] != '\0')
            {
                Console.Write(cadenaCaracter[indice]);
                indice++;
            }

        }
    }
}
