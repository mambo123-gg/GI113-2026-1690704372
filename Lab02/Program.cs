using System.Formats.Tar;
/*
 * Student ID :1690704372
 * Name       :pantat tesngamtuan
 * Section    :129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level {level}");
            Console.WriteLine($"HP {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE=====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            // Lab02 Part B
            string arbiter = "hermes";
            char ranks = 'A';
            int maxHps = 400;
            float attackPower2 = 25.5f;
            double critMultiplier2 = 5.5;
            bool isArbiter = true;
            Console.WriteLine("===== Hero 1 =====");
            Console.WriteLine($"Name: {arbiter}");
            Console.WriteLine($"Rank: {ranks}");
            Console.WriteLine($"HP: {maxHps}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier2}");
            Console.WriteLine($"IsArbiter: {isArbiter}");
            string swordman = "Aime";
            char ranks2 = 'A';
            int maxHp2 = 250;
            float attackPower3 = 70.5f;
            double critMultiplier3 = 10.5;
            bool isSwordman = true;
            Console.WriteLine("===== Hero 2 =====");
            Console.WriteLine($"Name: {swordman}");
            Console.WriteLine($"Rank: {ranks2}");
            Console.WriteLine($"HP: {maxHp2}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier3}");
            Console.WriteLine($"IsSwordman: {isSwordman}");
            string songseeker = "Elena";
            char ranks3 = 'B';
            int maxHp3 = 200;
            float attackPower4 = 30.5f;
            double critMultiplier4 = 5.5;
            bool isSongseeker = true;
            Console.WriteLine("===== Hero 3 =====");
            Console.WriteLine($"Name: {songseeker}");
            Console.WriteLine($"Rank: {ranks3}");
            Console.WriteLine($"HP: {maxHp3}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier4}");
            Console.WriteLine($"IsSongseeker: {isSongseeker}");
            string Echoproxy = "Ren";
            char ranks4 = 'B';
            int maxHp4 = 175;
            float attackPower5 = 80.5f;
            double critMultiplier5 = 7.5;
            bool isEchoproxy = true;
            Console.WriteLine("===== Hero 4 =====");
            Console.WriteLine($"Name: {Echoproxy}");
            Console.WriteLine($"Rank: {ranks4}");
            Console.WriteLine($"HP: {maxHp4}");
            Console.WriteLine($"Attack Power: {attackPower5}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier5}");
            Console.WriteLine($"IsEchoproxy: {isEchoproxy}");
           
        }
    }
}

