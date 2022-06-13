using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBasics
{
    class Box
    {
        public int width;
        public int length;
        public int height;

        public int Volume() => width * length * height;

        //public static int CalculateVolume(Box box) =>
        //    box.width* box.length* box.height;
    }

    internal class Program
    {
        //static int CalculateVolume(int width, int length, int height) =>
        //    width * length * height;

        //static int CalculateVolume(Box box) =>
        //    box.width * box.length * box.height;

        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            boxes.Add(new Box() { width = 2, length = 1, height = 3 });
            boxes.Add(new Box() { width = 1, length = 1, height = 3 });
            boxes.Add(new Box() { width = 3, length = 5, height = 1 });

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine($"[{boxes[i].width},{boxes[i].length},{boxes[i].height}]");
            }

            Console.WriteLine();

            int total = 0;
            for (int i = 0; i < 3; ++i)
            {
                total += boxes[i].Volume();
            }

            Console.WriteLine($"Volumen total = {total}");
        }

        static void Main_1(string[] args)
        {
            Box box = new Box();
            box.width = 1;
            box.length = 2;
            box.height = 3;

            //int volume = box.width * box.length * box.height;
            //int volume = CalculateVolume(box.width, box.length, box.height);
            //int volume = CalculateVolume(box);
            //int volume = Box.CalculateVolume(box);
            int volume = box.Volume();
            Console.WriteLine($"Volume: {volume}");
        }
    }
}
