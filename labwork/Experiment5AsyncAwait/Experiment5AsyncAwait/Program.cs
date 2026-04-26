using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Experiment5AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();


        }

        public static void Task7()
        {
            Console.WriteLine("Task7 Starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task7 Executed!");
        }
        public static void Task8()
        {
            Console.WriteLine("Task8 Starting");
            Task.Delay(1000);
            Console.WriteLine("Task8 Executed!");
        }

        public async static void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 Starting");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 Executed!");
            }
            );
           
        }
        public async static void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 Starting");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 Executed!");
            } 
            );
        }
        public async static void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 Starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task3 Executed!");
            }
            );
        }
        public async static void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 Starting");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 Executed!");
            }
            );
        }
        public async static void Task5()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task5 Starting");
                Thread.Sleep(5000);
                Console.WriteLine("Task5 Executed!");
            }
            );
        }

        public async static void Task6()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task6 Starting");
                Task.Delay(5000);
                Console.WriteLine("Task6 Executed!");
            }
            );
        }

        
    }

}


//1. synchronous programming
//Task exeutes one after another.
//public static void Task1()
//{
//    Console.WriteLine("Task 1 Starting");
//    Thread.Sleep(3000);
//    Console.WriteLine("Task1 Executed!");
//}

//public static void Task2()
//{
//    Console.WriteLine("Task2 Starting");
//    Thread.Sleep(1000);
//    Console.WriteLine("Task3 Executed!");
//}


//2. convert synchronous programming to asynchronous.
//By using async and await keywords.

//3. Replace thread.Sleep with Task.delay observe behaviour.
// Replacing Thread.Sleep with await Task.Delay fundamentally 
// changes our application's behavior from blocking to asynchronous suspension.

//4. Create method and returning task;.
// public async Task ProcessDataAsync()
// {
//     await Task.Delay(1000); 
//     Console.WriteLine("Data processed.");
// }
