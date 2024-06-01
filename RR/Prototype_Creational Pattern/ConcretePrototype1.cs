using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Creational_Pattern
{
    public class ConcretePrototype1 : Prototype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"ConcretePrototype1 [Id={Id}, Name={Name}]";
        }
    }
}
