using System;
using MyCalc;
namespace HelloApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("welcome to jenkins!");
            Console.WriteLine("some changes made here");
            Calc calc = new Calc();
            Console.WriteLine($"Sum={calc.Add(70,80)}");
            Console.WriteLine($"Multiply={calc.Multiply(4, 5)}");
            Console.WriteLine($"Substract={calc.Substract(70, 30)}");
            Console.ReadLine();
        }
    }
}
