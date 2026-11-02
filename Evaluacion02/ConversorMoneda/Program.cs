using System;

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar constante con la tasa de cambio del día (ejemplo: 1 USD = 60.0 DOP)
            const double TASA_USD = 60.0;

            // Solicitar monto en pesos
            Console.Write("Ingrese el monto en pesos dominicanos (DOP): ");
            double montoPesos = double.Parse(Console.ReadLine());

            // Realizar la conversión a dólares
            double montoDolares = montoPesos / TASA_USD;

            // Mostrar el resultado con interpolación
            Console.WriteLine("\n--- CONVERSOR DE MONEDA ---");
            Console.WriteLine($"Monto ingresado: RD$ {montoPesos:F2}");
            Console.WriteLine($"Tasa de cambio aplicada: {TASA_USD} DOP/USD");
            Console.WriteLine($"Equivalente en dólares: US$ {montoDolares:F2}");
        }
    }
}