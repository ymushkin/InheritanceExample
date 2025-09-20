using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // ===== מחלקת אב =====
    class Shape
    {
        protected int id;
        protected string color;

        public Shape(int id, string color)
        {
            this.id = id;
            this.color = color;
        }
        
        public int GetId() { return id; }
        public string GetColor() { return color; }
        public void SetColor(string color) { this.color = color; }

        // --- מתודות משותפות (כאן מימוש בסיסי בלבד) ---
        public double CalculateArea()
        {
            return 0; // כל מחלקת בן תיתן מימוש משלה
        }

        public double CalculatePerimeter()
        {
            return 0; // כל מחלקת בן תיתן מימוש משלה
        }

        public override string ToString()
        {
            return "Shape(Color: " + color + ")";
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(int id, string color, double radius) : base(id, color)
        {
            this.radius = radius;
        }

        public double CalculateArea() { return Math.PI * radius * radius; }
        public double CalculatePerimeter() { return 2 * Math.PI * radius; }

        public override string ToString()
        {
            return "Circle(id: " + id + ", Color: " + color + ", Radius: " + radius + ")";
        }
    }

    class Triangle : Shape
    {
        private double baseLength;
        private double height;
        private double heightMeetsBaseOn;

        public Triangle(int id, string color, double baseLength, double height, double heightMeetsBaseOn)
            : base(id, color)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.heightMeetsBaseOn = heightMeetsBaseOn;
        }

        public double CalculateArea() { return 0.5 * baseLength * height; }
        public double GetSide1Length() { return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(heightMeetsBaseOn, 2)); }
        public double GetSide2Length() { return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseLength - heightMeetsBaseOn, 2)); }
        public double CalculatePerimeter() { return baseLength + GetSide1Length() + GetSide2Length(); }

        public override string ToString()
        {
            return "Triangle(id: " + id + ", Color: " + color +
                   ", Base: " + baseLength +
                   ", Height: " + height + ")";
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(int id, string color, double length, double width) : base(id, color)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea() { return length * width; }
        public double CalculatePerimeter() { return 2 * (length + width); }

        public override string ToString()
        {
            return "Rectangle(id: " + id + ", Color: " + color +
                   ", Length: " + length +
                   ", Width: " + width + ")";
        }
    }

    class Square : Shape
    {
        private double side;

        public Square(int id, string color, double side) : base(id, color)
        {
            this.side = side;
        }

        public double CalculateArea() { return side * side; }
        public double CalculatePerimeter() { return 4 * side; }

        public override string ToString()
        {
            return "Square(id: " + id + ", Color: " + color + ", Side: " + side + ")";
        }
    }

    class Hexagon : Shape
    {
        private double side;
        private double apothem;

        public Hexagon(int id, string color, double side, double apothem) : base(id, color)
        {
            this.side = side;
            this.apothem = apothem;
        }

        public double CalculateArea() { return (6 * side * apothem) / 2.0; }
        public double CalculatePerimeter() { return 6 * side; }

        public override string ToString()
        {
            return "Hexagon(id: " + id + ", Color: " + color +
                   ", Side: " + side + ", Apothem: " + apothem + ")";
        }
    }
}
