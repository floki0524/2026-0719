using System;

namespace _03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar dos números enteros al usuario
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            // Cálculos con operadores aritméticos y relacionales
            int suma = num1 + num2;
            int resta = num1 - num2;
            int producto = num1 * num2;
            
            // Validar división por cero para evitar excepciones
            double divisionReal = num2 != 0 ? (double)num1 / num2 : 0;
            int divisionEntera = num2 != 0 ? num1 / num2 : 0;
            int residuo = num2 != 0 ? num1 % num2 : 0;

            // Verificar si el primer número es par (true/false)
            bool esPar = (num1 % 2 == 0);

            // Mostrar resultados con formato e interpolación
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
            Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
            Console.WriteLine($"Producto: {num1} * {num2} = {producto}");
            
            if (num2 != 0)
            {
                Console.WriteLine($"División real: {num1} / {num2} = {divisionReal:F2}");
                Console.WriteLine($"División entera: {num1} / {num2} = {divisionEntera}");
                Console.WriteLine($"Residuo (Módulo): {num1} % {num2} = {residuo}");
            }
            else
            {
                Console.WriteLine("División y residuo: No se puede dividir entre cero.");
            }

            Console.WriteLine($"¿El primer número ({num1}) es par?: {esPar}");
        }
    }
}