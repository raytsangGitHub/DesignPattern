using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FluentInterface
{
    internal class Employee
    {
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }

        public Employee()
        {

        }
        public Employee(String fullname, DateTime dateOfBirth, string department, string address)
        {
            this.FullName = fullname;
            this.DateOfBirth = dateOfBirth;
            this.Department = department;
            this.Address = address;
        }
    }
}
