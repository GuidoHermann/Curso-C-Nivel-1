using System;

namespace TPFinal_HermannAlzogaray
{
    class Program
    {
        static void Main(string[] args)
        {
            // TP FINAL HERMANN ALZOGARAY C# NIVEL 1
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
            // A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            int numero;
            int menorPrimo = 0;
            int mayorPar = 0;
            int cantidadImpares = 0;
            bool banderaPrimo = false;
            

            Console.WriteLine("Ingrese un nro: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                
                if (numero % 2 == 0 && numero > mayorPar)// PUNTO A
                        mayorPar = numero;
                    
                if (numero % 2 != 0)//PUNTO B                    
                        cantidadImpares++;                   
                               
                if (detectorPrimo(numero)){ //PUNTO C
                    if (!banderaPrimo){
                        menorPrimo = numero;
                        banderaPrimo = true;

                        }else if (numero < menorPrimo)
                            menorPrimo = numero;
                       
                    }
                                                                      
                Console.WriteLine("Ingrese un nro: ");
                numero = int.Parse(Console.ReadLine());
            }// FIN DEL WHILE            

            if (mayorPar != 0) // PUNTO A
                Console.WriteLine("El mayor de los numeros pares es: " + mayorPar);
            else
                Console.WriteLine("No se ingresaron numeros pares");
            
            if (cantidadImpares != 0) //PUNTO B
                Console.WriteLine("La cantidad de numeros impares es: " + cantidadImpares);
            else
                Console.WriteLine("No se ingresaron numeros impares");

            if (banderaPrimo) // PUNTO C
                Console.WriteLine("El menor de los primos es: " + menorPrimo);
            else
               Console.WriteLine("No se ingresaron numeros primos");
        }

        static bool detectorPrimo(int numero){ // FUNCION PUNTO C
            int contadorPrimo = 0;
            bool primo;

            for (int x = 1; x <= numero; x++)
            {
                if (numero % x == 0)                
                    contadorPrimo++;              

            }
            if (contadorPrimo == 2)
                primo = true;
            else
                primo = false;
            
            return primo;
        }
    }
}
