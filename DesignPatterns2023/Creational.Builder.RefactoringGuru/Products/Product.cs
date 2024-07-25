using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Creational.Builder.RefactoringGuru.Products
{
    public class Product
    {
        private List<object> _parts = new List<object>();  //aggregation with List<>

        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
           string str = string.Empty;

            foreach (object part in this._parts)
            {
                str += $" {part} , ";
            }

            str =str.Remove(str.Length - 2);
            return $"Product parts + { str} \n";
        }
    }
}
