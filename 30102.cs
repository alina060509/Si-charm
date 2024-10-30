// See https://aka.ms/new-console-template for more information
using System;
public interface IShare
{
    double CalculateArea();
}

public class Circle : IShare
{
    private double _radius;
    public Circle(double radius)
    {
        this._radius = radius;
    }
    public double CalculateArea()
    {
        return 3.14 * _radius * _radius;
    }
}

public class Rectangle: IShare
{
    private double len;
    private double wight;

    public Rectangle(double len, double wight)
    {
        this.len = len;
        this.wight = wight;
    }
    public double CalculateArea()
    {
        return len * wight;
    }
}
class Program
{
    static void Main()
    {
        IShare circle = new Circle(2);
        IShare rectangle= new Rectangle(2,3);
        Console.WriteLine($"площадь круга:{ circle.CalculateArea()}");
        Console.WriteLine($"площадь прям: {rectangle.CalculateArea()}");
    }
}
