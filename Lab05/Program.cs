namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game Title, Sub-title
            Console.WriteLine("==>> MY VIDEO GAME vERY <<==");
            Console.WriteLine("Hero Hp: ");
            bool heroHpok = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero ATK: ");
            bool heroAtkok = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero DFS: ");
            bool heroDfsok = int.TryParse(Console.ReadLine(), out int heroDfs);
            Console.WriteLine($"Hero Stats: HP: {heroHp}, ATK: {heroAtk}, DFS: {heroDfs}");
        }
    }
}
