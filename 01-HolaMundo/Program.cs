/*
 * Nombre: Miguel Angel Polonia
 * Fecha: 16/09/2026
 * Descripción: Programa que imprime una tarjeta de presentación
 *              con nombre, matrícula, carrera y una frase personal.
 */

// Datos personales que se mostrarán en la tarjeta
string nombre = "Miguel Angel Polonia";
string matricula = "2026-0719";
string carrera = "Ingeniería en Sistemas";
string frase = "Aprendiendo a programar, un commit a la vez.";

// Se construye el marco de la tarjeta usando caracteres especiales
string borde = new string('*', 50);

// Impresión de la tarjeta de presentación en consola
Console.WriteLine(borde);
Console.WriteLine("=  Nombre:    " + nombre);
Console.WriteLine("=  Matrícula: " + matricula);
Console.WriteLine("=  Carrera:   " + carrera);
Console.WriteLine("|  " + frase);
Console.WriteLine(borde);