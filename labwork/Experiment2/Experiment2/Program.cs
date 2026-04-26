using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment2
{
    class Student
    {
        private string name;
        private int age;

        
        public void SetData(string n, int a)
        {
            name = n;
            age = a;
        }

        
        public void DisplayData()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age: " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            
            s1.SetData("Sanjana", 20);
            s1.DisplayData();

            Console.ReadLine();
        }
    }
}
