using System;
namespace AssemblyGame
{
    class Game
    {

        public void AfficherMenuMove()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("1 - Aller au Nord");
            Console.WriteLine("2 - Aller au Sud");
            Console.WriteLine("3 - Aller à l'Ouest");
            Console.WriteLine("4 - Aller à l'Est");
            Console.WriteLine("5 - Retour");
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

        public void MenuMove(Hero hero, Controleur controleur, Map mappy)
        {
            AfficherMenuMove();
            int Choice = AskChoiceM(1, 5);
            switch (Choice)
            {
                case 1:
                    North(hero, controleur, mappy);
                    break;
                case 2:
                    South(hero, controleur, mappy);
                    break;
                case 3:
                    West(hero, controleur, mappy);
                    break;
                case 4:
                    East(hero, controleur, mappy);
                    break;
                case 5:

                    break;

            }
        }
        public void North(Hero hero1, Controleur controleur1, Map mappy1)
        {
            //Console.Clear();
            Console.WriteLine("------------------------------------");
            if (hero1.Y > 0)
            {
                hero1.Y--;

                mappy1.Afficher(hero1, controleur1);
                MenuMove(hero1,controleur1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1,controleur1, mappy1);
            }
        }
        public void South(Hero hero1, Controleur controleur1, Map mappy1)
        {
            //Console.Clear();
            Console.WriteLine("------------------------------------");
            if (hero1.Y < mappy1.Largeur - 1)
            {
                hero1.Y++;
                mappy1.Afficher(hero1, controleur1);
                MenuMove(hero1, controleur1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1, controleur1, mappy1);
            }
        }
        public void West(Hero hero1, Controleur controleur1, Map mappy1)
        {
            //Console.Clear();
            Console.WriteLine("------------------------------------");

            if (hero1.X < mappy1.Largeur -1)
            {
                hero1.X--;
                mappy1.Afficher(hero1, controleur1);
                MenuMove(hero1,controleur1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1,controleur1, mappy1);
            }
        }
        public void East(Hero hero1, Controleur controleur1, Map mappy1)
        {
            //Console.Clear();
            Console.WriteLine("------------------------------------");

            if (hero1.X < mappy1.Largeur - 1)
            {
                hero1.X++;
                mappy1.Afficher(hero1, controleur1);
                MenuMove(hero1, controleur1, mappy1);
            }
            else
            {
                Console.WriteLine(" Tu ne peux pas sortir de la map");
                MenuMove(hero1,controleur1, mappy1);
            }
        }
    }


}


