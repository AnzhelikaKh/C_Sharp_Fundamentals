using System;

namespace _04_Homework
{

    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name { get { return name; } }
        public DateTime BirthYear { get { return birthYear; } }

        public Person() { }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - birthYear.Year;
            return age;
        }

        public void Input()
        {
            Console.WriteLine("Enter person`s name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter person`s birth year: ");
            int year = int.Parse(Console.ReadLine());
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
        }

        public override string ToString()
        {
            return string.Format($"Person - Name: {name}, Age: {Age()}");
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return first.name != second.name;
        }
    }
    internal class Program
    {
        public static void OutputPersons(Person[] people)
        {
            Console.WriteLine("All people: ");
            for (int i = 0; i < 6; i++)
            {
                people[i].Output();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Create 6 Persons
            Person[] people = { new Person(), new Person(), new Person(), new Person(), new Person(), new Person() };

            // Calculate Age and output data
            for (int i = 0; i < 6; i++) people[i].Input();
            OutputPersons(people);

            // Change Names for Very Young (less then 16)
            for (int i = 0; i < 6; i++) if (people[i].Age() < 16) people[i].ChangeName("Very Young");
            OutputPersons(people);

            // Find and output People with the same name
            Console.WriteLine("People with the same name: ");
            for (int i = 0; i < 6; i++)
                for (int j = i + 1; j < 6; j++)
                {
                    if (people[i] == people[j])
                    {
                        people[i].Output();
                        people[j].Output();
                        Console.WriteLine();
                    }
                }
        }
    }
}