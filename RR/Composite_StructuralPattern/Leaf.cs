using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_StructuralPattern
{
    public class Leaf : Component
    {
        private string _name;

        public Leaf(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine($"Leaf {_name} operation.");
        }
    }
}
