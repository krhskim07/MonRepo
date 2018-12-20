using System;
namespace AssemblyGame
{
    class Controleur : Enemy
    {
        public int numOfAttack;

        public Controleur(string name, int attack, int health, int x, int y) : base(name, attack, health, x, y)
        {
            numOfAttack = 2;
        }

        public int EChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }

        //Battle Method

        public void AttaqueJappelleLaPolice(Enemy target)
        {
            target.Health -= Attack + 2;
        }

        public void ControleurTurn(int choice, Enemy target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Le Contrôleur vous a lancé l'attaque Contrôle titre de transport SVP !!");
            }
            if (choice == 2)
            {
                AttaqueJappelleLaPolice(target);
                Console.WriteLine("Le Contrôleur vous a lancé l'attaque J'appelle la police !");
            }

            Console.ReadLine();
            Console.Clear();
        }


    }

}
