using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DentalCare
{
    internal class Agenda
    {
        private List<Day> days;
        private List<Time> times;
        private List<Schedule> schedules;
        private List<Patient> patients;
        private List<Appointment> appointments;

        public Agenda()
        {
            days = EasyFile<Day>.LoadDataFromFile("days.txt",
                    tokens => new Day(Convert.ToInt32(tokens[0]),
                                      tokens[1]));

            times = EasyFile<Time>.LoadDataFromFile("time.txt",
                    tokens => new Time(Convert.ToInt32(tokens[0]),
                                       tokens[1]));

            schedules = EasyFile<Schedule>.LoadDataFromFile("schedule.txt",
                    tokens => new Schedule(Convert.ToInt32(tokens[0]),
                                           Convert.ToInt32(tokens[1])));

            patients = EasyFile<Patient>.LoadDataFromFile("patients.txt",
                    tokens => new Patient(Convert.ToInt32(tokens[0]),
                                          tokens[1],
                                          tokens[2]));

            appointments = EasyFile<Appointment>.LoadDataFromFile("appointments.txt",
                    tokens => new Appointment(Convert.ToInt32(tokens[0]),
                                              Convert.ToInt32(tokens[1]),
                                              Convert.ToInt32(tokens[2])));
        }

        public List<AppointmentWithInfo> GetCitasPorPaciente()
        {
            List<AppointmentWithInfo> awi = new List<AppointmentWithInfo>();

            appointments.ForEach(a =>
                awi.Add(new AppointmentWithInfo(
                           patients.Find(p => p.Id == a.PatientId),
                           days.Find(d => d.Id == a.DayId),
                           times.Find(t => t.Id == a.TimeId))));

            awi.Sort((a, b) => a.Patient.LastName.CompareTo(b.Patient.LastName));

            return awi;
        }

        public List<Day> GetDays() => new List<Day>(days);

        public List<AppointmentWithInfo> GetCitasPorDia(int dayId)
        {
            List<AppointmentWithInfo> awi = new List<AppointmentWithInfo>();

            appointments.FindAll(a => a.DayId == dayId).ForEach(a =>
                awi.Add(new AppointmentWithInfo(
                           patients.Find(p => p.Id == a.PatientId),
                           days.Find(d => d.Id == a.DayId),
                           times.Find(t => t.Id == a.TimeId))));

            awi.Sort((a, b) => a.Time.Id.CompareTo(b.Time.Id));

            return awi;
        }

        public bool ValidatePatient(int patientId) =>
            patients.Exists(p => p.Id == patientId);

        public bool HasPendingAppointment(int patientId) =>
            appointments.Exists(a => a.PatientId == patientId);

        public List<Day> GetAvailableDays()
        {
            List<Day> availableDays = new List<Day>();
            days.ForEach(d =>
            {
                if (schedules.Exists(sch => sch.DayId == d.Id))
                {
                    if (schedules.FindAll(sch => sch.DayId == d.Id).Count >
                        appointments.FindAll(a => a.DayId == d.Id).Count)
                    {
                        availableDays.Add(d);
                    }

                }
            }
            );

            return availableDays;
        }
    }
}
