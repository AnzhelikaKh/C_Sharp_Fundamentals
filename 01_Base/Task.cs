using System;
using System.Threading;

namespace Base_01 { 

class Task
{
    static void main(string[] args)
    {
            Console.WriteLine("Task 1:");
            int a, b;
            Console.WriteLine("Enter number a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            if (b > 0)
            {
                int div = a / b;
                Console.WriteLine("a / b =" + div);
            }
            else
                Console.WriteLine("No,I can't do this!!!(Don't divide by 0)");
            //Thread.Sleep(5000);
            //Console.Clear();

            Console.WriteLine("Task 2:");

            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are " + answer);

            Console.WriteLine("Task 3:");

            Console.WriteLine("Enter three type char values: ");
            Console.WriteLine("First one: ");
            char numChar1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Second one: ");
            char numChar2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Third one: ");
            char numChar3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"You enter ({numChar1}), ({numChar2}), ({numChar3})");

            Console.WriteLine("Task 4:");
            
            Console.WriteLine("Enter two int numbers: ");

            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > 0 && number2 > 0)
            {
                Console.WriteLine("They are both positive");
            }
            else
            {
                Console.WriteLine("One fron number or both are negativ");
            }
        }
    }

}
