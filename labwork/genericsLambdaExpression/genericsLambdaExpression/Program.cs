using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic List Example
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            // num.Add("#"); // ❌ Error (Type Safety)

            // Generic Class Object
            MyClass<int> obj1 = new MyClass<int>();
            obj1.Data = 20;
            obj1.Show();
        }
    }

    // Generic Class (Must be outside Main method)
    class MyClass<T>
    {
        public T Data;

        public void Show()
        {
            Console.WriteLine(Data);
        }
    }
}


//Generics allow us to define classes, methods, or collections with a placeholder
//for a datatype so they work with any type.
//while maintaining type safety
//we does not use arrayList in C# instead of we use generics
//because arrayList is not a type safe. so industries does not use arrayLlist.
//it is a bad way

//Activities
//Write the two examples with Generics.
//Real world use of generics in industries level
//why companies use generics

//Lambda Expressions in C#
//A Lambda Expression is shortest way of anonomous methos
//using => operator
//Example : myDelegate del = (a, b) => a + b;
//write 2 Exmples with Lambda Expression.
//Where we use in company level
//Create a generic class to store two values by using lambda expression

//***Interview Questions***
//what is the generics
//why generics better than arrayList
//what is lambda expression
//difference between delegates and lambda

//Synchronous and ASynchronous Programming in C#
