﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }
        public override Employee ShallowCopy()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to PermanentEmployee type
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override Employee DeepCopy()
        {
            Employee employee = (Employee) this.MemberwiseClone();
            employee.Name = this.Name;
            employee.Department = this.Department;
            employee.Type = this.Type;
            
           return employee;
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
        }
    }
}
