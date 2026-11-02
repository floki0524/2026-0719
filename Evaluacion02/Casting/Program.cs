using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Pedir un número con decimales
            Console.Write("Ingrese un número con decimales (ej. 5.89): ");
            double numeroDecimal = double.Parse(Console.ReadLine());

            // Casting explícito de double a int (se trunca la parte decimal)
            int parteEntera = (int)numeroDecimal;

            Console.WriteLine("\n--- CASTING EXPLÍCITO ---");
            Console.WriteLine($"Número original (double): {numeroDecimal}");
            Console.WriteLine($"Parte entera obtenida (int): {parteEntera}");

            // 2. Demostración de casting implícito de int a double
            int edadBase = 19;
            double edadImplicita = edadBase; // Conversión automática y segura

            Console.WriteLine("\n--- CASTING IMPLÍCITO ---");
            Console.WriteLine($"Valor entero original (int): {edadBase}");
            Console.WriteLine($"Convertido automáticamente a (double): {edadImplicita}");
        }
    }
}