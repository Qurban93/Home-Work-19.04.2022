using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    class Company : Employee
    {

        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                if (char.IsUpper(value[0]))
                {
                    foreach (char item in value)
                    {
                        while (!char.IsDigit(item) || !char.IsWhiteSpace(item) || !char.IsLetter(item))
                        {
                            Console.WriteLine("Ad sehv daxil olunub");
                            value = Console.ReadLine();
                        }
                    }
                }
                else { Console.WriteLine("Ad sehv daxil olunub"); }
            }
        }
        public int Limit;
        private Employee[] Employees = { };


        public Company(string name,int limit)
        {
            
            Limit = limit;
            Name = name;

        }
       

        public void AddEmployees(Employee employes)
        {
            if (Employees.Length <  Limit)
            {
                Array.Resize(ref Employees,Employees.Length + 1);
                Employees[Employees.Length - 1] = employes;
                
                Console.WriteLine($"Elave olundu! Ishci Id {Id}");
            }
            else { Console.WriteLine("Kompaniyada yer yoxdur!"); }
        }

        

    }
}
