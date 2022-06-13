using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOrReference
{
    internal class Program
    {
        // paso por valor de variables tipo valor
        static void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        // paso por referencia de variables tipo valor
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        class Box
        {
            public int x;
            public int y;
        }

        // paso por valor de variables tipo referencia
        static void Swap(Box a, Box b)
        {
            Box c = a;
            a = b;
            b = c;
        }

        // paso por referencia de variables tipo referencia
        static void Swap(ref Box a, ref Box b)
        {
            Box c = a;
            a = b;
            b = c;
        }

        // ESPECIAL: paso por valor de variables tipo referencia
        // Modificando el objeto y no la referencia
        static void SwapSpecial(Box a, Box b)
        {
            int c = a.x;
            a.x = b.x;
            b.x = c;

            c = a.y;
            a.y = b.y;
            b.y = c;
        }

        static void Main(string[] args)
        {
            Box a = new Box() { x = 10, y = 55 };
            Box b = new Box() { x = 73, y = 42 };

            Console.WriteLine($"a:({a.x},{a.y}), b:({b.x},{b.y})");

            SwapSpecial(a, b);

            Console.WriteLine($"a:({a.x},{a.y}), b:({b.x},{b.y})");
        }

        static void MainVal(string[] args)
        {
            int a = 10;
            int b = 55;

            Console.WriteLine($"a={a}, b={b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");
        }
    }
}
