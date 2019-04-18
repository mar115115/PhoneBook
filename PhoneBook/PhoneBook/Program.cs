namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Imie", "Nazwisko", Departments.Szczecin, "+48800303301");
            emp1.PrintBasicInfo();
            Console.ReadLine();
        }
    }
}
