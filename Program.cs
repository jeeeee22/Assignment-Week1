using Week1ObjectOriented.Classes;
using Week1ObjectOriented.Interfaces;

var shapes = new Shape[]
{
    new Square(4),
    new Circle(5),
    new Square(7),
    new Circle(3)
};

// Assign random colors to all shapes
foreach (var shape in shapes)
{
    ShapeColourHelper.AddColour(shape);
}

// Display information about each shape
foreach (var shape in shapes)
{
    Console.WriteLine($"Shape: {shape.GetType().Name}, Area: {shape.GetArea()}, Colour: {shape.Colour}");
}

Console.ReadLine();
