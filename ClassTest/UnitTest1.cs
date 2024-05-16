using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using Moq;

// в целом, тест проверяет, что класс Var09_Employees может правильно хранить и управлять данными о сотрудниках

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class Var09_EmployeesTests
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // создаем тестовые данные для использовния в тесте
            string name = "Иван";
            string surname = "Иванов";
            string patronymic = "Иванович";
            Var10_Post post = new Var10_Post("Менеджер", "100000", "Продажи");

            // создаем объект с помощью конструктора 
            Var09_Employees employee = new Var09_Employees(name, surname, patronymic, post);

            // проверяем, что свойства объекта были установленны верно
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(surname, employee.Surname);
            Assert.AreEqual(patronymic, employee.Patronymic);
            Assert.AreEqual(post, employee.Post);
        }

        [TestMethod]
        public void Name_SetterSetsValueCorrectly()
        {
            // создаем объект с пустыми свойствами
            Var09_Employees employee = new Var09_Employees("", "", "", null);

            // устанавливаем новое имя для свойсва Name
            string newName = "Петр";
            employee.Name = newName;

            // проверяем было ли свойство Name установленно в новое значение 
            Assert.AreEqual(newName, employee.Name);
        }

        [TestMethod]
        public void Surname_SetterSetsValueCorrectly()
        {
            // все тоже самое, что и методе выше
            Var09_Employees employee = new Var09_Employees("", "", "", null);
            
            string newSurname = "Петров";
            employee.Surname = newSurname;


            Assert.AreEqual(newSurname, employee.Surname);
        }

        [TestMethod]
        public void Patronymic_SetterSetsValueCorrectly()
        {
            // все тоже самое, что и в методе выше 
            Var09_Employees employee = new Var09_Employees("", "", "", null);
            
            string newPatronymic = "Петрович";
            employee.Patronymic = newPatronymic;
            
            Assert.AreEqual(newPatronymic, employee.Patronymic);
        }

        [TestMethod]
        public void Post_SetterSetsValueCorrectly()
        {
            // создаем объект с пустыми свойствами
            Var09_Employees employee = new Var09_Employees("", "", "", null);

            // создаем новый объект со свойствами 
            Var10_Post newPost = new Var10_Post("Директор", "200000", "Управление");
            employee.Post = newPost;

            // проверяем, что свойство объекта Var09 было установленно в новый объект Var10
            Assert.AreEqual(newPost, employee.Post);
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionWhenNameIsNull()
        {
            // Ожидаем, что конструктор выбросит исключение ArgumentNullException, когда параметр name равен null.
            Assert.ThrowsException<ArgumentNullException>(() => new Var09_Employees(null, "Иванов", "Иванович", new Var10_Post("Менеджер", "100000", "Продажи")));
        }
    }
}
