using System;

namespace _08_For_Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            // 3. Menú principal con do-while + switch (1 Tablas, 2 Triángulo, 0 Salir)
            do
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("          MENÚ PRINCIPAL - S08          ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Mostrar tablas de multiplicar del 1 al 10");
                Console.WriteLine("2. Dibujar triángulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // 1. Ciclos anidados para mostrar las tablas del 1 al 10 en columnas alineadas ({valor,4})
                            Console.WriteLine("\n--- TABLAS DE MULTIPLICAR DEL 1 AL 10 ---");
                            for (int i = 1; i <= 10; i++)
                            {
                                for (int j = 1; j <= 10; j++)
                                {
                                    int resultado = i * j;
                                    // Formato de columnas alineadas requerido
                                    Console.Write($"{resultado,4}");
                                }
                                Console.WriteLine(); // Salto de línea por cada fila
                            }
                            break;

                        case 2:
                            // 2. Dibuja un triángulo de asteriscos de N filas (N ingresado por el usuario)
                            Console.WriteLine("\n--- TRIÁNGULO DE ASTERISCOS ---");
                            Console.Write("Ingrese el número de filas (N): ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                for (int i = 1; i <= n; i++)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("* ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Ingrese un número entero positivo válido.");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, elija 1, 2 o 0.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Ingrese un número entero.");
                }

            } while (opcion != 0);
        }
    }
}