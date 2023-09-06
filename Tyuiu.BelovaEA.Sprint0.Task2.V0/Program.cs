using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.BelovaEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BelovaEA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataServise и метода GetMessage
            // из библиотеки Tyuiu.BelovaEA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Катя"));

            Console.ReadKey();
        }
    }
}
