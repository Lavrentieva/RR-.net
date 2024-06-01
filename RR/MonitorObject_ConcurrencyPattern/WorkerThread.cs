using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorObject_ConcurrencyPattern
{
    using System;
    using System.Threading;

    public class WorkerThread
    {
        private readonly MonitorObject monitorObject;
        private readonly string threadName;

        public WorkerThread(MonitorObject monitorObject, string threadName)
        {
            this.monitorObject = monitorObject;
            this.threadName = threadName;
        }

        public void DoWork()
        {
            Thread.CurrentThread.Name = threadName;
            monitorObject.SynchronizedMethod();
        }
    }
}
