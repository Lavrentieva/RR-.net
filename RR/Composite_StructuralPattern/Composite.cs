using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_StructuralPattern
{
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();
        private string _name;

        public Composite(string name)
        {
            _name = name;
        }

        public void Add(Component component)
        {
            _children.Add(component);
        }

        public void Remove(Component component)
        {
            _children.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine($"Composite {_name} operation.");

            foreach (var child in _children)
            {
                child.Operation();
            }
        }
    }
}
