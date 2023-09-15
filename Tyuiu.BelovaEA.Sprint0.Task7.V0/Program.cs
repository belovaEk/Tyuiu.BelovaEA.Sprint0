using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BelovaEA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.BelovaEA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #0" + new string(' ', 63) + '*');
            Console.WriteLine("* Тема: Создание итогового решения по спринту" + new string(' ', 29) + "*");
            Console.WriteLine("* Задание #7" + new string(' ', 62) + '*');
            Console.WriteLine("* Вариант #0" + new string(' ', 62) + '*');
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1" + new string(' ', 23) + '*');
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:" + new string(' ', 64) + '*');
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух" + new string(' ', 4) + '*');
            Console.WriteLine("* одинаковых массивов по длинне."+ new string(' ', 42) + '*');
            Console.WriteLine("*" + new string(' ', 73) + '*');
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + new string(' ', 56) + '*');
            Console.WriteLine(new string('*', 75));

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine(new string('*', 75));
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }


            Console.ReadLine();
        }
    }
}
