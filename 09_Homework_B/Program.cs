using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_Homework_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("testFile.txt");

            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("Lines are read from file.");

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"Line number: {i}; count of symbols: {lines[i].Length}");
            }

            Console.WriteLine($"The longest line: '{lines.Where(l => l.Length == lines.Max(l2 => l2.Length)).FirstOrDefault()}'");
            Console.WriteLine($"The shortest line: '{lines.Where(l => l.Length == lines.Min(l2 => l2.Length)).FirstOrDefault()}'");

            var pattern = "^.*var.*$";
            Console.WriteLine("Lines, which consist of word 'var': ");
            for (int i = 0; i < lines.Length; i++)
            {
                if (Regex.IsMatch(lines[i], pattern))
                    Console.WriteLine(lines[i]);
            }
        }
    }
}
