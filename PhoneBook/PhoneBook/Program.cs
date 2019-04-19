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
            Employee emp2 = new Employee("Wojciech", "Pieróg", 3, Departments.Koszalin, "+48800700622");
            Employee emp3 = new Employee("Piotr", "Mak", 4, Departments.Szczecin, "+48800700633");
            Phonebook testPhoneBook = new Phonebook();
            testPhoneBook.addEmployee(emp0);
            testPhoneBook.addEmployee(emp1);
            testPhoneBook.addEmployee(emp2);
            testPhoneBook.addEmployee(emp3);
            Console.WriteLine("The phonebook");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Available commands are:" +
                "\n*Quit - quits application;" +
                "\n*Location $x - lists all employees from given location;" +
                "\n*Badge/BadgeId $x - prints out employee with given badgeId; " +
                "\n*Name $x - lists all employees with given name;" +
                "\n*Add $name $surname $badge $department $phone - add employee, by providing info as parameteres separated with space" +
                "\n-------------------------------------------------" +
                "\n");
            while (true)
            {
                var xcomm = Console.ReadLine();
                var commands = xcomm.Split(' ');
                if (commands[0] == "QUIT" || commands[0] == "Quit" || commands[0] == "quit")
                {
                    break;
                }
                else if (commands[0] == "Location" || commands[0] == "location" || commands[0] == "LOCATION")
                {
                    try
                    {
                        if (commands[1] != String.Empty)
                        {
                            Departments temp;
                            Enum.TryParse(commands[1], out temp);
                            if(temp==Departments.unexpected)
                            {
                                Console.WriteLine("Incorrect department provided");
                            }
                            else
                            {
                                var list = testPhoneBook.employeesFromLocation(temp);
                                if (list.Count == 0)
                                {
                                    Console.WriteLine("0 search results");
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Incorrect number of parameters provided");
                    }
                }
                else if (commands[0] == "BadgeID" || commands[0] == "Badge" || commands[0] == "BadgeId" || commands[0] == "badgeid" || commands[0] == "badge" || commands[0] == "BADGE" || commands[0] == "BADGEID")
                {
                    try
                    {
                        int badgeInput = Int32.Parse(commands[1]);
                        testPhoneBook.employeeByBadgeId(badgeInput).PrintFullInfo();
                    }
                    catch (SystemException e)
                    {
                        if (e is FormatException)
                            Console.WriteLine("Incorrect Badge number, please provide it as integer");
                        else if (e is IndexOutOfRangeException)
                        {
                            Console.WriteLine("Incorrect number of parameters provided");
                        }
                        else
                            throw;
                    }
                }
                else if (commands[0] == "NAME" || commands[0] == "Name" || commands[0] == "name")
                {
                    try
                    { 
                        var list = testPhoneBook.employeesByName(commands[1]);
                        if (list.Count == 0)
                        {
                            Console.WriteLine("0 search results");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Incorrect number of parameters provided");
                    }
                }
                else if (commands[0] == "ADD" || commands[0] == "Add" || commands[0] == "add")
                {
                    try
                    {
                        Departments temp;
                        Enum.TryParse(commands[4], out temp);
                        if (temp == Departments.unexpected)
                        {
                            Console.WriteLine("Incorrect department provided");
                        }
                        else
                        {
                            int badgeInput = Int32.Parse(commands[3]);
                            Employee emp4 = new Employee(commands[1], commands[2], Int32.Parse(commands[3]), temp, commands[5]);
                            testPhoneBook.addEmployee(emp4);
                            emp4.PrintFullInfo();
                        }
                    }
                    catch (SystemException e)
                    {
                        if (e is FormatException)
                            Console.WriteLine("Incorrect Badge number, please provide it as integer");
                        else if (e is IndexOutOfRangeException)
                        {
                            Console.WriteLine("Incorrect number of parameters provided");
                        }
                        else
                            throw;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            }
        }
    }
}
