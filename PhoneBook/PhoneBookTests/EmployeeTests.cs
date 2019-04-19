namespace PhoneBookTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using PhoneBook;
  
    [TestFixture]
    public class EmployeeTests
    {
        // przed każdym testem wykonane
        // [SetUp]
        // public void SetUp()
        private Employee testEmployee;
        [SetUp]
        public void SetUp()
        {
            this.testEmployee = new Employee("Wojciech", "Kuk", 1, Departments.Szczecin, "+48800700600");
        }

        [Test]
        public void Employee_Creation()
        {
            Assert.Multiple(() =>
                {
                    Assert.AreEqual("Wojciech", testEmployee.Name);
                    Assert.AreEqual("Kuk", testEmployee.SurName);
                    Assert.AreEqual(1, testEmployee.BadgeID);
                    Assert.AreEqual(Departments.Szczecin, testEmployee.Department);
                    Assert.AreEqual("+48800700600", testEmployee.InternalPhone);
                });
        }

        [Test]
        public void Employee_PrintBasicInfo_Output()
        {
            string basicInfo = this.testEmployee.PrintBasicInfo();

            Assert.AreEqual($"Name:{testEmployee.Name} Department:{testEmployee.Department}", basicInfo);
        }

        [Test]
        public void Employee_PrintFullInfo_Output()
        {
            string fullInfo = this.testEmployee.PrintFullInfo();

            Assert.AreEqual($"BadgeID:{testEmployee.BadgeID} Name:{testEmployee.Name} SurName:{testEmployee.SurName} Department:{testEmployee.Department} InternalPhone:{testEmployee.InternalPhone}", fullInfo);
        }

        [Test]
        public void PhoneBook_EmployeeByBadgeId_Output()
        {
            Employee emp1 = new Employee("Michal", "Kukliński", 2, Departments.Wroclaw, "+48800700611");
            Employee emp2 = new Employee("Wojtek", "Pieróg", 3, Departments.Koszalin, "+48800700622");
            Employee emp3 = new Employee("Piotr", "Mak", 4, Departments.Szczecin, "+48800700633");
            Phonebook testPhoneBook = new Phonebook();
            testPhoneBook.addEmployee(this.testEmployee);
            testPhoneBook.addEmployee(emp1);
            testPhoneBook.addEmployee(emp2);
            testPhoneBook.addEmployee(emp3);
            Employee found = testPhoneBook.employeeByBadgeId(3);

            Assert.AreEqual(emp2, found);
        }

        [Test]
        public void PhoneBook_EmployeeByName_Output()
        {
            Employee emp1 = new Employee("Michal", "Kukliński", 2, Departments.Wroclaw, "+48800700611");
            Employee emp2 = new Employee("Wojciech", "Pieróg", 3, Departments.Koszalin, "+48800700622");
            Employee emp3 = new Employee("Piotr", "Mak", 4, Departments.Szczecin, "+48800700633");
            Phonebook testPhoneBook = new Phonebook();
            testPhoneBook.addEmployee(this.testEmployee);
            testPhoneBook.addEmployee(emp1);
            testPhoneBook.addEmployee(emp2);
            testPhoneBook.addEmployee(emp3);
            List<Employee> foundList = testPhoneBook.employeesByName("Wojciech");

            Assert.AreEqual(2, foundList.Count);
            Assert.AreEqual(testEmployee, foundList.First());
        }

        // [Test]
        // public void PhoneBook_PrintAllFromLocation()
        // {
        //    Employee emp0 = new Employee("Wojciech", "Kuk", 1, Departments.Szczecin, "+48800700600");
        //    Employee emp1 = new Employee("Michal", "Kukliński", 2, Departments.Wroclaw, "+48800700611");
        //    Employee emp2 = new Employee("Wojtek", "Pieróg", 3, Departments.Koszalin, "+48800700622");
        //    Employee emp3 = new Employee("Piotr", "Mak", 4, Departments.Szczecin, "+48800700633");
        //    Phonebook testPhoneBook = new Phonebook();
        //    testPhoneBook.addEmployee(emp0);
        //    testPhoneBook.addEmployee(emp1);
        //    testPhoneBook.addEmployee(emp2);
        //    testPhoneBook.addEmployee(emp3);

        ////    testPhoneBook.employeesFromLocation(Departments.Szczecin);

        //// Assert.AreEqual($"BadgeID:{testEmployee.BadgeID} Name:{testEmployee.Name} SurName:{testEmployee.SurName} Department:{testEmployee.Department} InternalPhone:{testEmployee.InternalPhone}", fullInfo);
        // }
    }
}
