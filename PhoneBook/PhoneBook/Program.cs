namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
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
            Console.WriteLine("Dda phonebook");
            while (true)
            {
                var xcomm = Console.ReadLine();
                
                if(xcomm=="QUIT" || xcomm=="Quit" || xcomm=="quit")
                {
                    break;
                }
                else
                {
                    Departments temp;
                    Enum.TryParse(xcomm, out temp);
                    testPhoneBook.employeesFromLocation(temp);
                }
                
            }
        }
    }
}
