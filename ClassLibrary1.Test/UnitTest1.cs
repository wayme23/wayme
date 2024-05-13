using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1; // Подключаем вашу библиотеку классов
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class Var09_EmployeesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Var09_Employees();
            double arg1 = 4;
            double arg2 = 1;
            // act
            double result = calc.Div(arg1, arg2);
        }
    }
}