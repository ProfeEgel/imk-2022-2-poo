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

        //public void SetHeight(int height)
        //{
        //    if (height <= 0)
        //    {
        //        throw new ArgumentException("height");
        //    }

        //    this.height = height;
        //}

        //public int GetHeight() => height;

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

        //public int Volume
        //{
        //    get => width * length * height;
        //}

        public int Volume => width * length * height;

        //public int Volume() => width * length * height;

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
            boxes.Add(new Box() { Width = 2, Length = 1, Height = 3 });
            //boxes[0].SetHeight(3);
            //boxes[0].Height = -3;

            boxes.Add(new Box() { Width = 1, Length = 1, Height = 3 });
            //boxes[1].SetHeight(3);

            boxes.Add(new Box() { Width = 3, Length = 5, Height = 1 });
            //boxes[2].height = boxes[0].height + boxes[1].height;
            //boxes[2].SetHeight(boxes[0].GetHeight() + boxes[1].GetHeight());
            //boxes[2].Height = boxes[0].Height + boxes[1].Height;

            //for (int i = 0; i < 3; ++i)
            //{
            //    Console.WriteLine($"[{boxes[i].width},{boxes[i].length},{boxes[i].height}]");
            //}

            foreach (Box box in boxes)
            {
                //Console.WriteLine($"[{box.width},{box.length},{box.height}]");
                Console.WriteLine($"[{box.Width},{box.Length},{box.Height}]");
            }

            Console.WriteLine();

            int total = 0;
            foreach (Box box in boxes)
            {
                total += box.Volume;
            }

            //for (int i = 0; i < 3; ++i)
            //{
            //    total += boxes[i].Volume();
            //}

            Console.WriteLine($"Volumen total = {total}");
        }

        //static void Main_1(string[] args)
        //{
        //    Box box = new Box();
        //    box.width = 1;
        //    box.length = 2;
        //    box.height = 3;

        //    //int volume = box.width * box.length * box.height;
        //    //int volume = CalculateVolume(box.width, box.length, box.height);
        //    //int volume = CalculateVolume(box);
        //    //int volume = Box.CalculateVolume(box);
        //    int volume = box.Volume();
        //    Console.WriteLine($"Volume: {volume}");
        //}
    }
}
