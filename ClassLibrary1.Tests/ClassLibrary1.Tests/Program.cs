using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1.Tests
{
    [TestFixture]
    public class Var09_EmployeesTests
    {
        [Test]
        public void EmployeeConstructor_WithValidData_InitializesPropertiesCorrectly()
        {
            // Arrange
            string name = "John";
            string surname = "Doe";
            string patronymic = "Smith";
            string post = "Manager";

            // Act
            Var09_Employees employee = new Var09_Employees(name, surname, patronymic, post);

            // Assert
            Assert.That(name, employee.Name);
            Assert.That(surname, employee.Surname);
            Assert.That(patronymic, employee.Patronymic);
            Assert.That(post, employee.Post);
        }

        [Test]
        public void PostProperty_WhenSetWithValidPost_SetsPostCorrectly()
        {
            // Arrange
            string post = "Developer";
            Var09_Employees employee = new Var09_Employees("John", "Doe", "Smith", "Manager");

            // Act
            employee.Post = post;

            // Assert
            Assert.That(post, employee.Post);
        }
    }
}
