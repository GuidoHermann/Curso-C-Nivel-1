using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
            // que reciba un número por valor y una variable por referencia.
            // Que analice el número y escriba variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.
            int primerValor, segundoValor;
            Console.WriteLine("Ingrese un nro: ");
            primerValor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro valor: ");
            segundoValor = int.Parse(Console.ReadLine());

            positivoNegativoCero(primerValor,ref segundoValor);

            Console.WriteLine("El primero valor que ingresaste es: " + primerValor +" y su estado es de " + segundoValor);
        }

        static void positivoNegativoCero(int n1, ref int n2){
            if (n1 > 0)
            {
                // es positivo
                n2 = 1;
            }

            else if (n1 == 0)
            {
                //es cero
                n2 = 0;
            }

            else
            {
                //es negativo
                n2 = -1;
            }
            
            
        }
    }
}
