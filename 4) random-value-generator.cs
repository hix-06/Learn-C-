using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awk3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //lesson 44
            //practice: random values generator
            while (true)
            {
                System.Console.WriteLine("Please select an option:");
                System.Console.WriteLine("[1] Generate random number[2] Generate random string");
                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                    GenerateRandomNumber();
                else if (selectedOption == "2")
                    GenerateRandomString();
                else
                    System.Console.WriteLine("Invalid Option!");
                
                System.Console.WriteLine("==============");
            }
        }
        static void GenerateRandomNumber()
        {
            Random random = new Random();
            int value = random.Next(100000, 999999);
            System.Console.WriteLine($"Random Number: {value}");

        }
        private const string Buffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*()_";
        static void GenerateRandomString()
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            while (sb.Length < 16)
            {
                int randomIndex = rnd.Next(0, Buffer.Length - 1);
                sb.Append(Buffer[randomIndex]);
            }
            System.Console.WriteLine($"Random String: {sb.ToString()}");
        }
    }
}
