using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BelovaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            // область создания методов тестирования, методов из библиотеки 
            var name = "Катя";
            var res = DataService.GetMessage(name);

            // вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Катя", res);
        }
    }
}
