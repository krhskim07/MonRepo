using System;
namespace AssemblyGame
{
    class Person
    {
        public string Name;
        public int Attack;
        public int Health;
        public int X;
        public int Y;

        public Person(string name, int attack, int health, int x, int y)
        {
            Name = name;
            Attack = attack;
            Health = health;
            X = x;
            Y = y;
        }

        public void PrintStats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Statut : {0} ", Name);
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("L'Attaque : {0}", Attack);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Force : {0}", Health);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        public void NormAttack(Person target)
        {
            target.Health -= Attack;
        }
    }
}
