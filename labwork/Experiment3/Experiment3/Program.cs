using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Experiment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

//SOLID PRINCIPLES
//S : single responsibility principle
//one class have only one responsibility
class Animal
{
    void bark()
    {
        Console.WriteLine("Bark");
    }
}

class student
{
    void getMarks(int x, int y)
    {
        Console.WriteLine(x + ", " + y);
    }
}

class employee
{
    void getSalary(int x, int y)
    {
        Console.WriteLine(x + ", " + y);
    }
}

//O : Open or Closed Principle
// open to add new features and 
//closed for modification
abstract class Discount
{
    public abstract double GetDiscount();
}

class StudentDiscount : Discount
{
    public override double GetDiscount() => 10;
}

class SeniorDiscount : Discount
{
    public override double GetDiscount() => 15;
}


//L : Liskov principle
//Child class replace parent class without breaking program for parent class
class Bird
{
    public virtual void Fly() { }
}

class Ostrich : Bird
{
    public override void Fly()
    {
        throw new Exception("I can't fly!");
    }
}


//I : Interface Segregation Principle
//Don’t force a class to implement methods it doesn’t need
interface Iworkable
{
    void work();
}
interface Etable
{
    void eat();
}
class Human : Iworkable, Etable
{
    public void work(){ }
    public void eat() { }
}
class Robot : Iworkable
{
    public void work() { }
}

// D : Dependency Inversion Principle (DIP)
//High-level classes should not depend on low-level classes
//Both should depend on abstractions
interface ISwitchable
{
    void TurnOn();
}

class LightBulb : ISwitchable
{
    public void TurnOn() { }
}

class Fan : ISwitchable
{
    public void TurnOn() { }
}

class Switch
{
    private ISwitchable device;
    public Switch(ISwitchable device)
    {
        this.device = device;
    }

    public void Operate() => device.TurnOn();
}



// How to connect c# with ADO .net connectivity with c sharp
// using Microsoft.Data.SqlClient;
// ADO.NET is a technology in .NET used to connect, read, insert, update,
// delete data from databases like:
// SQL Server
// MySQL
// Oracle
// Think of it as a bridge between C# app and database 