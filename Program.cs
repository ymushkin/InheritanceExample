using System;
//using NoInheritance;
//using Inheritance;
//using InheritanceWithVirtual;
using InheritanceWithAbstract;

namespace ExampleRest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunNoInheritanceExample();
            RunInheritanceExample();
        }

        static void RunNoInheritanceExample()
        {
            // Circle
            Circle circle1 = new Circle("Circle1", "Red", 5);
            Circle circle2 = new Circle("Circle2", "Cyan", 7);

            Circle[] circles = new Circle[2];
            circles[0] = circle1;
            circles[1] = circle2;
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine(circles[i]);
                Console.WriteLine($"Area: {circles[i].CalculateArea()}");
                Console.WriteLine();
            }

            // Triangle
            Triangle triangle1 = new Triangle("Triangle1", "Blue", 6, 4, 2);
            Triangle triangle2 = new Triangle("Triangle2", "Orange", 10, 5, 4);
            Triangle[] triangles = new Triangle[2];
            triangles[0] = triangle1;
            triangles[1] = triangle2;
            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine(triangles[i]);
                Console.WriteLine($"Area: {triangles[i].CalculateArea()}");
                Console.WriteLine($"Perimeter: {triangles[i].CalculatePerimeter()}");
                Console.WriteLine();
            }

            // Rectangle
            Rectangle rectangle1 = new Rectangle("Rectangle1", "Green", 8, 3);
            Rectangle rectangle2 = new Rectangle("Rectangle2", "Magenta", 7, 2);

            Rectangle[] rectangles = new Rectangle[2];
            rectangles[0] = rectangle1;
            rectangles[1] = rectangle2;
            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine(rectangles[i]);
                Console.WriteLine($"Area: {rectangles[i].CalculateArea()}");
                Console.WriteLine($"Perimeter: {rectangles[i].CalculatePerimeter()}");
                Console.WriteLine();
            }

            // Square
            Square square1 = new Square("Square1", "Yellow", 4);
            Square square2 = new Square("Square2", "Brown", 6);
            Square[] squares = new Square[2];
            squares[0] = square1;
            squares[1] = square2;
            for (int i = 0; i < squares.Length; i++)
            {
                Console.WriteLine(squares[i]);
                Console.WriteLine($"Area: {squares[i].CalculateArea()}");
                Console.WriteLine($"Perimeter: {squares[i].CalculatePerimeter()}");
                Console.WriteLine();
            }

            // Hexagon
            Hexagon hexagon1 = new Hexagon("Hexagon1", "Purple", 5, 4.33);
            Hexagon hexagon2 = new Hexagon("Hexagon2", "Pink", 6, 5.2);
            Hexagon[] hexagons = new Hexagon[2];
            hexagons[0] = hexagon1;
            hexagons[1] = hexagon2;
            for (int i = 0; i < hexagons.Length; i++)
            {
                Console.WriteLine(hexagons[i]);
                Console.WriteLine($"Area: {hexagons[i].CalculateArea()}");
                Console.WriteLine($"Perimeter: {hexagons[i].CalculatePerimeter()}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
        /**/
        static void RunInheritanceExample()
        {
            Shape[] shapes = new Shape[10];

            // Circle
            Circle circle1 = new Circle("Circle1", "Red", 5);
            shapes[0] = circle1;
            Circle circle2 = new Circle("Circle2", "Cyan", 7);
            shapes[1] = circle2;

            Triangle triangle1 = new Triangle("Triangle1", "Blue", 6, 4, 2);
            shapes[2] = triangle1;
            Triangle triangle2 = new Triangle("Triangle2", "Orange", 10, 5, 4);
            shapes[3] = triangle2;

            // Rectangle
            Rectangle rectangle1 = new Rectangle("Rectangle1", "Green", 8, 3);
            shapes[4] = rectangle1;
            Rectangle rectangle2 = new Rectangle("Rectangle2", "Magenta", 7, 2);
            shapes[5] = rectangle2;

            // Square
            Square square1 = new Square("Square1", "Yellow", 4);
            shapes[6] = square1;
            Square square2 = new Square("Square2", "Brown", 6);
            shapes[7] = square2;

            // Hexagon
            Hexagon hexagon1 = new Hexagon("Hexagon1", "Purple", 5, 4.33);
            shapes[8] = hexagon1;
            Hexagon hexagon2 = new Hexagon("Hexagon2", "Pink", 6, 5.2);
            shapes[9] = hexagon2;

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i]);
                Console.WriteLine($"Area: {shapes[i].CalculateArea()}");
                Console.WriteLine($"Perimeter: {shapes[i].CalculatePerimeter()}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
        /**/
    }
}