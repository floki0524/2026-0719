using System;

namespace _06_Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ACTIVIDAD EN CLASE - SEMANA 06 ===");
            
            // ==========================================
            // PARTE 1: CALIFICACIÓN
            // ==========================================
            Console.WriteLine("\n--- 1. Sistema de Calificaciones ---");
            Console.Write("Ingrese una nota (0-100): ");
            string entradaNota = Console.ReadLine();

            // Validación con int.TryParse y un if tal como pide la consigna
            if (int.TryParse(entradaNota, out int nota))
            {
                if (nota >= 0 && nota <= 100)
                {
                    // Estructura if-else if-else para evaluar los rangos de notas
                    if (nota >= 90)
                    {
                        Console.WriteLine($"Calificación: {nota} -> Letra: A");
                    }
                    else if (nota >= 80)
                    {
                        Console.WriteLine($"Calificación: {nota} -> Letra: B");
                    }
                    else if (nota >= 70)
                    {
                        Console.WriteLine($"Calificación: {nota} -> Letra: C");
                    }
                    else
                    {
                        Console.WriteLine($"Calificación: {nota} -> Letra: F");
                    }
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar estrictamente entre 0 y 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Debe ingresar un número entero.");
            }

            // ==========================================
            // PARTE 2: CALCULADORA CON SWITCH
            // ==========================================
            Console.WriteLine("\n--- 2. Calculadora con Switch ---");
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Digite el número de su opción (1-4): ");
            int opcion = int.Parse(Console.ReadLine());

            // Resolución mediante switch y control de división entre cero
            switch (opcion)
            {
                case 1:
                    double suma = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {suma}");
                    break;
                case 2:
                    double resta = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resta}");
                    break;
                case 3:
                    double multiplicacion = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {multiplicacion}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        double division = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {division:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
