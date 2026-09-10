using System;

// Nombre: Keisi Delgado
namespace Programa_Eventos
{
    class Program_If3
    {
        static void Main(string[] args)
        {
            // Pedimos la edad
            Console.Write("Ingrese su edad, por favor: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            // Pedimos la cantidad de boletos disponibles
            Console.Write("Ingrese la cantidad de boletos disponibles: ");
            int boletos = Convert.ToInt32(Console.ReadLine());

            // Mostramos los tipos de entradas
            Console.WriteLine("\nTipos de entradas:");
            Console.WriteLine("1. General");
            Console.WriteLine("2. VIP");
            Console.WriteLine("3. Invitado");
            Console.Write("Seleccione el tipo de entrada (1, 2, 3): ");
            int tipoEntrada = Convert.ToInt32(Console.ReadLine());

            // Verificamos el tipo de entrada
            if (tipoEntrada == 1 || tipoEntrada == 2 || tipoEntrada == 3)
            {
                // Verificamos la edad y los boletos
                if (edad >= 18 && boletos >= 1)
                {
                    Console.WriteLine("\nEntrada autorizada.");
                    Console.WriteLine($"El tipo de entrada seleccionado es: {tipoEntrada}");
                }
                else
                {
                    Console.WriteLine("\nEntrada rechazada.");
                    Console.WriteLine("Usted no cumple con las condiciones establecidas.");
                    Console.WriteLine($"El tipo de entrada seleccionado es: {tipoEntrada}");
                }
            }
            else
            {
                Console.WriteLine("\n[Error]: Opción no válida. Solo se permiten las opciones 1, 2 o 3.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}