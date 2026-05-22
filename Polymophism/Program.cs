using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{   
    
    abstract class Shape
    {
            public abstract double Area();

            public virtual string Describe()
            {
                return GetType().Name + " Area: " + Math.Round(Area(), 2);
            }
    }

     class Circle : Shape
     {
            public double Radius;

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
     }

      class Rectangle : Shape
      {
            public double Width;
            public double Height;

            public override double Area()
            {
                return Width * Height;
            }
      }

       class Triangle : Shape
       {
            public double Base;
            public double Height;

            public override double Area()
            {
                return 0.5 * Base * Height;
            }
       }

        class Program
        {
            static void PrintReport(List<Shape> shapes)
            {
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine(shape.Describe());
                }
            }

            static void Main()
            {
                List<Shape> shapes = new List<Shape>();

                Circle circle = new Circle();
                circle.Radius = 5;

                Rectangle rectangle = new Rectangle();
                rectangle.Width = 4;
                rectangle.Height = 6;

                Triangle triangle = new Triangle();
                triangle.Base = 10;
                triangle.Height = 5;

                shapes.Add(circle);
                shapes.Add(rectangle);
                shapes.Add(triangle);

                PrintReport(shapes);

                Shape biggestShape = shapes.OrderByDescending(shape => shape.Area()).First();

                Console.WriteLine();
                Console.WriteLine("Largest Shape: "+ biggestShape.Describe());
                
            }
      }
}
