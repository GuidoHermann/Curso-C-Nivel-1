using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo 
            //del importe de la compra realizada según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego 
            //muestre por pantalla el importe final con el descuento que corresponda.

            float importe;
            float montoFinal;
            float descuento18 = 0.82F;
            float descuento10 = 0.90F;

            Console.WriteLine("Ingrese el importe");
            importe = float.Parse(Console.ReadLine());

            if(importe >= 5000){
                montoFinal = importe * descuento18;
                Console.WriteLine("Su importe final es: " + montoFinal +"ARS" );
            }else if (importe >= 1000){
                montoFinal = importe * descuento10;
                Console.WriteLine("Su importe final es: " + montoFinal +"ARS");
            }else{
                montoFinal = importe;
                Console.WriteLine("Su importe final es: " + montoFinal +"ARS");
            }

        }
    }
}
