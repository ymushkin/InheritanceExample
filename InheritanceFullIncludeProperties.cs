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
        protected string id;
        protected string color;

        public Shape(string id, string color)
        {
            this.id = id;
            this.color = color;
        }
        // --- תכונות משותפות ---
        public string Color {
            get {return color;}
            set {color = value;}
        }

        public string Id
        {
            get { return id; }
        }
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
        double radius;
        public Circle(string id, string color, double radius) : base(id, color)
        {
            radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * radius * radius;
        }
        public override string ToString()
        {
            return "Circle(Id: " + id + ", Color: " + color + ", Radius: " + radius + ")";
        }
    }
    // ===== Triangle =====
    class Triangle : Shape
    {
        public double baseLength;
        public double height;
        public double heightMeetsBaseOn;

        public Triangle(string id, string color, double baseLength, double height, double heightMeetsBaseOn)
            : base(id, color)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.heightMeetsBaseOn = heightMeetsBaseOn;
        }
        public double BaseLength { get; set; }
        public double Height {
            get { return height; }
            set { height = value; }
        }
        public double HeightMeetsBaseOn {
            get { return heightMeetsBaseOn; }
            set { heightMeetsBaseOn = value; }
        }
        public double Side1Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(heightMeetsBaseOn, 2));
            }
        }
        public double Side2Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseLength - heightMeetsBaseOn, 2));
            }
        }
        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
        public override double CalculatePerimeter()
        {
            return baseLength + Side1Length + Side2Length;
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
