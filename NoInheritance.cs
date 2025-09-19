using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoInheritance
{
    class Circle
    {
        private string id;
        private string color;
        private double radius;

        public Circle(string id, string color, double radius)
        {
            this.id = id;
            this.color = color;
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetId()
        {
            return id;
        }   

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        override public string ToString()
        {
            return $"Circle(id: {id}, Color: {color}, Radius: {radius})";
        }
    }

    class Triangle
    {
        public int id;
        private string color;
        private double baseLength;
        private double heightMeetsBaseOn;
        private double height;

        public Triangle(int id, string color, double baseLength, double height, double heightMeetsBaseOn)
        {
            this.id = id;
            this.color = color;
            this.baseLength = baseLength;
            this.height = height;
            this.heightMeetsBaseOn = heightMeetsBaseOn;
        }
        public int GetId()
        {
            return id;
        }

        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetBaseLength()
        {
            return baseLength;
        }
        public void SetBaseLength(double baseLength)
        {
            this.baseLength = baseLength;
        }

        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetHeightMeetsBaseOn()
        {
            return heightMeetsBaseOn;
        }
        public void SetHeightMeetsBaseOn(double value)
        {
            this.heightMeetsBaseOn = value;
        }

        public double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }

        public double GetSide1Length()
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(heightMeetsBaseOn, 2));
        }

        public double GetSide2Length()
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseLength - heightMeetsBaseOn, 2));
        }

        public double CalculatePerimeter()
        {
            return baseLength + GetSide1Length() + GetSide2Length();
        }

        override public string ToString()
        {
            return $"Triangle(id: {id}, Color: {color}, Base: {baseLength}, Height: {height}, Side1: {GetSide1Length()}, Side2: {GetSide2Length()})";
        }
    }

    class Rectangle
    {
        public int id;
        private string color;
        private double length;
        private double width;

        public Rectangle(int id, string color, double length, double width)
        {
            this.id = id;
            this.color = color;
            this.length = length;
            this.width = width;
        }
        public int GetId()
        {
            return id;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetLength()
        {
            return length;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }

        public double GetWidth()
        {
            return width;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        override public string ToString()
        {
            return $"Rectangle(id: {id}, Color: {color}, Length: {length}, Width: {width})";
        }
    }

    class Square
    {
        public int id;
        private string color;
        private double side;

        public Square(int id, string color, double side)
        {
            this.id = id;   
            this.color = color;
            this.side = side;
        }

        public int GetId()
        {
            return id;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetSide()
        {
            return side;
        }
        public void SetSide(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public double CalculatePerimeter()
        {
            return 4 * side;
        }

        override public string ToString()
        {
            return $"Square(id: {id}, Color: {color}, Side: {side})";
        }
    }

    class Hexagon
    {
        public int id;
        private string color;
        private double side;
        private double apothem;

        public Hexagon(int id, string color, double side, double apothem)
        {
            this.id = id;
            this.color = color;
            this.side = side;
            this.apothem = apothem;
        }
        public int GetId()
        {
            return id;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetSide()
        {
            return side;
        }
        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetApothem()
        {
            return apothem;
        }
        public void SetApothem(double apothem)
        {
            this.apothem = apothem;
        }

        public double CalculateArea()
        {
            return (6 * side * apothem) / 2;
        }

        public double CalculatePerimeter()
        {
            return 6 * side;
        }

        override public string ToString()
        {
            return $"Hexagon(id: {id}, Color: {color}, Side: {side}, Apothem: {apothem})";
        }
    }
}
