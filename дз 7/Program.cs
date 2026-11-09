using System;

class Rectangle
{
    public double width;   
    public double height;  

    public double GetArea()
    {
        return width * height;
    }

    public double GetPerimeter()
    {
        return 2 * (width + height);
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        r1.width = 5;      
        r1.height = 3;     


        Rectangle r2 = new Rectangle();
        r2.width = 7.5;   
        r2.height = 4.2;   

        Console.WriteLine("Прямоугольник 1:");
        Console.WriteLine("Ширина: " + r1.width);
        Console.WriteLine("Высота: " + r1.height);
        Console.WriteLine("Площадь: " + r1.GetArea());
        Console.WriteLine("Периметр: " + r1.GetPerimeter());

        Console.WriteLine(); 

        Console.WriteLine("Прямоугольник 2:");
        Console.WriteLine("Ширина: " + r2.width);
        Console.WriteLine("Высота: " + r2.height);
        Console.WriteLine("Площадь: " + r2.GetArea());
        Console.WriteLine("Периметр: " + r2.GetPerimeter());
    }
}