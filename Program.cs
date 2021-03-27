using System;

namespace A133590.Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 15.");
            Console.WriteLine("Programa que determina si un ingreso es un valor numérico.");
            Console.Write("Por favor, ingrese un número: ");
            double ingreso;
            bool exito = Double.TryParse(Console.ReadLine(), out ingreso);
            if(exito)
            {
                Console.WriteLine("El ingreso puede ser interpretado como un valor numérico.");
            }
            else
            {
                Console.WriteLine("El ingreso no puede ser interpretado como un valor numérico.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();

        }
    }
}
