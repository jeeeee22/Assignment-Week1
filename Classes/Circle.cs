using System;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        private double radius;

        public Circle(double r)
        {
            SetRadius(r);
            radius = r;
        }

        public Circle() { }

        private void SetRadius(double r)
        {
            if (r <= 0)
            {
                throw new Exception("Radius must be greater than 0");
            }

            radius = r;
        }

        public override int GetArea()
        {
            // Area of a circle is π * radius^2
            return (int)(Math.PI * radius * radius);
        }
    }
}
