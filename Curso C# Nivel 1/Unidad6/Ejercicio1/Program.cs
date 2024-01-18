using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números.
            // El mismo debe analizar y mostrar por pantalla
            // cuántos de esos números son primos.
            int n;
            int con = 0;
            int conPrimo = 0;

            for (int x = 0; x < 5; x++)
            {                   

            Console.WriteLine("Ingrese un nro");
            n = int.Parse(Console.ReadLine());
            con = 0; //este contador se reinicia aca 
            for (int y = 1; y <= n; y++)
            {
                if (n % y == 0 ){
                    con++; 
                    
                }                
                               
            }
                if (con == 2)  
                conPrimo++;
                
            }
            
                Console.WriteLine(conPrimo);

            
        }
    }
}
