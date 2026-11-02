using System;

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante del ITBIS (18%)
            const double TASA_ITBIS = 0.18;

            Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");

            // Entrada de datos
            Console.Write("Ingrese el nombre del producto: ");
            string producto = Console.ReadLine();

            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            double precioUnitario = double.Parse(Console.ReadLine());

            // Proceso
            double subtotal = cantidad * precioUnitario;
            double itbis = subtotal * TASA_ITBIS;
            double total = subtotal + itbis;

            // Salida con columnas alineadas usando interpolación de C#
            Console.WriteLine("\n==================================");
            Console.WriteLine("           FACTURA FISCAL         ");
            Console.WriteLine("==================================");
            Console.WriteLine($"{"Producto:",-15} {producto}");
            Console.WriteLine($"{"Cantidad:",-15} {cantidad}");
            Console.WriteLine($"{"Precio Unitario:",-15} RD$ {precioUnitario,10:N2}");
            Console.WriteLine($"{"Subtotal:",-15} RD$ {subtotal,10:N2}");
            Console.WriteLine($"{"ITBIS (18%):",-15} RD$ {itbis,10:N2}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{"TOTAL:",-15} RD$ {total,10:N2}");
            Console.WriteLine("==================================");
        }
    }
}
