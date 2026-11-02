using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar número secreto entre 1 y 100
            int numeroSecreto = Random.Shared.Next(1, 101);
            int intento = 0;
            int contadorIntentos = 0;

            Console.WriteLine("=== JUEGO: ADIVINA EL NÚMERO ===");
            Console.WriteLine("He pensado en un número entre 1 y 100. ¡Intenta adivinarlo!");

            do
            {
                Console.Write("Ingrese su suposición: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out intento))
                {
                    contadorIntentos++;

                    if (intento < numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es mayor.");
                    }
                    else if (intento > numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es menor.");
                    }
                    else
                    {
                        Console.WriteLine($"\n¡Felicidades! Adivinaste el número en {contadorIntentos} intentos.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Por favor, ingrese un número entero válido.");
                }

            } while (intento != numeroSecreto);
        }
    }
}