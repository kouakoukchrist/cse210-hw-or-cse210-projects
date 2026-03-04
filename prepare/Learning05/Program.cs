using System;

class Program
{
    static void Main(string[] args)
    {
        Square sSquare = new Square("Blue",2);
        Console.WriteLine(sSquare.GetColor());
        Console.WriteLine(sSquare.GetArea());


        Rectangle rect = new Rectangle("Violet", 2, 5);
        Console.WriteLine(rect.GetColor());
        Console.WriteLine(rect.GetArea());       

        Circle circ = new Circle("Green", 4);
        Console.WriteLine(circ.GetColor());
        Console.WriteLine(circ.GetArea());       


        List<Shape> shape = new List<Shape>();
        shape.Add(rect);
        shape.Add(circ);
        shape.Add(sSquare);

    foreach(Shape s in shape)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }

    }
}