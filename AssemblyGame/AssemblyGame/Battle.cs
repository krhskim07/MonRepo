using System;
namespace AssemblyGame
{
    class Battle
    {
        public static void IsHeroDead(Hero hero)
        {
            if (hero.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Vous êtes fichu! Direction Garde à vous !!");
                Console.WriteLine("Retentez votre chance quand vous sortirez de cellule ! ");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Hero person1, Enemy person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void WithControleur(Hero hero, Controleur leur)
        {
            while (leur.Health > 0 && hero.Health > 0)
            {
                PrintTheStats(hero, leur);

                hero.YourTurn(hero.Choice(), hero);

                if (leur.Health > 0)
                {
                    leur.ControleurTurn(leur.EChoice(), leur);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a été semé!!", leur.Name);
            Console.ReadLine();
            Console.Clear();
        }



        public static void WithPolice(Hero hero, Police keuf)
        {
            while (keuf.Health > 0 && hero.Health > 0)
            {
                PrintTheStats(hero, keuf);

                hero.YourTurn(hero.Choice(), hero);

                if (keuf.Health > 0)
                {
                    keuf.PoliceTurn(keuf.EChoice(), keuf);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} a été semé !", keuf.Name);
            Console.ReadLine();
            Console.Clear();
        }


    }
}
