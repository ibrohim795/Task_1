using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Diagonal: {rectangle.CalculateDiagonal()}");

            Circle circle = new Circle(9);

            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");




        }
    }
    class Rectangle
    {
        
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Console.WriteLine("Rectangle.");
            Width = width;
            Height = height;
        }

        public double CalculatePerimeter()
        {
            return 2*(Width + Height);
        }
        public double CalculateArea() 
        {
            return Width*Height;
        }
        public double CalculateDiagonal()
        {
            return Math.Sqrt(Width*Width + Height*Height);
        }
    }
    class Circle
    {
        public double Radius { get; set; }
        
        public Circle(double radius)

        {
            Console.WriteLine("\nCircle");
            Radius = radius;  
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }
}