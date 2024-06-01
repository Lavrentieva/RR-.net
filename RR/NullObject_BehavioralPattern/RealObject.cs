using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject_BehavioralPattern
{
    public class RealObject : AbstractObject
    {
        public override void Request()
        {
            Console.WriteLine("RealObject: Handling request.");
        }
    }
}
