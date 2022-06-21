using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DentalCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            int opcion = 0;
            do
            {
                Clear();
                WriteLine("**********************************");
                WriteLine("*     AGENDA DENTAL-CARE 1.0     *");
                WriteLine("*         menú principal         *");
                WriteLine("**********************************");
                WriteLine();
                WriteLine("1. Consultas");
                WriteLine("2. Citas");
                WriteLine("0. Salir");

                Write("\nElige una opcion: ");
                opcion = Convert.ToInt32(ReadLine());

                switch (opcion)
                {
                    case 0: // salir
                        WriteLine("\n¡GRACIAS POR UTILIZAR EL PROGRAMA!");
                        break;

                    case 1:
                        SubMenuConsultas();
                        break;

                    case 2:
                        SubmenuCitas();
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void SubMenuConsultas()
        {
            int opcion = 0;
            do
            {
                Clear();
                WriteLine("**********************************");
                WriteLine("*     AGENDA DENTAL-CARE 1.0     *");
                WriteLine("*       submenú consultas        *");
                WriteLine("**********************************");
                WriteLine();
                WriteLine("1. Citas por paciente");
                WriteLine("2. Citas por día");
                WriteLine("0. Volver");

                Write("\nElige una opcion: ");
                opcion = Convert.ToInt32(ReadLine());

                switch (opcion)
                {
                    case 0: // volver
                        break;

                    case 1:
                    case 2:
                        WriteLine("\n¡OPCIÓN NO IMPLEMENTADA!");
                        ReadKey();
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void SubmenuCitas()
        {
            int opcion = 0;
            do
            {
                Clear();
                WriteLine("**********************************");
                WriteLine("*     AGENDA DENTAL-CARE 1.0     *");
                WriteLine("*         submenú citas          *");
                WriteLine("**********************************");
                WriteLine();
                WriteLine("1. Agendar");
                WriteLine("2. Cancelar");
                WriteLine("0. Volver");

                Write("\nElige una opcion: ");
                opcion = Convert.ToInt32(ReadLine());

                switch (opcion)
                {
                    case 0: // volver
                        break;

                    case 1:
                    case 2:
                        WriteLine("\n¡OPCIÓN NO IMPLEMENTADA!");
                        ReadKey();
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }
    }
}
