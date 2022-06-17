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
        //static double Square(double value)
        //{
        //    return value * value;
        //}

        //static double Absolute(double value)
        //{
        //    return Math.Abs(value);
        //}

        delegate double Operation(double value);
        static double SpecialFunction(double x, double y, Operation op)
        {
            return op(x) + op(y);
        }

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

        static void PrintPatients(List<Patient> patients)
        {
            WriteLine("\n*****************************************");
            patients.ForEach(p =>
                WriteLine($"Nombre: {p.FullName,20}. Edad: {p.Age,2}, " +
                    $"Peso: {p.Weight,2}, Asegurado: {p.Insurance,4}"));
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

            Patient pf = patients.Find(p => p.Age == 35);
            WriteLine($"Nombre: {pf.FullName,20}. Edad: {pf.Age,2}, " +
                    $"Peso: {pf.Weight,2}, Asegurado: {pf.Insurance,4}");

            var f1 = patients.FindAll(p => p.Insurance);
            PrintPatients(f1);

            var f2 = patients.FindAll(p => !p.Insurance && p.Age < 50 && p.Weight > 70);
            PrintPatients(f2);

            patients.Sort((pA, pB) => pB.LastName.CompareTo(pA.LastName));
            PrintPatients(patients);

            bool e1 = patients.Exists(p => p.LastName == "Izquierdo");
            WriteLine($"\nIzquierdo está presente: {e1}");

            //foreach (Patient p in patients)
            //{
            //    WriteLine($"Nombre: {p.FullName,20}. Edad: {p.Age,2}, " +
            //        $"Peso: {p.Weight,2}, Asegurado: {p.Insurance,4}");
            //}

            /*
            //double result = SpecialFunction(5, -1, Square);
            double result = SpecialFunction(5, -1, n => n * n);
            WriteLine($"Resultado = {result}");

            //result = SpecialFunction(-5, -1, Absolute);
            result = SpecialFunction(-5, -1, n => Math.Abs(n));
            WriteLine($"Resultado = {result}");

            result = SpecialFunction(-5, 2, n => n / 2);
            WriteLine($"Resultado = {result}");
            */
        }
    }
}
