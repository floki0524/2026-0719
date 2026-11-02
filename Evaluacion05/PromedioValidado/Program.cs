using System;

namespace PromedioValidado
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumaNotas = 0;
            int cantidadNotas = 0;
            double notaMayor = -1;
            double notaMenor = 101;
            double nota = 0;

            Console.WriteLine("=== PROMEDIO DE NOTAS VALIDADAS ===");
            Console.WriteLine("Ingrese notas válidas de 0 a 100. Escriba -1 para finalizar.\n");

            do
            {
                Console.Write("Ingrese una nota (o -1 para salir): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out nota))
                {
                    if (nota == -1)
                    {
                        break; // Terminar el ciclo si el usuario escribe -1
                    }
                    else if (nota >= 0 && nota <= 100)
                    {
                        sumaNotas += nota;
                        cantidadNotas++;

                        // Evaluar nota mayor y menor
                        if (cantidadNotas == 1)
                        {
                            notaMayor = nota;
                            notaMenor = nota;
                        }
                        else
                        {
                            if (nota > notaMayor) notaMayor = nota;
                            if (nota < notaMenor) notaMenor = nota;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar estrictamente entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Ingrese un número numérico.");
                }

            } while (true);

            // Resultados finales
            Console.WriteLine("\n--- RESULTADOS FINALES ---");
            if (cantidadNotas > 0)
            {
                double promedio = sumaNotas / cantidadNotas;
                Console.WriteLine($"Notas ingresadas válidas: {cantidadNotas}");
                Console.WriteLine($"Promedio general:        {promedio:N2}");
                Console.WriteLine($"Nota más alta:           {notaMayor:N2}");
                Console.WriteLine($"Nota más baja:           {notaMenor:N2}");
            }
            else
            {
                Console.WriteLine("No se registraron notas válidas.");
            }
        }
    }
}
