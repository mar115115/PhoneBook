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
        [Test]
        public void Employee_Creation()
        {
            Employee emp = new Employee("Wojciech", "Kuk", 1, Departments.Szczecin, "+48800700600");

            Assert.Multiple(() =>
                {
                    Assert.AreEqual("Wojciech", emp.Name);
                    Assert.AreEqual("Kuk", emp.SurName);
                    Assert.AreEqual(1, emp.BadgeID);
                    Assert.AreEqual(Departments.Szczecin, emp.Department);
                    Assert.AreEqual("+48800700600", emp.InternalPhone);
                });

        }

        [Test]
        public void Employee_PrintBasicInfo_Output()
        {
            Employee emp = new Employee("Wojciech", "Kuk", 1, Departments.Szczecin, "+48800700600");
            string basicInfo = emp.PrintBasicInfo();

            Assert.AreEqual($"Name:{emp.Name} Department:{emp.Department}", basicInfo); //TODO asser Wojciech equal to basicin
        }

        [Test]
        public void Employee_PrintFullInfo_Output()
        {
            Employee emp = new Employee("Wojciech", "Kuk", 1, Departments.Szczecin, "+48800700600");
            string fullInfo = emp.PrintFullInfo();

            Assert.AreEqual($"BadgeID:{emp.BadgeID} Name:{emp.Name} SurName:{emp.SurName} Department:{emp.Department} InternalPhone:{emp.InternalPhone}", fullInfo);
        }

        [Test]
        public void PhoneBook_PrintAllFromLocation()
        {
            Employee emp0 = new Employee("Wojciech", "Kuk", 1, Departments.Szczecin, "+48800700600");
            Employee emp1 = new Employee("Michal", "Kukliński", 2, Departments.Wroclaw, "+48800700611");
            Employee emp2 = new Employee("Wojtek", "Pieróg", 3, Departments.Koszalin, "+48800700622");
            Employee emp3 = new Employee("Piotr", "Mak", 4, Departments.Szczecin, "+48800700633");
            Phonebook testPhoneBook = new Phonebook();
            testPhoneBook.addEmployee(emp0);
            testPhoneBook.addEmployee(emp1);
            testPhoneBook.addEmployee(emp2);
            testPhoneBook.addEmployee(emp3);

            testPhoneBook.employeesFromLocation(Departments.Szczecin);
            
           // Assert.AreEqual($"BadgeID:{emp.BadgeID} Name:{emp.Name} SurName:{emp.SurName} Department:{emp.Department} InternalPhone:{emp.InternalPhone}", fullInfo);
        }
    }
}
