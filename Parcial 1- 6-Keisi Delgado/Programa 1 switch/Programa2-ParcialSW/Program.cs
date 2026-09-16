namespace Programa2
{
    class Programa_DiasSemana
    {
        static void Main(String[] args)
        {
            //Creamos e inicializamos las variables
            int numero;
            string dia = "";

            //Opciones a seleccionar
            Console.WriteLine("\nSeleccione una opción");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.Write("\nnumero: ");

            string entradaTipo = Console.ReadLine();

            switch (int.TryParse(entradaTipo, out numero))
            {
                case false:
                    Console.WriteLine("Debe ingresar un número válido");
                    return;

                case true:
                    break;
            }

            //Aplicamos los días
            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;

                case 2:
                    dia = "Martes";
                    break;

                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    Console.WriteLine("El número seleccionado no es válido");
                    return;
            }


            //Mostramos resultados
            Console.WriteLine("\nResultados: ");
            Console.WriteLine("De acuerdo al número ingresado el día de la semana es: " + dia);


        }
    }
}

