using HomeWork.Models;
using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string namecom = Console.ReadLine();
            Company company = new Company(namecom,5);

            Employee employee1 = new Employee
            {
                FullName = "Kamran Memmedov",
                Salary = 750,
                Position = "Adminstrator"
            };
            

            Employee employee2 = new Employee
            {
                FullName = "Qurban Zakiri",
                Salary = 700,
                Position = "Satici"
            };


            Employee employee3 = new Employee
            {
                FullName = "Kenan Huseynov",
                Salary = 350,
                Position = "Proqramist"

            };
            

            company.AddEmployees(employee1);
            company.AddEmployees(employee2);
            company.AddEmployees(employee3);
            







        }
    }
}
