using System;
namespace AssemblyGame
{
    class Debut
    {
        public static void BeforeControleur()
        {
            Console.WriteLine("Vous allez vous combattre contre les controleurs !!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforePolice()
        {
            Console.WriteLine("Vous allez vous combattre contre la Police !!");
            Console.ReadLine();
            Console.Clear();
        }


        public static void TheEnd()
        {
            Console.WriteLine("Félicitations!! vous avez vaincu vos ennemis et vous avez réussi à atteindre la sortie !!");
            Console.ReadLine();
        }
    }
}
