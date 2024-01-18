using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros 
            //y que devuelva el producto de ambos. Luego hacer un programa que pida el precio
            // de un artículo y la cantidad vendida y
            // muestre por pantalla el monto total a pagar. Usar la función.

            int precio, cantidad, montoTotal;

            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de ese articulo: ");
            cantidad = int.Parse(Console.ReadLine());

            montoTotal = producto(precio, cantidad);

            Console.WriteLine("El monto total es de: " + montoTotal);


        }



        static int producto(int n1, int n2){
            int producto;
            producto = n1 * n2;
            return producto;
        }
    }
}
