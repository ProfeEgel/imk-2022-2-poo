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
        static Agenda agenda;

        static void Main(string[] args)
        {
            agenda = new Agenda();

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

                    case 1: // citas por paciente
                        ConsultaCitasPorPaciente();
                        break;

                    case 2: // citas por día
                        ConsultaCitasPorDia();
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        private static void ConsultaCitasPorPaciente()
        {
            List<AppointmentWithInfo> appointments = agenda.GetCitasPorPaciente();

            Clear();
            WriteLine("**********************************");
            WriteLine("*       CITAS POR PACIENTE       *");
            WriteLine("**********************************");
            WriteLine();

            if (appointments.Count > 0)
            {
                appointments.ForEach(a =>
                    WriteLine($"{a.Patient.FullName}. " +
                              $"{a.Day.Name}. " +
                              $"{a.Time.Description}"));

                ReadKey();
            }
            else
            {
                WriteLine("¡No hay citas pendientes!");
                ReadKey();
            }
        }

        private static void ConsultaCitasPorDia()
        {
            List<Day> days = agenda.GetDays();

            Clear();
            WriteLine("**********************************");
            WriteLine("*         CITAS POR DIA          *");
            WriteLine("**********************************");
            WriteLine();

            days.ForEach(d =>
            {
                List<AppointmentWithInfo> appointments = agenda.GetCitasPorDia(d.Id);

                WriteLine($"\n********* {d.Name} *********");

                if (appointments.Count > 0)
                {
                    appointments.ForEach(a =>
                        WriteLine($"{a.Time.Description} " +
                                  $"{a.Patient.FullName}"));
                }
                else
                {
                    WriteLine("¡No hay citas!");
                }
            });

            ReadKey();
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
                        AgendarCitas();
                        break;

                    case 2:
                        CancelarCitas();
                        break;

                    default:
                        WriteLine("\n¡OPCIÓN NO VÁLIDA!");
                        ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        private static void AgendarCitas()
        {
            Clear();
            WriteLine("**********************************");
            WriteLine("*          AGENDAR CITA          *");
            WriteLine("**********************************");
            WriteLine();

            Write("ID del paciente: ");
            int patientId = Convert.ToInt32(ReadLine());
            if (agenda.ValidatePatient(patientId))
            {
                if (!agenda.HasPendingAppointment(patientId))
                {
                    List<Day> days = agenda.GetAvailableDays();

                    if (days.Count > 0)
                    {
                        WriteLine("\n******* Dias disponibles *******");
                        for (int i = 0; i < days.Count; i++)
                        {
                            WriteLine($"{i} - {days[i].Name}");
                        }

                        Write("\nElige un día: ");
                        int opcionDia = Convert.ToInt32(ReadLine());

                    }
                    else
                    {
                        WriteLine("\n¡Agenda llena: no hay dias disponibles!");
                        ReadKey();
                    }
                }
                else
                {
                    WriteLine("\n¡El paciente ya tiene una cita!");
                    ReadKey();
                }
            }
            else
            {
                WriteLine("\n¡El ID del paciente no es válido!");
                ReadKey();
            }
        }

        private static void CancelarCitas()
        {
            throw new NotImplementedException();
        }
    }
}
