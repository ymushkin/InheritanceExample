using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithAbstract
{
    // ===== מחלקת אב =====
    abstract class Shape
    {
        private string id;
        private string color;
        public Shape(string id, string color)
        {
            this.id = id;
            this.color = color;
        }
        // --- תכונות משותפות ---
        public string GetColor() { return color; }
        public void SetColor(string color) { this.color = color; }
        public string GetId() { return id; }
        // --- מתודות משותפות (כאן מימוש בסיסי בלבד) ---
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public override string ToString()
        {
            return "Shape(id: " + id + ", Color: " + color + ")";
        }
    }
    // ===== Circle =====
    class Circle : Shape
    {
        private double radius;
        public Circle(string id, string color, double radius) : base(id, color)
        {
            this.radius = radius;
        }
        public double GetRadius() { return radius; }
        public void SetRadius(double radius) { this.radius = radius; }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return "Circle(Id: " + GetId() + ", Color: " + GetColor() + ", Radius: " + radius + ")";
        }
    }
    // ===== Triangle =====
    class Triangle : Shape
    {
        private double baseLength;
        private double height;
        private double heightMeetsBaseOn;
        public Triangle(string id, string color, double baseLength, double height, double heightMeetsBaseOn)
            : base(id, color)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.heightMeetsBaseOn = heightMeetsBaseOn;
        }
        public double GetBaseLength() { return baseLength; }
        public void SetBaseLength(double baseLength) { this.baseLength = baseLength; }
        public double GetHeight() { return height; }
        public void SetHeight(double height) { this.height = height; }
        public double GetHeightMeetsBaseOn() { return heightMeetsBaseOn; }
        public void SetHeightMeetsBaseOn(double value) { this.heightMeetsBaseOn = value; }
        public double GetSide1Length()
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(heightMeetsBaseOn, 2));
        }
        public double GetSide2Length()
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseLength - heightMeetsBaseOn, 2));
        }
        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
        public override double CalculatePerimeter()
        {
            return baseLength + GetSide1Length() + GetSide2Length();
        }
        public override string ToString()
        {
            return "Triangle(id: " + GetId() + ", Color: " + GetColor() +
                   ", Base: " + baseLength +
                   ", Height: " + height + ")";
        }
    }
    // ===== Rectangle =====
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(string id, string color, double length, double width) : base(id, color)
        {
            this.length = length;
            this.width = width;
        }
        public double GetLength() { return length; }
        public void SetLength(double length) { this.length = length; }
        public double GetWidth() { return width; }
        public void SetWidth(double width) { this.width = width; }
        public override double CalculateArea()
        {
            return length * width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
        public override string ToString()
        {
            return "Rectangle(id: " + GetId() + ", Color: " + GetColor() +
                   ", Length: " + length +
                   ", Width: " + width + ")";
        }
    }
    // ===== Square =====
    class Square : Shape
    {
        private double side;
        public Square(string id, string color, double side) : base(id, color)
        {
            this.side = side;
        }
        public double GetSide() { return side; }
        public void SetSide(double side) { this.side = side; }
        public override double CalculateArea()
        {
            return side * side;
        }
        public override double CalculatePerimeter()
        {
            return 4 * side;
        }
        public override string ToString()
        {
            return "Square(id: " + GetId() + ", Color: " + GetColor() + ", Side: " + side + ")";
        }
    }
    // ===== Hexagon =====
    class Hexagon : Shape
    {
        private double side;
        private double apothem;
        public Hexagon(string id, string color, double side, double apothem) : base(id, color)
        {
            this.side = side;
            this.apothem = apothem;
        }
        public double GetSide() { return side; }
        public void SetSide(double side) { this.side = side; }
        public double GetApothem() { return apothem; }
        public void SetApothem(double apothem) { this.apothem = apothem; }
        public override double CalculateArea()
        {
            return (6 * side * apothem) / 2.0;
        }
        public override double CalculatePerimeter()
        {
            return 6 * side;
        }
        public override string ToString()
        {
            return "Hexagon(id: " + GetId() + ", Color: " + GetColor() +
                   ", Side: " + side +
                   ", Apothem: " + apothem + ")";
        }
    }
}
