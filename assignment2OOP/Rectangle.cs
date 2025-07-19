using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2OOP
{
    internal struct Rectangle
    {
        private double width;
        private double height;
        public double area;

        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Error: Width cannot be negative.");
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Error: Height cannot be negative.");
                }
            }
        }

 
        public double Area
        {
            get { return Width * Height; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Rectangle Information:");
            Console.WriteLine($"Rectangle Dimensions: Width = {Width}, Height = {Height}");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
