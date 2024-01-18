using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros
            // separados entre ellos por ceros. Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números
            // impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, ct = 0, cip = 0, minimo, contadorOrdenados = 0;
            double porcentaje, maxP = 0, gMax = 0;
            bool banderaOrdenados;



            for (int x = 0; x < 5; x++)
            {   
                ct = 0;
                cip = 0;
                banderaOrdenados = true;
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                minimo = n;
                while (n != 0)
                {
                    ct++;
                    if (n % 2 != 0 && n > 0)
                    {
                        cip++;
                    }
                    // punto B
                    if (n <= minimo)
                    {
                        minimo = n;
                    }
                    else
                    {
                        banderaOrdenados = false; 
                    }




                    Console.WriteLine("Ingrese un nro: ");
                    n = int.Parse(Console.ReadLine());

                } // fin del while

                porcentaje = cip * 100 / ct;
                if (porcentaje > maxP)
                {
                    maxP = porcentaje;
                    gMax = x + 1;

                }

                // punto b
                if (banderaOrdenados)
                {
                    contadorOrdenados++;
                }


                
            }// fin del for

            Console.WriteLine("El grupo con mayor porcentaje de numeros impares es:" + gMax);
            Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + contadorOrdenados);
        }
    }
}
