using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class Var09_EmployeesTests
    {
        [TestMethod]
        public void EmployeeNameShouldBeSetCorrectly()
        {
            // Arrange
            Var09_Employees employee = new Var09_Employees("John", "Doe", "Smith", "Manager");

            // Act
            string expectedName = "Yrik";
            string actualName = employee.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }
    }
}