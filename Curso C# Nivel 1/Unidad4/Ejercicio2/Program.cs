using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..


            float litros, importeTotal, importeFinal;
            importeFinal = 0;
            Console.WriteLine("Ingrese el importe");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500){
                importeFinal = importeTotal * 0.75F;
            }
            if(litros > 300 && litros < 501){
                importeFinal = importeTotal * 0.85F;
            }
            if(litros > 100 && litros < 301){
                importeFinal = importeTotal * 0.90F;
            }
            if(litros < 101){
                importeFinal = importeTotal;
            }

            Console.WriteLine("Su importe final es de: " + importeFinal +" ARS");


        }
    }
}
