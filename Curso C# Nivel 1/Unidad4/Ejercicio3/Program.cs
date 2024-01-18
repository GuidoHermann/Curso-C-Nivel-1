using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

            //                 i5 (1)	      i7 (2)	   i9 (3)
            //8  RAM (1)	   USD 800	     USD 900      USD 1200
            //16 RAM (2)       USD 900	     USD 1000     USD 1400
            //32 RAM (3)       USD 1000      USD 1400     USD 2000

            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea,
            //lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM,
            //y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

            char procesador, ram, disco;
            int precio;
            precio = 0;


            Console.WriteLine("Ingrese 1 para i5");
            Console.WriteLine("Ingrese 2 para i7");
            Console.WriteLine("Ingrese 3 para i9");
            procesador = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 para 8RAM");
            Console.WriteLine("Ingrese 2 para 16RAM");
            Console.WriteLine("Ingrese 3 para 32RAM");
            ram = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 para extender el disco a 1TB");
            Console.WriteLine("Ingrese 0 para dejar el disco de 500GB");
            disco = char.Parse(Console.ReadLine());


            switch (procesador)
            {   case '1':
                    
                    switch (ram)
                    {
                        case '1':
                            precio+= 800;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        case '2':
                            precio+= 900;
                                switch(disco){
                                    case '1':
                                        precio+= 300;
                                        break;
                                    case '0':
                                        
                                        break;
                                    default:
                                        Console.WriteLine("Ingrese una opcion valida para el disco");
                                        break;
                                }
                            break;
                        case '3':
                            precio+= 1000;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break; 
                            }
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida para la RAM");
                            break;
                    }
                    break;
                case '2':
                    
                    switch(ram)
                    {
                        case '1':
                            precio+= 900;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        case '2':
                            precio+= 1000;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        case '3':
                            precio+= 1400;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida para ram");
                            break;
                    }
                    break;
                case '3':
                    
                    switch(ram)
                    {
                        case '1':
                            precio+= 1200;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        case '2':
                            precio+= 1400;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '2':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        case '3':
                            precio+= 2000;
                            switch(disco){
                                case '1':
                                    precio+= 300;
                                    break;
                                case '0':
                                    
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opcion valida para el disco");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Ingresae una opcion valida para la ram");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("No ingresaste una opcion valida para el procesador.");
                    break;
            }

            Console.WriteLine("El precio final es de: " + precio + " USD");

            
        }
    }
}
