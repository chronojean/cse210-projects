using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square cuadrado = new Square(5);
        Rectangle rectangulo = new Rectangle(4, 6);
        Circle circulo = new Circle(3);

        Console.WriteLine($"Area of square: {Math.Round(cuadrado.GetArea(), 2)}");
        Console.WriteLine($"Area of rectangle {Math.Round(rectangulo.GetArea(), 2)}");
        Console.WriteLine($"Area of circle {Math.Round(circulo.GetArea(), 2)}");
        Console.WriteLine();
    }
}