using System;

namespace ConcursoParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            // Menú principal interactivo (Unidades 5, 6 y 7)
            do
            {
                MostrarEncabezado("SEGUNDO PARCIAL - CONCURSO EN VIVO");
                Console.WriteLine("1. Evaluar Clasificación de Número (Decisiones y Ciclos)");
                Console.WriteLine("2. Calcular Operación Matemática con Validación");
                Console.WriteLine("3. Ejecutar Secuencia de Prueba (Ciclo For)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\n--- 1. CLASIFICACIÓN DE NÚMERO ---");
                            int numero = LeerEntero("Ingrese un número entero: ");
                            EvaluarNumero(numero);
                            break;

                        case 2:
                            Console.WriteLine("\n--- 2. CÁLCULO CON RETORNO ---");
                            double baseVal = LeerDouble("Ingrese la base: ");
                            double alturaVal = LeerDouble("Ingrese la altura: ");
                            double area = CalcularAreaTriangulo(baseVal, alturaVal);
                            Console.WriteLine($"El área calculada es: {area:N2}");
                            break;

                        case 3:
                            Console.WriteLine("\n--- 3. SECUENCIA CON CICLO FOR ---");
                            int limite = LeerEntero("Ingrese el límite de la secuencia: ");
                            MostrarSecuencia(limite);
                            break;

                        case 0:
                            Console.WriteLine("\nSaliendo del programa del concurso. ¡Buena suerte!");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Elija entre 0 y 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Debe ingresar un número entero válido.");
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 0);
        }

        // ==========================================
        // MÉTODOS OBLIGATORIOS (Unidad 7)
        // ==========================================

        public static void MostrarEncabezado(string titulo)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"      {titulo}      ");
            Console.WriteLine("==================================================");
        }

        // Método con parámetros y sin retorno (Usa decisiones)
        public static void EvaluarNumero(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"El número {num} es POSITIVO.");
                if (num % 2 == 0)
                    Console.WriteLine("También es un número PAR.");
                else
                    Console.WriteLine("Es un número IMPAR.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"El número {num} es NEGATIVO.");
            }
            else
            {
                Console.WriteLine("El número es CERO.");
            }
        }

        // Método con parámetros y con retorno (Calcula área)
        public static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2.0;
        }

        // Método con ciclo for
        public static void MostrarSecuencia(int n)
        {
            Console.WriteLine("Generando secuencia:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        // Métodos auxiliares de validación con TryParse (Unidad 5)
        public static int LeerEntero(string mensaje)
        {
            int valor;
            bool valido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                valido = int.TryParse(entrada, out valor);
                if (!valido)
                {
                    Console.WriteLine("Error: Entrada inválida. Ingrese un entero.");
                }
            } while (!valido);
            return valor;
        }

        public static double LeerDouble(string mensaje)
        {
            double valor;
            bool valido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                valido = double.TryParse(entrada, out valor);
                if (!valido)
                {
                    Console.WriteLine("Error: Entrada inválida. Ingrese un valor numérico.");
                }
            } while (!valido);
            return valor;
        }
    }
}
