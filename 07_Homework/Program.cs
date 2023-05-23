namespace _07_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("phones.txt");
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            using (StreamReader st = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = st.ReadLine()) != null)
                {
                    string[] info = line.Split(':');
                    PhoneBook.Add(info[0].Trim(), info[1].Trim());
                }
            }
            Console.WriteLine("Phone Book created from file.");

            var writePath = Path.GetFullPath("OnlyPhones.txt");
            using (StreamWriter st = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var phoneNum in PhoneBook.Values)
                {
                    st.WriteLine(phoneNum);
                }
            }
            Console.WriteLine("Phone numbers copied to a new file.");

            Console.WriteLine("Please, enter person name: ");
            string name = Console.ReadLine();
            if (PhoneBook.ContainsKey(name))
            {
                Console.WriteLine($"Requested phone number is: {PhoneBook.GetValueOrDefault(name)}");
            }
            else
            {
                Console.WriteLine("Error! This Name doesn`t exist! :(");
            }

            var newPath = Path.GetFullPath("New.txt");
            using (StreamWriter st = new StreamWriter(newPath, false, System.Text.Encoding.Default))
            {
                foreach (var phoneNum in PhoneBook.Values)
                {
                    if (phoneNum.StartsWith("+3"))
                    {
                        st.WriteLine(phoneNum);
                    }
                    else
                    {
                        st.WriteLine($"+3{phoneNum}");
                    }
                }
            }
            Console.WriteLine("Phone numbers formatted to a new file.");
        }
    }
}