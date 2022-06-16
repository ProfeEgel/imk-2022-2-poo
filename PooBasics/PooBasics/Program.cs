using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBasics
{
    class Box
    {
        private int width;
        private int length;
        private int height;

        public int Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("width");
                }

                width = value;
            }

            get => width;
        }

        public int Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("length");
                }

                length = value;
            }

            get => length;
        }

        public int Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("height");
                }

                height = value;
            }

            get => height;
        }

        public int Volume => width * length * height;

        public Box() : this(1) {}

        public Box(int size) : this(size, size, size) {}

        public Box(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(4, 2, 3);
            //b1.Width = 4;
            //b1.Length = 2;
            //b1.Height = 3;

            //Box b2 = new Box() { Width = 5, Length = 5, Height = 5 };
            //Box b2 = new Box(5, 5, 5);
            Box b2 = new Box(5);
            Box b3 = new Box();

            Console.WriteLine($"[{b1.Width},{b1.Length},{b1.Height}]");
            Console.WriteLine($"[{b2.Width},{b2.Length},{b2.Height}]");
            Console.WriteLine($"[{b3.Width},{b3.Length},{b3.Height}]");

            // ***************************************

            List<Box> boxes = new List<Box>();
            boxes.Add(new Box() { Width = 2, Length = 1, Height = 3 });
            boxes.Add(new Box() { Width = 1, Length = 1, Height = 3 });
            boxes.Add(new Box() { Width = 3, Length = 5, Height = 1 });

            foreach (Box box in boxes)
            {
                Console.WriteLine($"[{box.Width},{box.Length},{box.Height}]");
            }

            Console.WriteLine();

            int total = 0;
            foreach (Box box in boxes)
            {
                total += box.Volume;
            }

            Console.WriteLine($"Volumen total = {total}");
        }
    }
}
