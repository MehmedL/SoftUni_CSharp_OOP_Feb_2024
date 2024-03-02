

using Shapes;

public class StartUp
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Circle circle = new Circle(7);

        Console.WriteLine(rectangle.Draw());
        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}, Area: {rectangle.CalculateArea()}");

        Console.WriteLine();

        Console.WriteLine(circle.Draw());
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter():f2}, Area: {circle.CalculateArea():f2}");
    }
}