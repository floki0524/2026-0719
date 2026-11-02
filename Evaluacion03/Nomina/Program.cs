using System;

namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes de deducciones legales
            const double TASA_AFP = 0.0287; // 2.87%
            const double TASA_SFS = 0.0304; // 3.04%

            Console.WriteLine("=== SISTEMA DE NÓMINA ===");
            
            // Entrada de datos
            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese las horas trabajadas: ");
            double horasTrabajadas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            double pagoPorHora = double.Parse(Console.ReadLine());

            // Proceso
            double salarioBruto = horasTrabajadas * pagoPorHora;
            double montoAfp = salarioBruto * TASA_AFP;
            double montoSfs = salarioBruto * TASA_SFS;
            double totalDeducciones = montoAfp + montoSfs;
            double salarioNeto = salarioBruto - totalDeducciones;

            // Salida (Nombre en MAYÚSCULAS y montos con formato N2)
            Console.WriteLine("\n--- COMPROBANTE DE PAGO ---");
            Console.WriteLine($"Empleado: {nombre.ToUpper()}");
            Console.WriteLine($"Salario Bruto:      RD$ {salarioBruto:N2}");
            Console.WriteLine($"Deducción AFP (2.87%): RD$ {montoAfp:N2}");
            Console.WriteLine($"Deducción SFS (3.04%): RD$ {montoSfs:N2}");
            Console.WriteLine($"Salario Neto:       RD$ {salarioNeto:N2}");
        }
    }
}
