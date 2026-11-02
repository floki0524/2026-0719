using System;

namespace SistemaTienda
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            // 1. Menú principal con do-while + switch (mínimo 4 opciones y Salir)
            do
            {
                MostrarBanner("SISTEMA DE GESTIÓN - TIENDA TECNOLÓGICA");
                Console.WriteLine("1. Calcular Subtotal de Productos");
                Console.WriteLine("2. Calcular Total con ITBIS (18%)");
                Console.WriteLine("3. Ver Catálogo de Ofertas (Ciclo For)");
                Console.WriteLine("4. Registrar Venta Rápida");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\n--- 1. CÁLCULO DE SUBTOTAL ---");
                            int cantidad = LeerEnteroValido("Ingrese la cantidad de unidades: ");
                            double precioUnitario = LeerDoubleValido("Ingrese el precio unitario (RD$): ");
                            
                            // Llamada a método con parámetros y return
                            double subtotal = CalcularSubtotal(cantidad, precioUnitario);
                            Console.WriteLine($"Subtotal calculado: RD$ {subtotal:N2}");
                            break;

                        case 2:
                            Console.WriteLine("\n--- 2. CÁLCULO DE TOTAL CON ITBIS ---");
                            double sub = LeerDoubleValido("Ingrese el monto del subtotal (RD$): ");
                            
                            // Llamada a método con parámetros y return
                            double totalFinal = CalcularTotalConItbis(sub);
                            Console.WriteLine($"Total con ITBIS (18%) aplicado: RD$ {totalFinal:N2}");
                            break;

                        case 3:
                            Console.WriteLine("\n--- 3. CATÁLOGO DE OFERTAS ---");
                            MostrarCatalogoOfertas(); // Método simple sin return pero con ciclo for
                            break;

                        case 4:
                            Console.WriteLine("\n--- 4. REGISTRO DE VENTA RÁPIDA ---");
                            string producto = LeerTextoValido("Ingrese el nombre del producto: ");
                            int cant = LeerEnteroValido("Ingrese la cantidad: ");
                            double precio = LeerDoubleValido("Ingrese el precio: ");
                            
                            double subVenta = CalcularSubtotal(cant, precio);
                            double totalVenta = CalcularTotalConItbis(subVenta);
                            
                            Console.WriteLine("\n[FACTURA GENERADA EXITOSAMENTE]");
                            Console.WriteLine($"Producto: {producto.ToUpper()}");
                            Console.WriteLine($"Cantidad: {cant}");
                            Console.WriteLine($"Total a pagar: RD$ {totalVenta:N2}");
                            break;

                        case 0:
                            Console.WriteLine("\nSaliendo del sistema. ¡Gracias por usar la aplicación!");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Por favor, seleccione un número entre 0 y 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Entrada no válida. Debe ingresar un número entero.");
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
        // MÉTODOS PROPIOS (Requisito: Mínimo 4 métodos)
        // ==========================================

        // Método 1 (Con parámetros y con return) -> Calcula el subtotal
        public static double CalcularSubtotal(int cantidad, double precioUnitario)
        {
            return cantidad * precioUnitario;
        }

        // Método 2 (Con parámetros y con return) -> Calcula el total añadiendo el 18% de ITBIS
        public static double CalcularTotalConItbis(double subtotal)
        {
            const double TASA_ITBIS = 0.18;
            return subtotal + (subtotal * TASA_ITBIS);
        }

        // Método 3 (Sin parámetros / con return implícito void) -> Muestra un banner decorativo
        public static void MostrarBanner(string titulo)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"          {titulo}          ");
            Console.WriteLine("==================================================");
        }

        // Método 4 (Sin parámetros / con return implícito void) -> Muestra ofertas usando un ciclo for
        public static void MostrarCatalogoOfertas()
        {
            string[] productosOferta = { "Teclado Mecánico", "Mouse Gamer", "Audífonos RGB", "Alfombrilla XL" };
            double[] preciosOferta = { 1500.00, 950.00, 2200.00, 450.00 };

            Console.WriteLine($"{"Ítem",-5} {"Producto",-20} {"Precio Oferta",-15}");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < productosOferta.Length; i++)
            {
                Console.WriteLine($"{i + 1,-5} {productosOferta[i],-20} RD$ {preciosOferta[i],10:N2}");
            }
        }

        // Métodos auxiliares de validación con TryParse (Requisito de robustez)
        public static int LeerEnteroValido(string mensaje)
        {
            int numero;
            bool valido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                valido = int.TryParse(entrada, out numero) && numero >= 0;
                if (!valido)
                {
                    Console.WriteLine("Error: Ingrese un número entero válido y positivo.");
                }
            } while (!valido);
            return numero;
        }

        public static double LeerDoubleValido(string mensaje)
        {
            double numero;
            bool valido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                valido = double.TryParse(entrada, out numero) && numero >= 0;
                if (!valido)
                {
                    Console.WriteLine("Error: Ingrese un valor numérico válido y positivo.");
                }
            } while (!valido);
            return numero;
        }

        public static string LeerTextoValido(string mensaje)
        {
            string texto;
            do
            {
                Console.Write(mensaje);
                texto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(texto))
                {
                    Console.WriteLine("Error: El texto no puede estar vacío.");
                }
            } while (string.IsNullOrWhiteSpace(texto));
            return texto;
        }
    }
}