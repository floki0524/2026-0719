using System;

namespace _04_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar la constante de conversión de libras a kilogramos según la consigna
            const double LIBRA_A_KG = 0.453592;

            Console.WriteLine("=== CONVERSOR DE UNIDADES (ESTRUCTURA SECUENCIAL) ===");

            // 1. Pedir el peso en libras
            Console.Write("Ingrese el peso en libras (lb): ");
            double libras = double.Parse(Console.ReadLine());

            // Realizar la conversión a kilogramos
            double kilogramos = libras * LIBRA_A_KG;

            // 2. Pedir la temperatura en grados Fahrenheit
            Console.Write("Ingrese la temperatura en grados Fahrenheit (°F): ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // Realizar la conversión a Celsius usando la fórmula: (F - 32) * 5/9
            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            // Mostrar los resultados claros formateados a 2 decimales usando {valor:F2}
            Console.WriteLine("\n--- RESULTADOS DE LA CONVERSIÓN ---");
            Console.WriteLine($"Peso ingresado: {libras:F2} lb");
            Console.WriteLine($"Equivalente en kilogramos: {kilogramos:F2} kg");
            Console.WriteLine($"Temperatura ingresada: {fahrenheit:F2} °F");
            Console.WriteLine($"Equivalente en grados Celsius: {celsius:F2} °C");
        }
    }
}