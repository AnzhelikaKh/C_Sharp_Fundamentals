using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

internal class Homework
    {
    enum HTTPError
    {
        UnauthorizedErrror = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotImplemented = 501,
        BadGatewey = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504
    };

    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {

            return ($"The dog's name: {Name}, mark: {Mark}, and age: {Age}");
        }
    }

    static void Main(string[] args)
        {
        //Task 1

        Console.WriteLine("Enter 3 float numbers: ");
        float num1F = float.Parse(Console.ReadLine());
        float num2F = float.Parse(Console.ReadLine());
        float num3F = float.Parse(Console.ReadLine());

        if ((num1F >= -5 && num1F <= 5) && (num2F >= -5 && num2F <= 5) && (num3F >= -5 && num3F <= 5))
        {
            Console.WriteLine("This number is IN range (-5...5):");
        }
        else
        {
            Console.WriteLine("This number is OUT of range (-5...5):");
        }

        //Task 2

        Console.WriteLine("Enter 3 integer numbers: ");
        int intNum1 = int.Parse(Console.ReadLine());
        int intNum2 = int.Parse(Console.ReadLine());
        int intNum3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Largest of three: " + Math.Max(intNum1, Math.Max(intNum2, intNum3)));
        Console.WriteLine("Lowest of three: " + Math.Min(intNum1, Math.Min(intNum2, intNum3)));

        //Task 3

        Console.WriteLine("Enter HTTPError: ");

        int error = int.Parse(Console.ReadLine());

        switch (error)
        {
            case 401:
                Console.WriteLine($"HTTP Error №{error}: Unauthorized Error");
                break;
            case 403:
                Console.WriteLine($"HTTP Error {error}: Forbidden");
                break;
            case 404:
                Console.WriteLine($"HTTP Error {error}: Not Found");
                break;
            case 405:
                Console.WriteLine($"HTTP Error {error}: Method Not Allowed");
                break;
            case 501:
                Console.WriteLine($"HTTP Error {error}: Not Implemented");
                break;
            case 502:
                Console.WriteLine($"HTTP Error {error}: Bad Gateway");
                break;
            case 503:
                Console.WriteLine($"HTTP Error {error}: Service Unavailable");
                break;
            case 504:
                Console.WriteLine($"HTTP Error {error}: Gateway Timeout");
                break;
            default:
                Console.WriteLine("Undefined error :(");
                break;
        }


        //Task 4

        Dog myDog;
        Console.WriteLine("Enter your dog's name: ");
        myDog.Name = Console.ReadLine();

        Console.WriteLine("Enter your dog's mark: ");
        myDog.Mark = Console.ReadLine();

        Console.WriteLine("Enter your dog's age: ");
        myDog.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(myDog);
    }

}
