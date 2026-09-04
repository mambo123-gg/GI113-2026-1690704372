using System.Runtime.CompilerServices;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}" +
            $"\nCurrent HP: {currentHp} / {maxHp}" +
            $"\nAttack Power: {attackPower}" +
            $"\nCritical Multiplier: {critMultiplier}" +
            $"\nIs Boss: {isBoss}");

            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp;
            Console.WriteLine($"Current HP (as double): {currentHpAsDouble}");

            double hpPercentage = currentHpAsDouble * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("\n-----IsExplicit Case: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (as int): {attackDisplay}");
            Console.WriteLine($"AttackPower Power (int cast): {attackDisplay}");
            Console.WriteLine();
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier ----- ");
            int critCast = (int)critMultiplier;
            int critConvert = (int)Convert.ToInt32(critMultiplier);
            Console.WriteLine($"critMultiplier (int cast): {critCast}");
            Console.WriteLine($"critMultiplier (Convert rounded): {critConvert}");




        }
    }
}
