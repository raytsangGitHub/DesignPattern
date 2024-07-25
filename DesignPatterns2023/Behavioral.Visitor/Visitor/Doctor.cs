using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal class Doctor : IVisitor
    {
        public string DocName { get; set; }

        public Doctor(string docName)
        {
            DocName = docName;
        }

        public void Visit(IElement element)
        { 
        Kids kids = (Kids)element; //casting element type to Kids
            Console.WriteLine("Doctor: " + this.DocName + " did the health checkup of the child: " + kids.KidName);
        }
    }
}
