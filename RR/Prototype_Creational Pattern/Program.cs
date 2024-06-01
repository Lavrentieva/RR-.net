namespace Prototype_Creational_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ConcretePrototype1
            ConcretePrototype1 prototype1 = new ConcretePrototype1
            {
                Id = 1,
                Name = "Prototype 1"
            };

            // Clone the instance
            ConcretePrototype1 clone1 = (ConcretePrototype1)prototype1.Clone();

            // Modify the clone
            clone1.Name = "Clone 1";

            // Display the original and the clone
            Console.WriteLine("Original: " + prototype1);
            Console.WriteLine("Clone: " + clone1);

            // Create an instance of ConcretePrototype2
            ConcretePrototype2 prototype2 = new ConcretePrototype2
            {
                Value = 100.5
            };

            // Clone the instance
            ConcretePrototype2 clone2 = (ConcretePrototype2)prototype2.Clone();

            // Modify the clone
            clone2.Value = 200.75;

            // Display the original and the clone
            Console.WriteLine("Original: " + prototype2);
            Console.WriteLine("Clone: " + clone2);
        }
    }
}