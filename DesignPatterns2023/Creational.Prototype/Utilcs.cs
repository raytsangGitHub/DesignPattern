using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public static class Utilcs
    {
        public static void ShowDetails(Employee emp)
        {
            Console.WriteLine($"{emp.Type} Employee");
            Console.WriteLine($" Name:{emp.Name}, Department: {emp.Department}, Type:{emp.Type}\n");
            //, Salary: {emp.Salary}
        }
    }
}
