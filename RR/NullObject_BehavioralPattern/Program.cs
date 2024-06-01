namespace NullObject_BehavioralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractObject realObject = new RealObject();
            AbstractObject nullObject = new NullObject();

            ClientCode(realObject);
            ClientCode(nullObject);

            Console.ReadLine();
        }

        static void ClientCode(AbstractObject obj)
        {
            obj.Request();
        }
    }
}