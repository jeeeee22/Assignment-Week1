using System;
using Week1ObjectOriented.Classes;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static readonly string[] Colors = { "Yellow", "Red", "Blue", "Green", "Orange" };
        private static readonly Random random = new Random();

        public static void AddColour(Shape shape)
        {
            // Assign a random color from the Colors array
            shape.Colour = Colors[random.Next(Colors.Length)];
        }

        public static void ChangeColour(Shape shape)
        {
            // Re-assign a random color from the Colors array
            shape.Colour = Colors[random.Next(Colors.Length)];
        }
    }
}
