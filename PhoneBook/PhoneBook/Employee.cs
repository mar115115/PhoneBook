using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Employee
    {
        public int BadgeID { get; }
        public string Name { get; }
        public string SurName { get; }
        public Departments Department { get; }
        public string InternalPhone { get; }

        public Employee(int BadgeId, string Name, string SurName, Departments Department, string InternalPhone)
        {
            this.BadgeID = BadgeId;
            this.Name = Name;
            this.SurName = SurName;
            this.Department = Department;
            this.InternalPhone = InternalPhone;
        }

        public string PrintFullInfo()
        {
            string output = $"BadgeID:{BadgeID} Name:{Name} SurName:{SurName} Department:{Department} InternalPhone:{InternalPhone}";

            Console.WriteLine($"BadgeID:{BadgeID}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"SurName:{SurName}");
            Console.WriteLine($"Department:{Department}");
            Console.WriteLine($"InternalPhone:{InternalPhone}");

            return output;
        }

        public string PrintBasicInfo()
        {
            string output = $"Name:{Name} Department:{Department}";
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Department:{Department}");

            return output;
        }
    }
}
