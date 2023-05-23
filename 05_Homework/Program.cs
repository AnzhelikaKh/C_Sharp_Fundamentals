using System.Xml.Linq;

namespace _05_Homework
{
    public interface IDeveloper : IComparable
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
         int IComparable.CompareTo(object? obj)
        {
            IDeveloper? developer = obj as IDeveloper;
            return string.Compare(this.Tool, developer?.Tool);
        }
    }

    public class Programmer : IDeveloper
    {
        string language;

        public string Tool { get { return language; } set { language = value; } }

        public void Create()
        {
            Console.WriteLine($"Programmer creates with {this.Tool}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer destroys with {this.Tool}.");
        }

        
    }
    public class Builder : IDeveloper
    {
        string tool;
        public string Tool { get { return tool; } set { tool = value; } }

        

        public void Create()
        {
            Console.WriteLine($"Builder creates with {this.Tool}.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder destroys with {this.Tool}.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer() { Tool = "abc" });
            developers.Add(new Programmer() { Tool = "hfhf" });
            developers.Add(new Programmer() { Tool = "aaaa" });
            developers.Add(new Builder() { Tool = "tool" });
            developers.Add(new Builder() { Tool = "fifa" });
            developers.Add(new Builder() { Tool = "joke" });

            foreach (var dev in developers)
            {
                dev.Create();
                dev.Destroy();
            }

            Console.WriteLine();
            Console.WriteLine("Developers sorted by tools: ");
            developers.Sort();

            foreach (var dev in developers)
            {
                Console.WriteLine(dev.Tool);
            }

        }
    }
}