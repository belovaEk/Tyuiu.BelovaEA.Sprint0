using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BelovaEA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // демонстрация метода сложения

            Console.WriteLine(DataService.Addition(1, 5));

            // демонстрация метода вычитания

            Console.WriteLine(DataService.Subtraction(15, 5));

            // демонстрация метода умножения

            Console.WriteLine(DataService.Multiplication(10, 10));

            // демонстрация метода деления

            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
