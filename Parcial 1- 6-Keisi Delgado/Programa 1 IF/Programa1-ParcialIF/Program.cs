using System;
using System.Numerics;

//autor: Keisi Delgado
namespace Programa1
{
    class ProgramaEstudiante
    {
        static void Main(String[] args)
        {
            //Creamos e inicializamos las variables
            int CalificacionParcial1;
            int CalificacionParcial2;
            int porcentajeAsistencia;
            int nivelCurso;
            string tipo = "";

            //Pedimos los datos al usuario
            Console.Write("Ingrese la primera calificacion del parcial: ");
            if (int.TryParse(Console.ReadLine(), out CalificacionParcial1))
            {
                if (CalificacionParcial1 <= 0)
                {
                    Console.WriteLine("La nota no debe ser igual o menor a 0");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
                return;
            }

            Console.Write("Ingrese la segunda calificacion del parcial: ");
            if (int.TryParse(Console.ReadLine(), out CalificacionParcial2))
            {
                if (CalificacionParcial2 <= 0)
                {
                    Console.WriteLine("La nota no debe ser igual o menor a 0");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
                return;
            }

            Console.Write("Ingrese su porcentaje de asistencia: ");
            if (int.TryParse(Console.ReadLine(), out porcentajeAsistencia))
            {
                if (porcentajeAsistencia <= 0)
                {
                    Console.WriteLine("El porcentaje no debe ser igual o menor a 0");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
                return;
            }

            //Opciones a seleccionar
            Console.WriteLine("\nSeleccione su nivel: ");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.Write("\nNivelCurso: ");

            if (int.TryParse(Console.ReadLine(), out nivelCurso))
            {
                if (nivelCurso < 1 || nivelCurso > 3)
                {
                    Console.WriteLine("El nivel del curso seleccionado no es válido");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
                return;
            }

            //Calculamos el promedio y la bonificacion
            double promedio = (CalificacionParcial1 + CalificacionParcial2) / 2.0;
            double bonificacionAsistencia = porcentajeAsistencia * 0.05;
            double calificacionFinal = promedio + bonificacionAsistencia;

            //Verificamos si reprueba
            if (porcentajeAsistencia < 70 || promedio < 60)
            {
                Console.WriteLine("\nReprobaste. La asistencia o el promedio son bajos.");
            }
            else
            {
                Console.WriteLine("\nAprobaste. Felicidades.");
            }

            //Verificamos si es candidato a excelencia
            if (CalificacionParcial1 >= 90 && CalificacionParcial2 >= 90)
            {
                Console.WriteLine("\nFelicidades, eres candidato a excelencia.");
            }
            else
            {
                Console.WriteLine("\nNo eres candidato a excelencia.");
            }

            //Verificamos si obtiene mencion honorifica
            if (calificacionFinal >= 95)
            {
                Console.WriteLine("Tienes mencion honorifica.");
            }

            //Mostramos resultados
            Console.WriteLine("\nResultados: ");
            Console.WriteLine("Tu nivel de curso es de: " + nivelCurso);
            Console.WriteLine("Tu nota final es de: " + calificacionFinal);
            Console.WriteLine("Tu porcentaje de asistencia es de: " + porcentajeAsistencia + "%");
        }
    }
}
