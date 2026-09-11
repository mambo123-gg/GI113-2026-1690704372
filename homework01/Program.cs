namespace homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        const string GameTitle = "Song of eternie";
            var heroName = "assaya";     
            var heroRank = 'C';         
            int heroLevel = 40;
            float critChance = 0.50f;
            double staminaPrecise = 20.7;  
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Rank        : {heroRank}");
            Console.WriteLine($"Level       : {heroLevel}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            double heroLevelAsDouble = heroLevel; 
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;              
            int staminaRounded = Convert.ToInt32(staminaPrecise);      
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
