namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 's';
            int Level = 7;
            int maxHp = 240;
            int currenHp = 175;
            float attackPower = 50.40f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            
            Console.WriteLine(bossName);
            Console.WriteLine($"Name: {bossName} {Level}");
            Console.WriteLine($"HP: {currenHp * 100/ maxHp}%");
        }
    }
}
