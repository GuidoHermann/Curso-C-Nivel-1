using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla
            // si los mismos se encuentran ordenados de forma decreciente .

            int A, B, C, D, E;

            Console.WriteLine("Ingrese un nro");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro nro");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro nro");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro nro");
            D = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro nro");
            E = int.Parse(Console.ReadLine());

            if(A > B && B > C && C > D && D > E){
                Console.WriteLine("Estan ordanos de forma decreciente");
            }else{
                Console.WriteLine("No estan ordenados");
            }


            
            

        }
    }
}
