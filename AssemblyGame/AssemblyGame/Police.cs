using System;
namespace AssemblyGame
{
    class Police : Enemy
    {
        public int numOfAttack;

        public Police(string name, int attack, int health, int x, int y) : base(name, attack, health, x, y)
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

        public void AttaqueTazer(Enemy target)
        {
            target.Health -= Attack + 5;
        }

        public void PoliceTurn(int choice, Enemy target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("La Police vous a lancé l'attaque Vos papiers svp !!");
            }

            if (choice == 2)
            {
                AttaqueTazer(target);
                Console.WriteLine("La Police vous a lancé l'attaque au Tazer !!");
            }

            Console.ReadLine();
            Console.Clear();
        }


    }
}
