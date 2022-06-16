using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace LambdasBasics
{
    internal class Program
    {
        class Patient
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public bool Insurance { get; set; }

            public string FullName => $"{LastName}, {FirstName}";

            public Patient(string firstName, string lastName, int age, double weight, bool insurance)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Weight = weight;
                Insurance = insurance;
            }
        }

        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient("Pedro", "Lopez", 25, 74, true));
            patients.Add(new Patient("Karina", "Montalvo", 32, 57, false));
            patients.Add(new Patient("Martha", "Sanchez", 54, 85, true));
            patients.Add(new Patient("Francisco", "Vela", 35, 56, true));
            patients.Add(new Patient("Erika", "Hernandez", 76, 45, false));
            patients.Add(new Patient("Mariana", "Manjarrez", 36, 90, false));
            patients.Add(new Patient("Humberto", "Izquierdo", 61, 78, true));
            patients.Add(new Patient("Fernando", "Martinez", 18, 65, false));

            //foreach (Patient p in patients)
            //{
            //    WriteLine($"Nombre: {p.FullName,20}. Edad: {p.Age,2}, " +
            //        $"Peso: {p.Weight,2}, Asegurado: {p.Insurance,4}");
            //}

            patients.ForEach(p =>
                WriteLine($"Nombre: {p.FullName,20}. Edad: {p.Age,2}, " +
                    $"Peso: {p.Weight,2}, Asegurado: {p.Insurance,4}"));
        }
    }
}
