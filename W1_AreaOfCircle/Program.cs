using System;

namespace W1_AreaOfCircle
{
    class Program
    {
        static void Main()
        {
            var circle = new Circle(2.5);
            var circleArea = circle.GetArea();
            Console.WriteLine($"The area of the circle is {circleArea}");
        }
    }

    public class Circle
    {
        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Properties
        public double Radius{ get; set; }
        public const double Pi = 3.14;
        public double Diameter { get; set; }
        public double Area { get; set; }
        
        // Methods
        public double GetArea()
        {
            Diameter = Radius * 2;
            Area = Math.Round(Diameter * Pi, 2);
            return Area;
        }
    }
}