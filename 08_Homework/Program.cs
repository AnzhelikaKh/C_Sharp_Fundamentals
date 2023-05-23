using System.Threading.Channels;

namespace _08_Homework
{
    public abstract class Shape : IComparable
    {
        public string name;
        public string Name { get { return name; } set { this.name = value; } }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(object? obj)
        {
            Shape? shape = obj as Shape;
            if (this.Area() > shape?.Area())
            {
                return 1;
            }
            else if (this.Area() < shape?.Area())
            {
                return -1;
            }
            else return 0;
        }
    }

    public class Circle : Shape
    {
        int radius;
        public int Radius { get; set; }

        public Circle(string name, int radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

    }
    public class Square : Shape
    {
        int side;
        public int Side { get; set; }

        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Please enter 5 names and radiuses for Circles: ");
            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                int radius = int.Parse(Console.ReadLine());
                shapes.Add(new Circle(name, radius));
            }

            Console.WriteLine("Please enter 5 names and sides for Squares: ");
            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                int side = int.Parse(Console.ReadLine());
                shapes.Add(new Square(name, side));
            }

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape name: {shape.Name}, Shape area: {shape.Area()}, Shape Perimeter: {shape.Perimeter()}");
            }

            double maxPerimeter = shapes[0].Perimeter();
            string maxName = shapes[0].Name;
            for (int i = 1; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > maxPerimeter)
                {
                    maxPerimeter = shapes[i].Perimeter();
                    maxName = shapes[i].Name;
                }
            }

            Console.WriteLine($"Max ship perimeter: {maxPerimeter}, ship name: {maxName}");

            shapes.Sort();
            Console.WriteLine("Sorted shapes: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape name: {shape.Name}, Shape area: {shape.Area()}, Shape Perimeter: {shape.Perimeter()}");
            }
        }
    }
}