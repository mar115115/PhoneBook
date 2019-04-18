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
        public void Employee_PrintBasicInfo_Output()
        {
            Employee emp = new Employee(1, "Wojciech", "Kuk", Departments.Szczecin, "+48800700600");
            string basicInfo = emp.PrintBasicInfo();

            Assert.AreEqual($"Name:{emp.Name} Department:{emp.Department}", basicInfo);
        }

        [Test]
        public void Employee_PrintFulInfo_Output()
        {
            Employee emp = new Employee(1, "Wojciech", "Kuk", Departments.Szczecin, "+48800700600");
            string fullInfo = emp.PrintFullInfo();

            Assert.AreEqual($"BadgeID:{emp.BadgeID} Name:{emp.Name} SurName:{emp.SurName} Department:{emp.Department} InternalPhone:{emp.InternalPhone}", fullInfo);
        }
    }
}
