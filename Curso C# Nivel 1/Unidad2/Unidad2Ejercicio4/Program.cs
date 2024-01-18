using System;

namespace Unidad2Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
            //más una comisión del 5% sobre el total facturado por cada empleado.
            // Hacer un programa para ingresar el total facturado por un empleado y
            // que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            // tengo que calcular la comision sobre el total facturado


            float ComisionFinal;
            float SueldoFijo;
            float TotalFacturado;
            float Comision;
            float SueldoFinal;
            Comision = 1.05F;
            SueldoFijo = 15000;


            Console.WriteLine("Ingresar total facturado por empleado: ");
            TotalFacturado = float.Parse(Console.ReadLine());
            ComisionFinal = TotalFacturado * Comision - TotalFacturado;
            SueldoFinal = SueldoFijo + ComisionFinal;
            Console.WriteLine(ComisionFinal);
            Console.WriteLine("Tu sueldo de este mes es: " + SueldoFinal +" ARS");
            


        }
    }
}
