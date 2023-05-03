namespace _03_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.WriteLine("Enter some text: ");
            string someText = Console.ReadLine();

            int count = 0;
            foreach (char ch in someText)
            {
                if (ch == 'a' || ch == 'o' || ch == 'i' || ch == 'e')
                    count++;
            }

            Console.WriteLine($"Count characters in the text: {count}");

            //Task 2

            Console.WriteLine("Enter the number of the month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            var year = DateTime.Today.ToString("yyyy");
            double currentYear = Convert.ToDouble(year);
            int ammount;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 11)
            {
                ammount = 31;
            }
            else if (month == 2)
            {
                if (currentYear % 4 == 0 && (currentYear % 100 != 0 || currentYear % 400 == 0))
                    ammount = 29;
                else
                    ammount = 28;
            }
            else
            {
                ammount = 30;
            }

            Console.WriteLine(ammount);

            //Task 3

            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter the number {i}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            int sum = 0;
            int prod = 1;
            int countNums = 0;
            bool getFlag = true;



            foreach (int x in nums)
            {
                if (countNums < 5)
                {
                    if (x >= 0 && getFlag == true)
                    {
                        sum = sum + x;
                    }
                    else
                        getFlag = false;
                }
                else
                {
                    if (countNums >= 5)
                    {
                        prod = prod * x;
                    }
                }
                countNums++;

                //Console.WriteLine(x);
                //Console.WriteLine(getFlag);
                //Console.WriteLine(sum);
                //Console.WriteLine(prod);
                //Console.WriteLine("****************\n");

            }

            if (getFlag == true)
                Console.WriteLine($"Sum of first 5 numbers: {sum}");
            else
                Console.WriteLine($"Prod of last 5 numbers: {prod}");
        }
    }
}
