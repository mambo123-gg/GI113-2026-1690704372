<<<<<<< HEAD
﻿namespace Lab05
=======
﻿/*
 * Student ID :1690704372
 * Name       :pantat tesngamtuan
 * Section    :129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */S
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Lab05
>>>>>>> 8d95a11daef51afcd9b6d751dadffe151cc631bb
{
    internal class Program
    {
        static void Main(string[] args)
<<<<<<< HEAD
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
=======

           


        {
            Console.WriteLine("=== BATTLE DAMAGE CALCULATOR ===");
            Console.WriteLine("Hero vs Monster -- scouting the fight before it happens");

            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAttackOk = int.TryParse(Console.ReadLine(), out int heroAttack);
            Console.Write("Hero Defense: ");
            bool heroDefenseOk = int.TryParse(Console.ReadLine(), out int heroDefense);
            Console.Write("Monster HP: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack: ");
            bool monsterAttackOk = int.TryParse(Console.ReadLine(), out int monsterAttack);
            Console.Write("Monster Defense: ");
            bool monsterDefenseOk = int.TryParse(Console.ReadLine(), out int monsterDefense);
            bool allStatsValid = heroHpOk && heroAttackOk && heroDefenseOk && monsterHpOk && monsterAttackOk && monsterDefenseOk;
            Console.WriteLine($"All stats valid: {allStatsValid}");

            int monsterMaxHp = monsterHp;
            Console.WriteLine($"[Hero]    HP:{heroHp} ATK:{heroAttack} DEF:{heroDefense}");
            Console.WriteLine($"[Monster] HP:{monsterHp} ATK:{monsterAttack} DEF:{monsterDefense}");
            // Before scouting: Hero drinks a potion (compound assignment: +=)
            int potionHeal = 8;
            heroHp += potionHeal;
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal}. Hero HP is now {heroHp}.");

            // Damage preview 1: Normal Attack (arithmetic + Math -- the base pattern)
            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"Normal Attack would deal: {normalDamage} damage");

            // Damage preview 2: Power Attack (precedence -- multiply before subtract)
            int powerDamage = Math.Max(0, heroAttack * 2 - monsterDefense);
            Console.WriteLine($"Power Attack would deal: {powerDamage} damage");

            // Damage preview 3: what Monster would deal back, if it got a turn (same pattern, other side)
            int counterDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"If Monster counters afterward, it would deal: {counterDamage} damage");
            Random rng = new Random(14);
            int roll = rng.Next(1, 101);
            bool isCritical = roll <= 10;
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"If critical, Normal Attack would instead deal: {criticalDamage} damage");
            bool heroHitsHarder = heroAttack > monsterAttack;
            bool canOneShotWithNormal = normalDamage >= monsterHp;
            bool monsterCanOneShotHero = counterDamage >= heroHp;
            bool safeTrade = normalDamage > counterDamage && !monsterCanOneShotHero;
            bool luckyOrLethal = isCritical || canOneShotWithNormal;
            Console.WriteLine($"Hero hits harder than Monster: {heroHitsHarder}");
            Console.WriteLine($"Normal Attack can defeat Monster in one hit: {canOneShotWithNormal}");
            Console.WriteLine($"Monster could defeat Hero in one hit back: {monsterCanOneShotHero}");
            Console.WriteLine($"This is a safe trade for Hero: {safeTrade}");
            Console.WriteLine($"This attack is lucky or lethal: {luckyOrLethal}");
>>>>>>> 8d95a11daef51afcd9b6d751dadffe151cc631bb
        }
    }
}
