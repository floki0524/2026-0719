using System;

namespace _07_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ACTIVIDAD EN CLASE - SEMANA 07 (CICLOS) ===");

            int numero = 0;
            bool esValido = false;

            // 1. Pedir un número entre 1 y 12 y validarlo con do-while (repite hasta que sea válido)
            do
            {
                Console.Write("Ingrese un número entero entre 1 y 12: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    if (numero >= 1 && numero <= 12)
                    {
                        esValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: El número debe estar estrictamente en el rango de 1 a 12. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Debe ingresar un número entero.");
                }

            } while (!esValido);

            // 2. Mostrar su tabla de multiplicar del 1 al 12 con while (usando un contador)
            int contador = 1;
            
            // 3. Acumulador para sumar todos los resultados de la tabla
            int sumaResultados = 0;

            Console.WriteLine($"\n--- Tabla de multiplicar del {numero} ---");
            while (contador <= 12)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");
                
                // Sumar al acumulador
                sumaResultados += resultado;
                
                // Incrementar el contador
                contador++;
            }

            // Mostrar el resultado del acumulador al final
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Suma total de todos los resultados: {sumaResultados}");
            Console.WriteLine("========================================");
        }
    }
}
