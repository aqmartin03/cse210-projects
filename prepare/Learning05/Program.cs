using System;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("Blue", 4);

        Rectangle shape2 = new Rectangle("Green", 5, 7);

        Circle shape3 = new Circle("Red", 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"This shape has a color of {color} and an area of {area}.");
        }
    }
}