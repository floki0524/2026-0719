using System;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULOS GEOMÉTRICOS ===");

            // 1. Cálculos del Círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            double circunferencia = 2 * Math.PI * radio;

            // 2. Cálculos del Triángulo Rectángulo (Teorema de Pitágoras)
            Console.Write("Ingrese el cateto A del triángulo rectángulo: ");
            double catetoA = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cateto B del triángulo rectángulo: ");
            double catetoB = double.Parse(Console.ReadLine());

            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            // Salida formateada con 2 decimales (:N2)
            Console.WriteLine("\n--- RESULTADOS GEOMÉTRICOS ---");
            Console.WriteLine($"[Círculo]");
            Console.WriteLine($"  - Área: {areaCirculo:N2}");
            Console.WriteLine($"  - Circunferencia: {circunferencia:N2}");
            Console.WriteLine($"[Triángulo Rectángulo]");
            Console.WriteLine($"  - Cateto A: {catetoA:N2}");
            Console.WriteLine($"  - Cateto B: {catetoB:N2}");
            Console.WriteLine($"  - Hipotenusa: {hipotenusa:N2}");
        }
    }
}