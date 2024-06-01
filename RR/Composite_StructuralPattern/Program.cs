namespace Composite_StructuralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення листів
            Leaf leaf1 = new Leaf("A");
            Leaf leaf2 = new Leaf("B");
            Leaf leaf3 = new Leaf("C");

            // Створення композицій
            Composite composite1 = new Composite("Composite1");
            Composite composite2 = new Composite("Composite2");

            // Додавання листів до композицій
            composite1.Add(leaf1);
            composite1.Add(leaf2);

            composite2.Add(leaf3);
            composite2.Add(composite1);

            // Виконання операції на верхньому рівні композиції
            composite2.Operation();

            Console.ReadLine();
        }
    }
}