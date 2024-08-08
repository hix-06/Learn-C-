using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//betwise operations (|, &, ~, ^)

[Flags]
public enum WeekDays
{
    None =        0b_0000_0000, // 0,
    Saturday =     0b_0000_0001, // 1,
    Sunday =      0b_0000_0010, // 2,
    Monday =      0b_0000_0100, // 4,
    Tuesday =     0b_0000_1000, // 8,
    Wednesday =   0b_0001_0000, // 16,
    Thursday =    0b_0010_0000, // 32,
    Friday =      0b_0100_0000, // 64
}

namespace akw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //lesson 43 
            WeekDays weekend = WeekDays.Friday | WeekDays.Saturday; // (betwise or '|') mixes two enum elements 'flags' by comining their two binary values
                                 //   0b_0100_0000
                                 //   0b_0000_0001
                                 //   0b_0100_0001  
            System.Console.WriteLine(weekend);

            WeekDays w1 = WeekDays.Saturday | WeekDays.Sunday | WeekDays.Monday;
            WeekDays w2 = WeekDays.Saturday | WeekDays.Tuesday | WeekDays.Thursday;
            WeekDays w3 = WeekDays.Saturday | WeekDays.Thursday | WeekDays.Friday;

            // (betwise and '&') find common enum flags 'elements' between two variables
            System.Console.WriteLine($"common flag(s) between w1 and w2: {w1 & w2}");
            System.Console.WriteLine($"common flag(s) between w2 and w3: {w2 & w3}");

            // betwise and '&' used to check if a cerain unkown value variable in a database is containing or having a specific enum flag 'element' in it

            WeekDays fridayFlag = w3 & WeekDays.Friday;
            bool isFriday = (w3 & WeekDays.Friday) == WeekDays.Friday;
            System.Console.WriteLine($"{fridayFlag} - {isFriday}");

            WeekDays mondayFlag = w3 & WeekDays.Monday;
            bool isMonday = (w3 & WeekDays.Monday) == WeekDays.Monday;
            System.Console.WriteLine($"{mondayFlag} - {isMonday}");

            // Except '~' if u want to delete a certain flag *its a unary operator*
            System.Console.WriteLine(w1 & ~WeekDays.Saturday); // prints w1 except saturday

            // Toggle operator '^' tpggles
            w1 = w1 ^ WeekDays.Friday;  // adds friday flag to w1 since it doesnt exist originally in it
            System.Console.WriteLine(w1);
            w1 = w1 ^ WeekDays.Sunday; // removes sunday flag from w1 since it does exist originally in it
            System.Console.WriteLine(w1); 

        }
    }
}