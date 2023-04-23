using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Base_01
{
    internal class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1:");
            Console.WriteLine("Enter the value of the side of the square: ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            int perimeter = 4 * a;
            Console.WriteLine($"Area of a square: {area}\nPerimeter of a square: {perimeter}");

            //***********************

            Console.WriteLine("TASK 2:");
            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you are {age} years old ");

            //***********************

            Console.WriteLine("TASK 3:");
            Console.WriteLine("Enter radius of a circle: ");
            double r = double.Parse(Console.ReadLine());
            double length = 2 * Math.PI * r;
            double area2 = Math.PI * r * r;
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Length: {length}\nArea: {area2}\nVolume: {volume}");
            
            

        }
    }
}
