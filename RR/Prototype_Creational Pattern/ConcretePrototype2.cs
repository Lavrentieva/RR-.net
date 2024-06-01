using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Creational_Pattern
{
    public class ConcretePrototype2 : Prototype
    {
        public double Value { get; set; }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"ConcretePrototype2 [Value={Value}]";
        }
    }
}
