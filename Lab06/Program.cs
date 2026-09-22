namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int level = 7;
            if (level >= 5)
            {
                Console.WriteLine("The door opens.");

            else if (level >= 10 )
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
