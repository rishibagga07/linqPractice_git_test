using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqPractice
{



    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a company
            var company = new Company
            {
                CompanyName = "TechCorp",
                Departments = new List<Department>
            {
                new Department
                {
                    DepartmentName = "IT",
                    Employees = new List<Employee>
                    {
                        new Employee { Name = "Alice", Age = 30 },
                        new Employee { Name = "Bob", Age = 25 },
                        new Employee { Name = "Bob", Age = 25 }
                    }
                },
                new Department
                {
                    DepartmentName = "HR",
                    Employees = new List<Employee>
                    {
                        new Employee { Name = "Charlie", Age = 28 },
                        new Employee { Name = "Diana", Age = 35 },
                        new Employee { Name = "Bob", Age = 25 }
                    }
                }
            }
            };


            var allEmployee = company.Departments.SelectMany(dep => dep.Employees).ToList();
            var allDepartment = company.Departments.Select(dep => new { depName = dep.DepartmentName }).ToList();
            var empByGroup = company.Departments
                .SelectMany(dep => dep.Employees).GroupBy(emp => emp.Name).ToList();

            var groupCounty = company.Departments
                .GroupBy(dep => dep.DepartmentName).Select(d => new { departmentName = d.Key, Count = d.Count() });
            

            foreach(var dep in allEmployee)
            {
                Console.WriteLine($"Name: {dep.Name}");
            }

            foreach (var dep in allEmployee)
            {
                Console.WriteLine($"Name: {dep.Name}");
            }


            foreach (var dep in allEmployee)
            {
                Console.WriteLine($"Name: {dep.Name}");
            }

            //
            foreach (var dep in allEmployee)
            {
                Console.WriteLine($"Name: {dep.Name}");
            }


        }
    }
}
