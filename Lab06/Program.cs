
        
        
            namespace Lab06
    {
        internal class Program
        {
            static void Main(string[] args)
            {


                int normalattack = 10;
                int criticalattack = 20;
                int potionhpheal = 30;
                int monsterhp = 100;
                int herohp = 100;

                Console.WriteLine("====Game title ethernie====");

                Console.WriteLine("Action1 normalattack.");
                Console.WriteLine("Action2 criticalattack.");
                Console.WriteLine("Action3 Drink potionhpheal.");

                Console.WriteLine("+++>CHOOSE YOUR NEXT MOVE (1-3)");
                bool inputValid = int.TryParse(Console.ReadLine() out int choice);
                if (!inputValid || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid input, please choose between 1-3 only!");
                }
                else if (choice == 1)
                {
                    monsterhp -= normalattack;
                    if (monsterhp <= 0)
                    {
                        Console.WriteLine($"monster got hit my sword normol attack, took {normalattack}DMG. Monster died!.");
                    }
                    else
                    {
                        Console.WriteLine($"monster got hit my sword normol attack, took {normalattack}DMG. Monster has {monsterhp} HP left.");
                    }
                }
                else if (choice == 2)
                {
                    monsterhp -= criticalattack;
                }
                else
                {
                    herohp += potionhpheal;
                }



                }
            }
        }
)
        }
    }
}
