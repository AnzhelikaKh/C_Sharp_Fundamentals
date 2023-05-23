namespace _05_Homework_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            
            for(uint i = 0; i < 7; i++)
            {
                Console.WriteLine("Please enter ID: ");
                uint ID = uint.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Name: ");
                string Name = Console.ReadLine();
                persons.Add(ID, Name);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please enter ID: ");
            uint FindNameID = uint.Parse(Console.ReadLine());
            if (persons.ContainsKey(FindNameID)) {
                Console.WriteLine($"Requested Name is: {persons[FindNameID]}");
            }
            else 
            {
                Console.WriteLine("Error! This ID doesn`t exist! :(");
            }
        }
    }
}