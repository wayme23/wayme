using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using Moq;

// � �����, ���� ���������, ��� ����� Var09_Employees ����� ��������� ������� � ��������� ������� � �����������

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class Var09_EmployeesTests
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // ������� �������� ������ ��� ������������ � �����
            string name = "����";
            string surname = "������";
            string patronymic = "��������";
            Var10_Post post = new Var10_Post("��������", "100000", "�������");

            // ������� ������ � ������� ������������ 
            Var09_Employees employee = new Var09_Employees(name, surname, patronymic, post);

            // ���������, ��� �������� ������� ���� ������������ �����
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(surname, employee.Surname);
            Assert.AreEqual(patronymic, employee.Patronymic);
            Assert.AreEqual(post, employee.Post);
        }

        [TestMethod]
        public void Name_SetterSetsValueCorrectly()
        {
            // ������� ������ � ������� ����������
            Var09_Employees employee = new Var09_Employees("", "", "", null);

            // ������������� ����� ��� ��� ������� Name
            string newName = "����";
            employee.Name = newName;

            // ��������� ���� �� �������� Name ������������ � ����� �������� 
            Assert.AreEqual(newName, employee.Name);
        }

        [TestMethod]
        public void Surname_SetterSetsValueCorrectly()
        {
            // ��� ���� �����, ��� � ������ ����
            Var09_Employees employee = new Var09_Employees("", "", "", null);

            
            string newSurname = "������";
            employee.Surname = newSurname;


            Assert.AreEqual(newSurname, employee.Surname);
        }

        [TestMethod]
        public void Patronymic_SetterSetsValueCorrectly()
        {
            // ��� ���� �����, ��� � � ������ ���� 
            Var09_Employees employee = new Var09_Employees("", "", "", null);

            
            string newPatronymic = "��������";
            employee.Patronymic = newPatronymic;

            
            Assert.AreEqual(newPatronymic, employee.Patronymic);
        }

        [TestMethod]
        public void Post_SetterSetsValueCorrectly()
        {
            // ������� ������ � ������� ����������
            Var09_Employees employee = new Var09_Employees("", "", "", null);

            // ������� ����� ������ �� ���������� 
            Var10_Post newPost = new Var10_Post("��������", "200000", "����������");
            employee.Post = newPost;

            // ���������, ��� �������� ������� Var09 ���� ������������ � ����� ������ Var10
            Assert.AreEqual(newPost, employee.Post);
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionWhenNameIsNull()
        {
            // �������, ��� ����������� �������� ���������� ArgumentNullException, ����� �������� name ����� null.
            Assert.ThrowsException<ArgumentNullException>(() => new Var09_Employees(null, "������", "��������", new Var10_Post("��������", "100000", "�������")));
        }

    }
}