using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite.Component
{
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name, int price)
        {
            Price = price;
            Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"Leaf components: {Name} : {Price}");
        }
    }
}
