using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorObject_ConcurrencyPattern
{
    public class MonitorObject
    {
        private readonly object lockObject = new object();

        public void SynchronizedMethod()
        {
            lock (lockObject)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} has entered the synchronized method.");
                Thread.Sleep(1000); // Simulate work
                Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the synchronized method.");
            }
        }
    }
}
