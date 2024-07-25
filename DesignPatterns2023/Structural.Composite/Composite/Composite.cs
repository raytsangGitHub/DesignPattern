using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structural.Composite.Component;

namespace Structural.Composite.Composite
{
    public class Composite : IComponent
    {
        List<IComponent> components = new(); //composition
        public string Name { get; set; }
        public Composite(string name)
        {
            Name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}
