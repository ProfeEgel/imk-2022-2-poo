using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceOrStatic
{
    class Ejemplo
    {
        public int x;
        public static int y;

        public static void IncrementY()
        {
            //x = 10;
            y++;
        }

        public void IncrementX()
        {
            x++;
        }

        public void SetXValue(int x)
        {
            if (x < 0)
            {
                // detecta y procesa error...
            }

            this.x = x;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ejemplo.y = 10;
            Ejemplo.IncrementY();
            Console.WriteLine($"y={Ejemplo.y}");

            Ejemplo e1 = new Ejemplo();
            e1.x = 55;
            e1.IncrementX();
            Ejemplo e2 = new Ejemplo();
            e2.x = -47;
            e2.IncrementX();

            Console.WriteLine($"e1.x = {e1.x}");
            Console.WriteLine($"e2.x = {e2.x}");
        }
    }
}
