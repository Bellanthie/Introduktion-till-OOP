using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduktion_till_OOP
{
    internal class Circle
    {
        // Constructor that welcomes the radius as a parameter
        private double radius;

        // Parameterless constructor (default radius = 1.0)
        public Circle()
        {
            radius = 1.0;
        }

        // Constructor that receives the radius as a parameter
        public Circle (double radius)
        {
            this.radius = radius;
        }

        // Public property to get/set radius
        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        // Helper methods
        public double Area() => Math.PI * radius * radius;
        public double Circumference() => 2 * Math.PI * radius;
        //public double GetArea()
        //{
        //    return Math.PI * radius * radius;
        //}

    }
}
