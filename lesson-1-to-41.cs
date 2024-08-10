using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using myConsole.Data;
using myConsole.Data.Models;
using System.Xml.XPath;
using System.Runtime.CompilerServices;

namespace myConsole
{
    internal class Program {
    public const string MyConstantString = "wow";  // a const datatype must be premptive, its declared outside main method like u had seen, it must ne initialized on declaration
    public static void Main(string[] args)
    {
    //lesson 1

    Console.Title = "ConsoleApp";
    Console.WriteLine("Hello, World!");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Heloo, there!");

    //lesson 2

    string helloToPrint = "Hello, world";
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(helloToPrint);
    }

    //lesson 3

    bool isAlive = false;
    Console.WriteLine($"is alive = {isAlive}");
    bool boolOne = false, boolTwo = false;
    bool resultOne = boolOne && boolTwo;
    bool resultTwo = boolOne || boolTwo;
    Console.WriteLine($"result = {resultOne}, result two = {resultTwo}");
    bool notBoolOne = !boolOne;
    Console.WriteLine(notBoolOne);
    bool resultThree = boolOne ^ boolTwo;
    Console.WriteLine(resultThree);

    //lesson 4

    Console.WriteLine("Write any character(s) then press enter");
    int c1 = Console.Read();
    int c2 = Console.Read();
    int c3 = Console.Read();
    Console.WriteLine($"{c1}\n{c2}\n{c3}");

    char c = 'A';
    Console.WriteLine(c);
    int asc = (int)c;
    Console.WriteLine($"ASCI is {asc}");

    bool isDigit = char.IsDigit('A');
    bool isDigit2 = char.IsDigit('1');
    bool isLetter = char.IsLetter('A');
    bool isLetter2 = char.IsLetter('1');


    bool isUpperASCIEqualLowerASCI = (int)'A' == (int)'a';
    Console.WriteLine(isUpperASCIEqualLowerASCI);

    // print ASCI from A-Z and from 1-9

    int[] s2 = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    char[] s = new char[26];
    s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    foreach(char a in s)
    {
        int asci = (int)a;
        Console.WriteLine(asci);
    }

    foreach(int a in s2)
    {
        int ascii = (int)a;
        Console.WriteLine(ascii);
    }

    //lesson 5

    Console.WriteLine("Hello, \t world");
    Console.WriteLine("Hello, \\t world");
    Console.WriteLine("Hello, \\t\t world");
    Console.WriteLine("Hello, \\t\\t world");

    string hello = "Hello";
    string world = "world";
    string helloWorld = hello + world;
    Console.WriteLine($"{helloWorld}");

    string specials = @"i \t love \t you \n so much";
    Console.WriteLine($"{specials}");

    string specials2 = @"hello
                         there
                         how u
                         doin";
    Console.WriteLine(specials2);

    string name = "Mohamed";
    Console.WriteLine($"hello {name} \n how are u doing?");

    //lesson 6
    
    string fullName;
    Console.Write("Please enter your full name");
    fullName = Console.ReadLine();
    Console.WriteLine($"Hello, {fullName}");

    int length = fullName.Length;
    Console.WriteLine(length);

    Console.WriteLine($"upper: {fullName.ToUpper()} lower: {fullName.ToLower()}");

    bool isStartingWithM = fullName.StartsWith("M");
    Console.WriteLine(isStartingWithM);
    bool isStartingWithm = fullName.StartsWith("m");
    Console.WriteLine(isStartingWithm);

    bool isStartingWithSomeStuff = fullName.StartsWith("MOH"); 
    Console.WriteLine(isStartingWithSomeStuff);
    bool isStartingWithSomeStuff2 = fullName.StartsWith("MOH", StringComparison.OrdinalIgnoreCase);
    Console.WriteLine(isStartingWithSomeStuff2);
    bool endsWithSomeStuff3 = fullName.EndsWith("ED", StringComparison.OrdinalIgnoreCase);
    Console.WriteLine(endsWithSomeStuff3);

    bool contains = fullName.Contains("am");
    Console.WriteLine(contains);
    bool contains2 = fullName.Contains("AM");
    Console.WriteLine(contains2);
    bool contains3 = fullName.Contains("AM", StringComparison.OrdinalIgnoreCase);
    Console.WriteLine(contains3);

    Console.WriteLine($" index of a is {fullName.IndexOf("a")}");
    Console.WriteLine($" index of mo is {fullName.IndexOf("mo")}");
    Console.WriteLine($" index of x is {fullName.IndexOf("x")}");
    Console.WriteLine($" index of H is {fullName.IndexOf("H")}");
    Console.WriteLine($" index of H -with ignoring char case- is {fullName.IndexOf("H", StringComparison.OrdinalIgnoreCase)}");

    Console.WriteLine($" index of m is {fullName.LastIndexOf("m")}");
    Console.WriteLine($" index of M is {fullName.LastIndexOf("M", StringComparison.OrdinalIgnoreCase)}");

    Console.WriteLine($"{fullName.Replace("fawzy", "mohamed", StringComparison.OrdinalIgnoreCase)}"); 

    // task: take original string, value to replace and value to replace with.. then print the new string

    string originalString = "", oldValue = "", newValue = "";

    Console.WriteLine("Enter the original \"full\" string");
    originalString = Console.ReadLine();
    Console.WriteLine("Enter value you want to replace");
    oldValue = Console.ReadLine();
    Console.WriteLine("Enter new value to replace old with");
    newValue = Console.ReadLine();

    Console.WriteLine($"New string is: {originalString.Replace(oldValue, newValue, StringComparison.OrdinalIgnoreCase)}"); 

    //lesson 7

    //int int1 = 0;
    //int int2 = 50;
    //int int3 = -50;
    // u-> unsigned
    //uint uint1 = 0;
    //uint uint2 = 50;
    //uint uint3 = -50; // NOT ALLOWED !!

    Console.WriteLine($"int memory size = {sizeof(int)}");
    Console.WriteLine($"uint memory size = {sizeof(uint)}");
    Console.WriteLine("\n");
    Console.WriteLine($"int minimum value = {int.MinValue}");
    Console.WriteLine($"uint minimum value = {uint.MinValue}");
    Console.WriteLine("\n");
    Console.WriteLine($"int maximum value = {int.MaxValue}");
    Console.WriteLine($"uint maximum value = {uint.MaxValue}");
    Console.WriteLine("\n");

    //short: 2 bytes 
    // short & ushort .. long and ulong : SAME As int
    //long: 8 bytes

    Console.WriteLine($"long memory size = {sizeof(long)}");
    Console.WriteLine($"ulong memory size = {sizeof(ulong)}");
    Console.WriteLine("\n");
    Console.WriteLine($"long minimum value = {long.MinValue}");
    Console.WriteLine($"ulong minimum value = {ulong.MinValue}");
    Console.WriteLine("\n");
    Console.WriteLine($"long maximum value = {long.MaxValue}");
    Console.WriteLine($"ulong maximum value = {ulong.MaxValue}");
    Console.WriteLine("\n");

    float number = 1.1234567f;           // max 7 digits of precision
    double number2 = 1.1234567895678901; // max 15-16 digits of precision
    Console.WriteLine($"float: {number} \n double: {number2} \n");

    Console.WriteLine($"float size: {sizeof(float)} \n minimum float: {float.MinValue} maximum float {float.MaxValue} \n");
    Console.WriteLine($"double size: {sizeof(double)} \n minimum double: {double.MinValue} maximum double {double.MaxValue} \n");

    //lesson 8

    int x = 25, y = 10;

    Console.WriteLine($"{x} + {y} = {x+y}");
    Console.WriteLine($"{x} - {y} = {x-y}");
    Console.WriteLine($"{x} * {y} = {x*y}");
    Console.WriteLine($"{x} / {y} = {(float)x/y}"); // 25/10 = 2 as int ,so type cast it as float
    Console.WriteLine($"{x} % {y} = {x%y}");

    Console.WriteLine("\n");
    
    var n = 12 / 3;              // var: implicit datatype
    Console.WriteLine(n.GetType());

    //lesson 9

    Console.WriteLine($"50*(10+4): {50 * (10 + 4)}");
    Console.WriteLine($"40/(10-6): {40 / (10 - 6)}"); 

    //lesson 10

    int x = 10;
    x += 5;
    Console.WriteLine(x);
    x -= 3;
    Console.WriteLine(x);
    x /= 2;
    Console.WriteLine(x);
    x *= 3;
    Console.WriteLine(x);
    x %= 5;
    Console.WriteLine(x);

    int y, z;
    z = y = x;
    Console.WriteLine($"{y} {z}");

    //lesson 11

    int x = 5;
    Console.WriteLine(++x); //pre-increament
    Console.WriteLine(x);
    int y = 7;
    Console.WriteLine(y++); //post-increament
    Console.WriteLine(y);

    Console.WriteLine(--x);
    Console.WriteLine(y--);
    Console.WriteLine(y);

    int a = 5, b = 7;

    //case 1: pre increasement first then * or /
    Console.WriteLine(5 * ++a);
    Console.WriteLine(a);

    //case 2: post incresement treated as normal + or - "after * or /"
    Console.WriteLine(3 * b++);
    Console.WriteLine(b);

    //lesson 12

    int x = 5;
    Console.WriteLine($"Is x == 5 ? {x == 5}");
    Console.WriteLine($"Is x == 10 ? {x == 10}");

    Console.WriteLine($"Is x not equal 5 ? {x != 5}");
    Console.WriteLine($"Is x not equal 10 ? {x != 10}");

    Console.WriteLine($"is x > 5 ? {x > 5}");
    Console.WriteLine($"is x > 3 ? {x > 3}");

    Console.WriteLine($"is x < 5 ? {x < 5}");
    Console.WriteLine($"is x less than 10 ? {x < 10}");

    Console.WriteLine($"is x >= 5 ? {x >= 5}");
    Console.WriteLine($"is x greater than or eqial 3 ? {x >= 3}");

    Console.WriteLine($"is x less than or equal 5 ? {x <= 5}");
    Console.WriteLine($"is x <= 2 ? {x <= 2}");

    //lesson 13

    Console.Write("Enter your birth year: ");
    int birthYear =  int.Parse(Console.ReadLine());

    Console.WriteLine($"Your age untill 2024 is: {2024 - birthYear} years");

    Console.Write("Enter your wieght in KGs: ");
    float wieght =  float.Parse(Console.ReadLine());

    Console.WriteLine($"Your wieght in pounds is: {wieght * 2.20462} lbs");



    //Note: string+int

    string x = "12345" + 10;
    Console.WriteLine($"\"12345\" + 10 = {x}"); // 1234510 : converted 10 to string and concatenated strings to hold result in string variable "x"

    //Note: int cant hold string.. "int y = 10 + "123" " error, but "int y = 10 + (int)'123' " not error
    int y = 10 + (int)'1';
    Console.WriteLine($"10 + ASCII of '1' = {y}");

    //lesson 14

    Console.Write("Please enter number to be tested even or odd: ");
    string response = Console.ReadLine();
    int number = int.Parse(response);

    if (number % 2 == 0)
    {
        if (number == 0)
        {
            Console.WriteLine("zero is neither odd nor even");
        }
        else
        {
            Console.WriteLine($"{number} is even");
        }
    }
    else
    {
        Console.WriteLine($"{number} is odd");
    } */

    //lesson 15

    /* [ Debugger Basics ]
        - What is debugger
        - Step-By-step Execution
        - Breakpoints
        - Locals
        - Watches
        -Edit and Continue
    

    //lesson 16

    int[] videos = new int[7] { 1, 5, 4, 2, 3, 7, 6 };
    Console.WriteLine(videos[3]);
    Array.Sort(videos);

    foreach(int element in videos){
        System.Console.WriteLine(element);
    }

    int[] videos2 = new int[7];
    Array.Copy(videos, videos2, videos.Length); 

    foreach(int element in videos2){
        System.Console.WriteLine(element);
    } 

    //lesson 17

    for (int i=0; i<6; i++)
    {
        Console.WriteLine(i);
    }

    int[] numbers = new int[] {50, 60, 70, 80, 90, 100, 110, 120};
    for (int i=0; i<numbers.Length; i+=2)
    {
        Console.WriteLine(i);
    }

    // task:

    int[] numbersHolder = new int[5];
    Console.WriteLine("enter 5 numbers");
    for (int i=0; i<5; i++)
    {
        numbersHolder[i] = int.Parse(Console.ReadLine());
    }
    Array.Sort(numbersHolder);

    for (int i=0; i< numbersHolder.Length; i++)
    {
        Console.Write($"{numbersHolder[i]} ");
    } 

    //lesson 18

    for (int i = 1; i < 6; i++)
    {
        string statement = i % 2 == 0 ? $"{i} even" : $"{i} odd";
        Console.WriteLine(statement); 
    } 

    //lesson 19

    char[] numbers = new char[] { '0', '1', '2', '3', '4' };

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"ascii of {numbers[i]} is {(int)numbers[i]}");
    }

    foreach (char c in numbers)
    {
        Console.WriteLine($"ascii of {c} is {(int)c}");
    }  

    //lesson 20
    
    //task:
    Console.WriteLine("enter array size");
    int arraySize = int.Parse(Console.ReadLine());
    int[] arr = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"enter array item #{i+1} ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    int[] arr2 = new int[arraySize];
    for (int i = arraySize-1; i>=0; i--)
    {
        arr2[i] = arr[arraySize - i - 1];
    }
    
    foreach(int i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine("\n");

    foreach (int i in arr2)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine("\n");

    //task:
    Console.WriteLine("enter array size");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"enter array item #{i + 1} ");
        array[i] = int.Parse(Console.ReadLine());
    }
    int sum = 0;
    foreach(int i in array)
    {
        sum += i;
    }
    double avg = sum / array.Length;
    Console.WriteLine($"array avg = {avg}");  

    //lesson 21

    int x = 11, y = 11;

    do
    {
        Console.WriteLine($"{x}");  //exec at least once..
        x++;
    } while (x < 11);


    while (y < 11)
    {
        Console.WriteLine($"{x}");
        x++;
    }

    while (true)
    {
        Console.WriteLine("Enter string to capitalize \"press exit to end process\"");

        string response = Console.ReadLine();
        if (response != "exit")
        {
            Console.WriteLine(response.ToUpper());
        }
        else
        {
            break;
        }
    } 

    //lesson 22

    bool runAgain = true;
    while (runAgain)
    {
        Console.WriteLine("Enter string..");
        string userInput = Console.ReadLine();

        Console.WriteLine(@"Enter:
                        (1) to capitalize string
                        (2) to small string
                        (3) to get string length");

        int userOperation = int.Parse(Console.ReadLine());
        switch (userOperation)
        {
            case 1:
                Console.WriteLine($"string capitalized: {userInput.ToUpper()}");
                break;
            case 2:
                Console.WriteLine($"string small: {userInput.ToLower()}");
                break;
            case 3:
                Console.WriteLine($"string length: {userInput.Length}");
                break;
            default:
                Console.WriteLine("wrong input");
                break;
        }
        Console.WriteLine("run again? (Y/N)");
        string response = (Console.ReadLine()).ToUpper();
        if (response == "N")
        {
            runAgain = false;
            Console.WriteLine("Thanks,");
        }
    }

    //lesson 23

    static void CalculateAverage(nums[])
    {
        int sum = 0;
        foreach (int number in nums)
        {
            sum += number;
        }
        double average = sum / nums.Length;
        Console.WriteLine($"Average: {average}");
    }
    
    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
    CalculateAverage(numbers);

    //lesson 24

    //note: single responsibility principle: each code unit (method, class..) does only one task.

    static double CalculateAverage(int[] nums, bool printAverageToConsole = false, bool printSumToConsole = false)
    {
        int sum = 0;
        foreach (int number in nums)
        {
            sum += number;                  // optional parameters is set by giving themm initial values, if assigned when 
        }                                  // method called then work with that value if not then acts as the initial value given to it in definition, note: optional parameter(s) must be last in method parameter(s)
        double average = sum / nums.Length;
        if (printAverageToConsole)
            Console.WriteLine($"Average: {average}");
        if (printSumToConsole)
            Console.WriteLine($"Sum: {printSumToConsole}");
        return average;
    }

    int[] numbers = new int[] { 1, 2, 3, 4, 5};

    double avg = CalculateAverage(numbers);
    Console.WriteLine($"Average: {avg}");  // both false "return double"

    CalculateAverage(numbers, true);
    CalculateAverage(numbers, printAverageToConsole: true); // first true, second false

    CalculateAverage(numbers, false, true);
    CalculateAverage(numbers, printSumToConsole: true); // first false, second true

    CalculateAverage(numbers, true, true);
    CalculateAverage(numbers, printAverageToConsole: true, printSumToConsole: true); // both true

    // task:
    static void PrintMessage(string message, int repeatCount = 1, bool uppercase = false)
    {
        if (uppercase)
            message = message.ToUpper();
        for (int i = 0; i < repeatCount; i++)
        {
            Console.WriteLine(message);
        }
    }

    PrintMessage("Hello, World!");
    PrintMessage("Hello, World!", 3);
    PrintMessage("Hello, World!", 2, true);  

    //lesson 25

    
    // todo comments: to make task alerts before specific code u can do it like
    // todo: some task
    // some code
    

    // todo is not best task management way use task management softwares.
    // u can reach all to do u created in code from view -> task list

    
    // XML documintation: 
    // like .net framework built-in xml docs like when u point at method name and it
    // shows u the method parameters, return type and all information.
    

    // u can make ur own xml documintation for your own methods by making xml docu right above ur method, example:

    /// <summary>
    /// Prints a specified message
    /// </summary>
    /// <param name="message">The message to print.</param>
    static void PrintHello(string message)
    {
        Console.WriteLine(message);
    }

    //lesson 26

    //training:

    Console.WriteLine("Please enter array size");

    int arraySize = int.Parse(Console.ReadLine());
    int[] numbers = new int[arraySize];

    Console.WriteLine("Please enter array elements");
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Enter element number #{i+1} ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
    int min = int.MaxValue, max = int.MinValue, sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];

        if (numbers[i] < min)
            min = numbers[i];
        if (numbers[i] > max)
            max = numbers[i];
    }

    double average = sum / numbers.Length;
    Console.WriteLine($"Largerst element is: {max} and smallest element is {min}");
    Console.WriteLine($"Array average is: {average}"); 

    //lesson 27

    bool runAgain = true;
    string response = "";

    while (runAgain)
    {
        Console.WriteLine("Please enter string to test");
        string inputUser = Console.ReadLine();
        int first = 0, last = inputUser.Length - 1;

        bool isPalindrome = true;
        while (first < last)
        {
            if (inputUser[first] != inputUser[last])
            {
                isPalindrome = false;
                break;
            }
            first++;
            last--;
        }
        if (isPalindrome)
        {
            Console.WriteLine($"{inputUser} is palindrome");
        }
        else
            Console.WriteLine($"{inputUser} is not a palindrome");
        Console.WriteLine("Wanna try another one? (Y/N)");
        response = Console.ReadLine();
        if (response.ToUpper() == "N") 
        {
            runAgain = false;
            Console.WriteLine("Thanks for your time.");
        }            
    } 

    //lesson 28

    int num1 = 5;
    int num2 = num1;
    num1 = 10;
    System.Console.WriteLine($"num1: {num1} num2: {num2}");

    int[] numbers1 = {1};
    int[] numbers2 = numbers1;
    numbers1[0] = 10;
    System.Console.WriteLine($"numbers1[0]: {numbers1[0]} numbers2[0] {numbers2[0]}");

    static void DuplicateValue(int number){
        number *= 2;
    }

    static void DuplicateArrayValues(int[] array){
        for(int i = 0; i<array.Length; i++){
            array[i] *= 2;
        }
    }

    int number = 5;
    int[] numbers = {1,2,3};

    DuplicateValue(number);
    System.Console.WriteLine($"number: {number}");

    DuplicateArrayValues(numbers);
    System.Console.WriteLine($"numbers[0]: {numbers[0]}");
    System.Console.WriteLine($"numbers[1]: {numbers[1]}");
    System.Console.WriteLine($"numbers[2]: {numbers[2]}");

    // Value types (e.g., int, float, char, struct) are stored on the stack. They hold their data directly.
    // Reference types (e.g., arrays, classes, strings) are stored on the heap. They hold references to their data.

    // string is reference type, BUT IT IS IMMUTABLE:

    string name = "Hello";
    name = "ee";
    System.Console.WriteLine($"name: {name}");
    // When you reassign name, you are not changing the original string "hello". Instead, you are creating a new string "ee" and updating the reference name to point to this new string, leaving old string "Hello" as garbage in memory.

    string name2 = "Hello";
    name2 += "World";
    System.Console.WriteLine($"name2: {name2}");
    // When concatenation occurs, a new string "helloworld" is created, and name2 is updated to reference this new string, the old string also remains unchanged in memoery, but since name2 now references new string "Hello World", that is what gets printed.
    

    //lesson 29

    int i = 5;

    // Implicit Casting: store type smaller in size in another type larger in size or its representation can hols the small size type without data loss
    float f = i;
    double d = i;
    double d2 = f;

    double s = 12.343458422758435;

    // Explict Casting: 
    float f2 = (float)s; //float can not hold double, if u want to, cast double to float.. but that leads to data loss.
    int i2 = (int)s;    // int can not hold double, if u want to, cast double to int.. but that leads to data loss.
    int i3 = (int)s;   // int can not hold float, if u want to, cast float to int.. but that leads to data loss.

    // AVOID DATA LOSS PROBLEMS! do not use explicit casting except if u know that there wont be data loss issues, or u kknow a data loss issue wont affect the Program. 


    //lesson 30

    string str = "Hello {0}, My name is {0} {1}"; // {0}, {1}, {2}..etc, are called placeholders, u can replace them later with values with the string.Format method but notice arrangement when u pass parameters to the method as the string paramters are zero-indexed with the arrangement u pass them with, u can also repeat a place holder "ex. {0}{1}{0}" and the Format methos will replace each with it value "the index arrangement that u passed the parameters with".
    System.Console.WriteLine(str);
    str = string.Format(str, "Ahmed", "Mohamed");
    System.Console.WriteLine(str);

    string str2 = "Hello there, my name is: {0,15} {1,12}"; // u can control spacing before placeholder values in the console like: {0,23} -> that will but 23 spaces before the value of the {0} placeholder,
    str2 = string.Format(str2, "Ahmed", "Mohamed");
    System.Console.WriteLine(str2);

    // u can format parameters with different methods:
    double salary = 10000;
    string str3 = "Your salary is: {0:C2}"; // {0:C2} -> tells compiler to format that parameter as Currency "put $ symbol", format zeros "comma after each three zeros" and with Two digits after the decimal point
    str3 = string.Format(str3, salary);
    System.Console.WriteLine(str3);

    string str4 = "Your salary is: {0:N2}"; // only puts Two digits after the decimal point and formats zeros, no $ symbol
    str4 = string.Format(str4, salary);
    System.Console.WriteLine(str4);

    string str5 = "Your salary is: {0:0.00}"; // only puts Two digits after the decimal point, no zeros formatting nor $ symbol
    str5 = string.Format(str5, salary);
    System.Console.WriteLine(str5);

    // Note: formatting arguments has different methods due to use, check documintations: https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0
    

    //lesson 31

    System.Console.WriteLine("Enter list of items seperated by comma: ");
    string input = Console.ReadLine();
    string[] numbers = input.Split(",");
    int sum = 0;
    foreach (string number in numbers) {
        sum += int.Parse(number);
    }
    System.Console.WriteLine($"Average is: {sum/numbers.Length}");

    string[] words = {"Hello", "Passionate", "Coders"};
    string statement = string.Join(" ", words);
    System.Console.WriteLine(statement);
    

    //lesson 32

    StringBuilder sb = new StringBuilder();
    sb.Append("Hello ");
    sb.Append("World, ");
    sb.AppendLine("I love Passionate Coders, ");
    sb.Append("thank you.");
    System.Console.WriteLine($"length: {sb.Length}");
    System.Console.WriteLine($"capacity: {sb.Capacity}");
    System.Console.WriteLine($"max capicaty: {sb.MaxCapacity}");
    System.Console.WriteLine(sb.ToString());

    StringBuilder sb2 = new StringBuilder(4096);  //create sb with starting capacity of 4 kilobytes, use this when u know the storage u know u will need or the predicted size of the string,
    sb2.Append("Ahmed");
    System.Console.WriteLine($"length: {sb2.Length}");
    System.Console.WriteLine($"capacity: {sb2.Capacity}");

    //when to use StringBuilder: when u deal with big string and multiple concatenation processes,
    // Note: StringBuilder works on LinkedList.

    //lesson 33

    // Compilation process

    //lesson 34
    
    Student s1 = new Student("Ahmed", "01276932944");
    s1.CumulativeGPA = 3.33;

    Student[] students = new Student[10];
    students[0] = s1;

    Object o = new Object(); // each class instance or object in c# inhiteritence methods and attributes of the Object class, means all classes are inhereting the Object class "are childs of him".


    //lesson 35
    // Namespaces

    Human h1 = new Human();
    Employee e1 = new Employee();

    // it is not allowed to use two namespace elements(classes, enums, interfaces) with the same name "it makes sense.. u can not name to files in the same folder with the same name".

    // if u have two classed with the same name in two different folders, then while using their two namespaces "lets suppose these 2 namespaces are myConsole and myConsole.Data" in the main program.cs file it may confilct the compiler "which class should be used?", the one in the first namespace or the other?
    // to solve this b y  two ways:
    // first) mention the whole name space when using the class in the code like : var s1 = new myConsole.Student(); or var s1 = new myConsole.Data.Student();
    // second way) called elias: u determine the space u mean in the above when calling the namespace like: using Student = myConsole.Data.Student;

    // Some Notes about a project strucure:
    // 1) class library project gives dll file, console app project gives both exe and dll files
    // 2) In a big project u may split it into many projects, each project responsible for something and these small prjects is called project layers, there is an entry point project"layer" for the big project.
    // ex. a project has 2 projects-> 1) a console application "entry point project" its gives the .exe file that runs the program 2) a class library project that has the acutal code and files of the project, while the console app "or windows forms app ormvc project" has only the UI information&design.

    //lesson 36

    // Access modifies:

    //lesson 37

    // Constants variables vs Read-Only variables : 1) constant variables must be initialized on declaration while read-only variables do not really have to 2)constant variable value cant be changed while read-onl variable can be changed throw it is class constructor "the program class" 3) constant variable is compiled time variable while read-only variable is run time variable "its value only been known when the program runs",

    //lesson 38

    // static classes in c#: when u do not need to take instances "objects" from a class, u only need to use the mehods inside it, like math class, or Console
    // notes: 
          //  if a class is static then its all methods must be static, but not vice verca "i mean a non-static class can has some static methods"
          //  u cant create object outta static class, to use a method from inside it, mention ClassName.Method(), "like Console.WriteLine()"
          // Also the static class constructor is static
          // static classes cant have objects right? so when a static class constructor is called? it is called only one time on the first call of the class "when u call a method from the class", while the non-static class constructors are called with each new object from the class.

    // a class static member "method" cant access class non-static member "variable"
    

    //lesson 39

    // variable class-level scope
    // variable method-level scope
    // variable block-level scope 


    //lesson 40

    bool isSuccessful = true;

    double result = Divide1(10, 0, isSuccessful);
    System.Console.WriteLine($"{isSuccessful}"); // isSuccessful value still true because we passed it by value

    static double Divide1(double number, double divisor, bool isSuccessful)
    {
        if (divisor == 0)
        {
            System.Console.WriteLine("Can not divide by zero");
            isSuccessful = false;
            return 0;
        }
        return number / divisor;
    }

    double result2 = Divide1(10, 0, isSuccessful);
    System.Console.WriteLine($"{isSuccessful}"); // now isSuccessful value becomes false because we passed it by reference

     static double Divide2(double number, double divisor, ref bool isSuccessful)
    {
        if (divisor == 0)
        {
            System.Console.WriteLine("Can not divide by zero");
            isSuccessful = false;
            return 0;
        }
        return number / divisor;
    }

    double result3 = Divide1(10, 0, isSuccessful);
    System.Console.WriteLine($"{isSuccessful}"); // now isSuccessful value becomes false because we passed it by reference

     static double Divide3(double number, double divisor, out bool isSuccessful)
    {
        if (divisor == 0)
        {
            System.Console.WriteLine("Can not divide by zero");
            isSuccessful = false;
            return 0;
        }
        isSuccessful = true;
        return number / divisor;
    }

    // Note: ref parameter must be initialized before passing, while out parameter dont have to
    // out parameter do not have to be initialized preeviously before passing it beacuse an out parameters obligates you to assign it in each code path in the method

    int num = 0;
    Console.Write("Please enter a number: ");
    bool isSuccessed = int.TryParse(Console.ReadLine(), out num); // try parse method reyrn a bool and used to check if an error hepened while conersion, u pass it the readline and another out parameter which will be assigned to the variable u had diclared to hold the parsing resut in case of successes
    System.Console.WriteLine($"isSuccessed: {isSuccessed}");
    System.Console.WriteLine("num: {num}");

    Console.Write("Please enter a number: ");
    bool isSuccessed2 = int.TryParse(Console.ReadLine(), out int num2); // u can declare the variable that returns the parsing unit inside method, no need to declare it outside
    System.Console.WriteLine($"isSuccessed: {isSuccessed2}");
    System.Console.WriteLine("num: {num2}");


    //lesson 41

    try
    {
        System.Console.WriteLine(Divivde(10,2));
        System.Console.WriteLine(Divivde(10,0));
    }
    catch (DivideByZeroException ex)
    {
        System.Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine(ex.ToString());
        Console.ForegroundColor = ConsoleColor.White;
    }
    finally
    {
        System.Console.WriteLine("Finally im Done");
    }

    static double Divivde(double number, double divisor)
    {
        return number / divisor;
    }

    try
    {
        System.Console.Write("Please enter 5 characters string ");
        string input = Console.ReadLine();
        if (input.Length != 5)
        {
            throw new Exception("String must be exactly 5 characters long");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine(ex.ToString());
        Console.ForegroundColor = ConsoleColor.White;
    }
    

    

    


    Console.ReadKey();
}
}
}
