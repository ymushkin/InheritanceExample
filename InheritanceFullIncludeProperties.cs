using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFullIncludeProperties
{
    // ===== מחלקת אב =====
    abstract class Shape
    {
        public Shape(string id, string color)
        {
            Id = id;
            Color = color;
        }
        // --- תכונות משותפות ---
        public string Color{ get; set; }
        public string Id { get; private set; }
        // --- מתודות משותפות (כאן מימוש בסיסי בלבד) ---
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public override string ToString()
        {
            return "Shape(id: " + Id + ", Color: " + Color + ")";
        }
    }
    // ===== Circle =====
    class Circle : Shape
    {
        public Circle(string id, string color, double radius) : base(id, color)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Radius * Radius;
        }
        public override string ToString()
        {
            return "Circle(Id: " + Id + ", Color: " + Color + ", Radius: " + Radius + ")";
        }
    }
    // ===== Triangle =====
    class Triangle : Shape
    {
        public Triangle(string id, string color, double baseLength, double height, double heightMeetsBaseOn)
            : base(id, color)
        {
            BaseLength = baseLength;
            Height = height;
            HeightMeetsBaseOn = heightMeetsBaseOn;
        }
        public double BaseLength { get; set; }
        public double Height { get; set; }
        public double HeightMeetsBaseOn { get; set; }
        public double GetSide1Length()
        {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(HeightMeetsBaseOn, 2));
        }
        public double GetSide2Length()
        {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(BaseLength - HeightMeetsBaseOn, 2));
        }
        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }
        public override double CalculatePerimeter()
        {
            return BaseLength + GetSide1Length() + GetSide2Length();
        }
        public override string ToString()
        {
            return "Triangle(id: " + Id + ", Color: " + Color +
                   ", Base: " + BaseLength +
                   ", Height: " + Height + ")";
        }
    }
    // ===== Rectangle =====
    class Rectangle : Shape
    {
        public Rectangle(string id, string color, double length, double width) : base(id, color)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
        public override string ToString()
        {
            return "Rectangle(id: " + Id + ", Color: " + Color +
                   ", Length: " + Length +
                   ", Width: " + Width + ")";
        }
    }
    // ===== Square =====
    class Square : Shape
    {
        public Square(string id, string color, double side) : base(id, color)
        {
            Side = side;
        }
        public double Side { get; set; }
        public override double CalculateArea()
        {
            return Side * Side;
        }
        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }
        public override string ToString()
        {
            return "Square(id: " + Id + ", Color: " + Color + ", Side: " + Side + ")";
        }
    }
    // ===== Hexagon =====
    class Hexagon : Shape
    {
        public double Side { get; set; }
        public double Apothem { get; set; }
        public Hexagon(string id, string color, double side, double apothem) : base(id, color)
        {
            Side = side;
            Apothem = apothem;
        }
        public override double CalculateArea()
        {
            return (6 * Side * Apothem) / 2.0;
        }
        public override double CalculatePerimeter()
        {
            return 6 * Side;
        }
        public override string ToString()
        {
            return "Hexagon(id: " + Id + ", Color: " + Color +
                   ", Side: " + Side +
                   ", Apothem: " + Apothem + ")";
        }
    }
}
