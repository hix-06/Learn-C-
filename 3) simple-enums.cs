using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Level 
{
    Low, //by defaul 0
    Medium, //by defaul 1
    High //by defaul 2
}

//Note: u can start counting from whatever u want, the rest item will be the following integers of the first one, like following:
enum Months
{
  January,    // 0
  February,   // 1
  March = 6,    // 6
  April,      // 7
  May,        // 8
  June,       // 9
  July        // 10
}

public enum Color
{
    Red,
    Green,
    Blue,
    Yellow
}

namespace akw1
{
    // u can create enum inside a class, like following:
    public class Program
    {
        public enum Gender
        {
            Male,
            Female
        }

        public static void Main(string[] argd)
        {
            //lesso 42
            Level myVar = Level.Low;   
            System.Console.WriteLine(myVar);    

            int myNum = (int) Months.April;
            Console.WriteLine(myNum);


            //print enum naems with values
            foreach (var month in Enum.GetNames(typeof(Months)))
            {
                System.Console.WriteLine($"{month} = {(int) Enum.Parse(typeof(Months), month)}");
            }

            //parse a string
            string monthName = "may";
            Months myMonth = (Months) Enum.Parse(typeof(Months), monthName, true);
            System.Console.WriteLine($"{myMonth} = {(int) myMonth}");


            //practice:
            while (true)
            {
                System.Console.WriteLine(@" Please select an option
                                       [1] Change background color \t\t [2] change foreground color");

            string option = Console.ReadLine();
            
            foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                System.Console.WriteLine($"{color}");

            System.Console.Write("Please, write color name");
            string colorName = Console.ReadLine();

            ConsoleColor selectedColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), colorName, true);
            if (option == "1")
                Console.BackgroundColor = selectedColor;
            else if (option == "2")
                Console.ForegroundColor = selectedColor;
            else
                System.Console.WriteLine("Invalis option!");
            }
        }
    }
} 
