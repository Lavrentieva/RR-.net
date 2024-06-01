namespace MonitorObject_ConcurrencyPattern
{
    internal class Program
    {
        static void Main()
        {
            MonitorObject monitorObject = new MonitorObject();

            WorkerThread worker1 = new WorkerThread(monitorObject, "Thread 1");
            WorkerThread worker2 = new WorkerThread(monitorObject, "Thread 2");

            Thread thread1 = new Thread(new ThreadStart(worker1.DoWork));
            Thread thread2 = new Thread(new ThreadStart(worker2.DoWork));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("All threads have completed their work.");
        }
    }
}