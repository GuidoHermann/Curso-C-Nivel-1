using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int A, B, resultado;

            Console.WriteLine("Ingrese un nro");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro");
            B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                resultado = A - B;
            }else if (A < B )
            {
                resultado = A * B;
            }else{
                resultado = A + B;
            }
            
            Console.WriteLine("El resultado es: " + resultado);
            
        }
    }
}
