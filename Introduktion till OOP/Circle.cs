using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduktion_till_OOP
{
    public class Circle
    {
        private double radius;

        public Circle()
        {
            this.radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double Area() => Math.PI * radius * radius;

        public double Circumference() => 2 * Math.PI * radius;

        // Remove this method if not needed, as Area() is sufficient.
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

// Move Program class outside Circle class
namespace Introduktion_till_OOP
{
    class Program
    {
        static void Main()
        {
            // Create with parameterized constructor
            Circle circle1 = new Circle(5);

            // Create using parameterless constructor plus object initializer
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Circle1: Radius={circle1.Radius}, Area={circle1.Area():F2}, Circumference={circle1.Circumference():F2}");
            Console.WriteLine($"Circle2: Radius={circle2.Radius}, Area={circle2.Area():F2}, Circumference={circle2.Circumference():F2}");
        }
    }
}
