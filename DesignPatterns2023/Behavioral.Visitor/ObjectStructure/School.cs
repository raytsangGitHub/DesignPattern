using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal class School 
    {
        
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
{
                new Kids("Ram"),
                new Kids("Sara"),
                new Kids("Pam")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}
