
namespace Task_2;

// class Circle
// {
//     public const double PI = 3.14;
//
//     public static double CalculatorArea(double radius)
//     {
//         return PI * radius * radius;
//     }
//
//     public static double CalculatorDistance(double radius)
//     {
//         return 2 * PI * radius * radius;
//     }
// }
//
// using System;
//
// class Program
// {
//     static void Main()
//     {
//         // Trying to modify the constant value
//         Circle.PI = 3.14159;
//
//         double radius = 5;
//
//         Console.WriteLine("Area = " + Circle.CalculateArea(radius));
//         Console.WriteLine("Perimeter = " + Circle.CalculatePerimeter(radius));
//     }
// }   
// Error occurs because PI is declared as a constant using const.
// A constant value cannot be changed after initialization.
// Therefore, Circle.PI = 3.14159; gives a compilation error.

class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        double radius = 5;

        double area = Circle.CalculateArea(radius);
        double perimeter = Circle.CalculatePerimeter(radius);

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}