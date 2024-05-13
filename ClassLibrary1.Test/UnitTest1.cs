using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1; // Подключаем вашу библиотеку классов

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class Var09_EmployeesTests
    {
        [TestMethod]
        public void EmployeeConstructor_WithValidArguments_ShouldSetProperties()
        {
            // Arrange
            string name = "John";
            string surname = "Doe";
            string patronymic = "Smith";
            string post = "Manager";

            // Act
            Var09_Employees employee = new Var09_Employees(name, surname, patronymic, post);

            // Assert
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(surname, employee.Surname);
            Assert.AreEqual(patronymic, employee.Patronymic);
            Assert.AreEqual(post, employee.Post);
        }

        [TestMethod]
        public void EmployeePostSet_ShouldSetPostProperty()
        {
            // Arrange
            Var09_Employees employee = new Var09_Employees("", "", "", "");

            // Act
            employee.Post = "Director";

            // Assert
            Assert.AreEqual("Director", employee.Post);
        }
    }
}