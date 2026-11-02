using System;

namespace CajaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TASA_ITBIS = 0.18; // 18% de ITBIS
            double subtotal = 0;
            int cantidadProductos = 0;
            double precio = 0;

            Console.WriteLine("=== SISTEMA DE CAJA REGISTRADORA ===");
            Console.WriteLine("Ingrese el precio de los productos. Digite 0 para terminar.\n");

            do
            {
                Console.Write("Ingrese precio del producto: ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out precio))
                {
                    if (precio < 0)
                    {
                        Console.WriteLine("Error: El precio no puede ser negativo.");
                    }
                    else if (precio > 0)
                    {
                        subtotal += precio;
                        cantidadProductos++;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un valor numérico válido.");
                }

            } while (precio != 0);

            // Cálculos finales
            double itbis = subtotal * TASA_ITBIS;
            double total = subtotal + itbis;

            // Salida con formato N2
            Console.WriteLine("\n--- RESUMEN DE LA COMPRA ---");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal:           RD$ {subtotal:N2}");
            Console.WriteLine($"ITBIS (18%):        RD$ {itbis:N2}");
            Console.WriteLine($"Total a pagar:      RD$ {total:N2}");
        }
    }
}
