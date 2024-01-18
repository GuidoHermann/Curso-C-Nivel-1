using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos
            // y luego mostrar por pantalla el menor de ellos.

            int n1, n2, n3, n4;
            int menor;

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2){
                menor = n1;
            }else{
                menor = n2;
            }
            if (n3 < menor){
                menor = n3;
            }
            if( n4 < menor){
                menor = n4;
            }
            Console.WriteLine("El menor es " + menor);

        }
    }
}
