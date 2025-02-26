﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Phonebook
    {
        List<Employee> allEmployeesList = new List<Employee> { };

        public void addEmployee(Employee employee)
        {
            allEmployeesList.Add(employee);
        }

        public List<Employee> employeesFromLocation(Departments dpt)
        {
            //List<Employee> FilteredEmployeesList = allEmployeesList.Where(x => x.Department.Equals(dpt)).ToList();
            List<Employee> FilteredEmployeesList = allEmployeesList.Where(x => x.Department==dpt).ToList();
            foreach (var x in FilteredEmployeesList)
            {
                x.PrintFullInfo();
            }

            return FilteredEmployeesList;
            //var index = integerList.Select((value, index) => new { value, index })
            //           .Where(x => x.value == desiredValue)
            //           .Select(x => (int?)x.index);

        }

        public Employee employeeByBadgeId(int badgeId)
        {
            Employee employee = allEmployeesList.Where(x => x.BadgeID == badgeId).First();
            return employee;
        }

        public List<Employee> employeesByName(string name)
        {
            List<Employee> FilteredEmployeesList = allEmployeesList.Where(x => x.Name == name).ToList();
            foreach (var x in FilteredEmployeesList)
            {
                x.PrintFullInfo();
            }
            return FilteredEmployeesList;
        }
    }
}
