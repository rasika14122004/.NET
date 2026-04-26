// See https://aka.ms/new-console-template for more information
//Arithmetic operations

using System.Linq;

int num1 = 20;
int num2 = 10;

//Addition
Console.WriteLine(num1 + num2);//30

//Subtraction
Console.WriteLine(num1 - num2);//10

//Multiplication
Console.WriteLine(num1 * num2);//200

//Division
Console.WriteLine(num1 / num2);//2

//Modulus
Console.WriteLine(num1 % num2);//0




//Variables
string name = "Sanjana";
Console.WriteLine(name);

int num = 5;
Console.WriteLine(num);

bool b = true;
Console.WriteLine(b);

char ch = 'S';
Console.WriteLine(ch);

double d = 10.5;
Console.WriteLine(d);

//Constants
const int n = 50;
Console.WriteLine(n);
//error n = 10;


string str = "sanjana";
Console.WriteLine("Hello " + str);

//multiple variables
int x = 2, y = 3, z = 4;
Console.WriteLine(x + y + z);

//Type Casting
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9

double Double = 9.78;
int Int = (int)myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9


//user Input
Console.WriteLine("Enter your Name : ");
string str1 = Console.ReadLine();


Console.WriteLine("Enter your age:");
//This line shows an error message that cannot convert string into int implicitly...
//int age = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());


//Comparison operators
Console.WriteLine(num1 > num2);

//Math operators
Console.WriteLine(Math.Max(5, 10));
Console.WriteLine(Math.Min(5, 10));
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Abs(-3));

//Strings
string str2 = "sanjana";
string str3 = "sakshi";
string str4 = str2 + str3;
Console.WriteLine(str4);
string str5 = string.Concat(str2, str3);
Console.WriteLine(str5);

//Booleans
bool isTrue = true;
Console.WriteLine(isTrue);


