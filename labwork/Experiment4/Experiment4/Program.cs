using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment4
{

    public delegate int performCalculation(int x, int y);

    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            performCalculation deladd = Add;
            performCalculation delsub = Subtraction;
            int resAdd = deladd(1, 2);
            int resSubtraction = delsub(5, 3);
            Console.WriteLine($"Addition of 1 and 2 is : {resAdd} ");
            Console.WriteLine($"Subtraction of 5 and 3 is : {resSubtraction} ");

            Func<int, int> square = x => x * x;
            int result = square(5);
            Console.WriteLine(result);

            Func<int, int, int> Add = (x, y) => x + y;
            Console.WriteLine(Add(4, 5));

        }
    }
}

//Calculator using delegates
namespace DelegateCalculator
{
    public delegate double Calculation(double a, double b);

    class Program
    {
        static double Add(double x, double y) => x + y;
        static double Subtract(double x, double y) => x - y;
        static double Multiply(double x, double y) => x * y;
        static double Divide(double x, double y) => y != 0 ? x / y : 0;

        static void Main(string[] args)
        {
            Console.WriteLine("--- C# Delegate Calculator ---");
            
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose Operation: 1.Add, 2.Subtract, 3.Multiply, 4.Divide");
            int choice = int.Parse(Console.ReadLine());

            Calculation calc = null;

            switch (choice)
            {
                case 1: calc = Add; break;
                case 2: calc = Subtract; break;
                case 3: calc = Multiply; break;
                case 4: calc = Divide; break;
                default: 
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            double result = calc(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
    }
}

//Multicast delegate example
public delegate void MyDelegate(string name);

class Program
{
    static void Hello(string name) => Console.WriteLine($"Hello, {name}!");
    static void Goodbye(string name) => Console.WriteLine($"Goodbye, {name}!");
    static void Welcome(string name) => Console.WriteLine($"Welcome to C#, {name}!");

    static void Main()
    {
        MyDelegate del = Hello;

        del += Goodbye;
        del += Welcome;

        Console.WriteLine("--- Invoking all three methods ---");
        del("Alice"); 

        del -= Goodbye;

        Console.WriteLine("\n--- After removing 'Goodbye' ---");
        del("Alice");
    }
}

//replace method with lambda expressions
// public int Addition(int x, int y) 
// {
//     return x + y;
// }
// Func<int, int, int> add = (x, y) => x + y;

//Sort List using Lambda
// List<int> numbers = new List<int> { 5, 3, 1, 4, 2 };
// numbers.Sort((x, y) => x.CompareTo(y));
// numbers.Sort((x, y) => y.CompareTo(x));

//Where delegates and lambda expressions are used in industry levels
// 1. Language Integrated Query (LINQ) - Data Processing 
// Lambda expressions are the core building block of LINQ in C#.
// Industry developers use them extensively to query, filter, and transform 
// data collections (lists, databases, XML) using a declarative syntax.
// 2. Event Handling and UI Development

//what is linq queries
// LINQ (Language Integrated Query) is a set of features in C# that provides a consistent, 
// declarative way to query and manipulate data from various sources—such as 
// in-memory collections (arrays, lists), SQL databases, and XML documents—directly within 
// the C# language.