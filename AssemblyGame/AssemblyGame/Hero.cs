using System;
namespace AssemblyGame
{
    class Hero : Personnage
    {
        public int healLvl = 7, maxHealth = 15;
        public int numOfAttack;

        public Hero(string name, int attack, int health, int x, int y) : base(name, attack, health, x, y)
        {
            numOfAttack = 2;
        }

        public void LevelUp()
        {
            Console.WriteLine("Vous êtes passé au niveau supérieur ! !");
            Console.WriteLine("Attaque +3");
            Console.WriteLine("Guérison +5");
            Console.WriteLine("Force Max +10");
            Console.ReadLine();
            Console.Clear();

            Attack += 3;
            maxHealth += 10;
            Health = maxHealth;
            healLvl += 5;
        }

        // Special -------------------------------------------

        public void Heal()
        {
            Health += healLvl;

            if (Health > maxHealth)
            {
                Health = maxHealth;
            }
        }


        public void AttaqueMultiTicket(Hero target)
        {
            target.Health -= 5;
        }


        // Méthodes utilisé pour les batailles ----------------------------------------

        public int Choice() 
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("1. Attaquer");
                Console.WriteLine("2. Rétablir la Force");
                Console.WriteLine("3. Attaque Spécial");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("Je n'ai pas compris votre choix , réessayez!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice == 3) 
                {
                    Console.WriteLine("Choisir Spécial:");
                    Console.WriteLine("1. Attaque MultiTicket");
                    Console.WriteLine("2. Revenir au menu précédent");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Je n'ai pas compris votre choix, réessayez!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                }

                if (choice == 1 || choice == 2 || choice == 4)
                {
                    break;
                }
            }
            return choice;
        }


        public void YourTurn(int decision, Hero target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("Vous avez lancé l'attaque  : je guette si il y a des controleurs !");
            }

            if (decision == 2)
            {
                Heal();
                Console.WriteLine("Vous avez rétabli {0} de Force!", healLvl);
            }

            if (decision == 3)
            {
                AttaqueMultiTicket(target);
                Console.WriteLine("Vous avez lancé l'attaque Multitickets !");
            }

        }
    }
}
