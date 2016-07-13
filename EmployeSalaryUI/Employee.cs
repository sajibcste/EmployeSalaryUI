using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeSalaryUI
{
    class Employee
    {
        private string Id;
        private string Name;
        private string Emaill;

        public Employee(string Id, string Name, string Emaill)
        {
            // TODO: Complete member initialization
            this.Id = Id;
            this.Name = Name;
            this.Emaill = Emaill;
        }

        public Salary EmployeeSalary { get; set; }
    }
}
