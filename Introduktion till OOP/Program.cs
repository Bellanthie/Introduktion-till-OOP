using System;

namespace Introduktion_till_OOP
{
    // Creating a 'Circle' class
    public class Circle
    {
        // Creating a class constructor for the Circle class

        public int Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        // Method..add paranthesese in order to pass in information for later on
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Circle1: Radius={circle1.Radius}, Area={circle1.Area():F2}, Circumference={circle1.Circumference():F2}");
            Console.WriteLine($"Circle2: Radius={circle2.Radius}, Area={circle2.Area():F2}, Circumference={circle2.Circumference():F2}");
        }
    }
}

