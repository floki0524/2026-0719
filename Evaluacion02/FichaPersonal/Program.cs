using System;

namespace FichaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos personales al usuario
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
            double estatura = double.Parse(Console.ReadLine());

            Console.Write("¿Trabaja actualmente? (true/false): ");
            bool trabaja = bool.Parse(Console.ReadLine());

            // Calcular el año en que cumplirá 30 años (tomando el año actual 2026)
            int anioActual = 2026;
            int anioCumple30 = anioActual + (30 - edad);

            // Mostrar la ficha formateada con interpolación
            Console.WriteLine("\n--- FICHA PERSONAL ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura} m");
            Console.WriteLine($"¿Trabaja?: {(trabaja ? "Sí" : "No")}");
            Console.WriteLine($"Cumplirá 30 años en el año: {anioCumple30}");
        }
    }
}
