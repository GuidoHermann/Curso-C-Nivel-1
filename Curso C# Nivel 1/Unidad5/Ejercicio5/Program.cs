using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y
            // luego emitir por pantalla
            // el máximo de los números pares y el mínimo de los números impares.

            int n = 0, max = 0, min = 0;
            int conPar = 0, conImpar= 0;
            //bool banPar = false, banImpar = false;


            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0 ){
                    //es par
                    conPar++;
                    if (conPar == 1) // if (banPar = false)
                    {
                        max = n;
                                   //banPar = true             
                    }else if(n > max){
                        max = n;
                    }

                    
                }else{
                    //es impar
                    conImpar++;
                    if (conImpar == 1)
                    {
                        min = n;
                    }else if (n < min)
                    {
                        min = n;
                    }
                }    
                   
                                                                                                         
            }
            Console.WriteLine("El mayor de los pares es" + max);
            Console.WriteLine("El menor de los impares es" + min);
            

        }
    }
}
