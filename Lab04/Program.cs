/*
 * Student ID :1690704372
 * Name       :pantat tesngamtuan
 * Section    :129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
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
            
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
