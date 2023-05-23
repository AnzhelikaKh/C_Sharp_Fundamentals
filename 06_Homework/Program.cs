using System.Globalization;

namespace _06_Homework
{
    internal class Program
    {
        public static int prevNum = 0;
        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static int ReadNumber(int start, int end)
        {
            int temp = int.Parse(Console.ReadLine());
            if (temp >= start && temp <= end && temp > prevNum)
            {
                return temp;
            }
            else
            {
                throw new Exception("Number must be in the range [1...20] and number must be grater than previous");
            }

        }

        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                result = Div(a, b);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine($"The result is: {result}"); }

            Console.WriteLine("--------------");
            try
            {

                int[] numbers = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    
                    if (i != 0)
                    {
                        prevNum = numbers[i - 1];
                    }
                    numbers[i] = ReadNumber(start: 1, end: 20);
                }
            }
            catch (Exception nex)
            {
                Console.WriteLine(nex.Message);
            }
        }
    }
}