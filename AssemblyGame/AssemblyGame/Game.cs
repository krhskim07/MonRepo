using System;
namespace AssemblyGame
{
    class Game
    {

        public void PrintMenuMove()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("1 - Aller au Nord");
            Console.WriteLine("2 - Aller au Sud");
            Console.WriteLine("3 - Aller à l'Ouest");
            Console.WriteLine("4 - Aller à l'Est");
        }

        private static int AskChoiceM(int min, int max)
        {


            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }

        public void MenuMove(Hero hero, Map mappy)
        {
            PrintMenuMove();
            int Choice = AskChoiceM(1, 4);
            switch (Choice)
            {
                case 1:
                    North(hero, mappy);
                    break;
                case 2:
                    South(hero, mappy);
                    break;
                case 3:
                    West(hero, mappy);
                    break;
                case 4:
                    East(hero, mappy);
                    break;

            }
        }
        public void North(Hero hero1, Map mappy1)
        {
            Console.Clear();
            if (hero1.X > 0)
            {
                hero1.X--;
                mappy1.Afficher(hero1);
                MenuMove(hero1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1, mappy1);
            }
        }
        public void South(Hero hero1, Map mappy1)
        {
            Console.Clear();
            if (hero1.X < mappy1.Largeur - 1)
            {
                hero1.X++;
                mappy1.Afficher(hero1);
                MenuMove(hero1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1, mappy1);
            }
        }
        public void West(Hero hero1, Map mappy1)
        {
            Console.Clear();

            if (hero1.Y < 0)
            {
                hero1.Y--;
                mappy1.Afficher(hero1);
                MenuMove(hero1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1, mappy1);
            }
        }
        public void East(Hero hero1, Map mappy1)
        {
            Console.Clear();

            if (hero1.Y < mappy1.Largeur - 1)
            {
                hero1.Y++;
                mappy1.Afficher(hero1);
                MenuMove(hero1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1, mappy1);
            }
        }
    }


}


