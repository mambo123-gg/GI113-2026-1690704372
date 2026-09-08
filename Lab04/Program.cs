namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| NEW ADVENTURE |");
            Console.WriteLine("+-------------------+");

            Console.Write("Name your hero: ");
            string heroName = Console.ReadLine();

            Console.WriteLine($"\n\"Welcome, {heroName}. Your journey begins.....\"\n");

            Console.WriteLine("+-------------------+");
            Console.WriteLine("|  DIFFICULTY SELECT |");
            Console.WriteLine("+-------------------+");
            Console.WriteLine("Choose difficulty (1-3): ");
            
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\" Difficulty {difficulty} selected. Good luck out there...\"\n");

            Console.WriteLine("+-------------------+");
            Console.WriteLine("|  ITEM SHOP |");
            Console.WriteLine("+-------------------+");
            Console.WriteLine("How many potion?");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+-------------------+");
            Console.WriteLine("| CHARACTER CREATION |");
            Console.WriteLine("+-------------------+");
            Console.WriteLine("Name your character: ");
            string charName = Console.ReadLine();
            Console.WriteLine("Choss a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double Luck);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer enter the dungeon. Luck: {Luck}.\n");
        }
    }
}
