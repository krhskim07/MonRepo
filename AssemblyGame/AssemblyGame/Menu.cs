using System;
namespace AssemblyGame
{
    class Menu
    {
        //Menu
        public Menu()
        {
            PrintMenu();
            int choice = AskChoice(1, 4);
            switch (choice)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    LoadGame();
                    break;
                case 3:
                    About();
                    break;
                case 4:
                    Quit();
                    break;

            }
        }
        //Afficher Menu
        public void PrintMenu()
        {
            Console.WriteLine(@"_____   _____   _____       ___   _____   _____        _____   _____    _____       ___  ___        _           ___   _____   _____   _____   _____   __   _   _____   _____  
| ____| /  ___/ /  ___|     /   | |  _  \ | ____|      |  ___| |  _  \  /  _  \     /   |/   |      | |         /   | |  _  \ | ____| |  ___| | ____| |  \ | | /  ___/ | ____| 
| |__   | |___  | |        / /| | | |_| | | |__        | |__   | |_| |  | | | |    / /|   /| |      | |        / /| | | | | | | |__   | |__   | |__   |   \| | | |___  | |__   
|  __|  \___  \ | |       / / | | |  ___/ |  __|       |  __|  |  _  /  | | | |   / / |__/ | |      | |       / / | | | | | | |  __|  |  __|  |  __|  | |\   | \___  \ |  __|  
| |___   ___| | | |___   / /  | | | |     | |___       | |     | | \ \  | |_| |  / /       | |      | |___   / /  | | | |_| | | |___  | |     | |___  | | \  |  ___| | | |___  
|_____| /_____/ \_____| /_/   |_| |_|     |_____|      |_|     |_|  \_\ \_____/ /_/        |_|      |_____| /_/   |_| |_____/ |_____| |_|     |_____| |_|  \_| /_____/ |_____|  " + "\n\n\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"--------____-------------------------------------------------------____---------
       .'  `. .__________________.           .__________________. .'  `.
   .____>__<__|__________________|__.     .__|__________________|__>__<____.
   |   |[_]|                        |     |                        |[_]|   |
   |###|###|########ESCAPE########  | FROM|########LADEFENSE#######|###|###| 
 |_|___|___|________________________|_| |_|________________________|___|___|_|
@|_|[o][o]=[o]|__________|[o]=[o][o]|_|O|_|[o][o]=[o]___________|[o]=[o][o]|_|O
================================================================================
");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine(" 1 - Demarrer le jeu ");
            Console.WriteLine(" 2 - Recharger une partie ");
            Console.WriteLine(" 3 - A Propos ");
            Console.WriteLine(" 4 - Quitter ");
        }
        //Fonction askChoice
        private static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }
        //Démarrer le jeu
        public void StartGame()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("Bonjour, biennvenue dans le jeu ESCAPE FROM LADEFENSE. ");
            Console.WriteLine("Appuyez sur n'importe quelle touche pour continuer");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Vous avez pris votre train à Paris(sans ticket!!) et vous devez descendre à la station LaDéfense..");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Mais la station LaDéfense est la station où on trouve le plus de contrôleur à Paris..");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("Le but du jeu est simple, vous devez vous déplacer jusqu'à combattre tous les ennemies ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Si vous rencontrez un contrôleur sur le chemin, vous combattrez contre lui avec des attaques spéciaux..");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("");
            Console.WriteLine("Cependant attention! Vous devez vaincre la Police qui rode dans cette station !");
            Console.WriteLine("");
            Console.WriteLine("A chaque victoire vous engrangerez des points de vie et augmenterez la puissance de votre attaque !!");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("A vous de jouer maintenant!!..");
            Console.ReadKey();


            Case();








        }

        public void Case()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Quel est votre nom ?");
            string n = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("D'accord,  " + n + ", prêt ?? appuyez sur n'importe quel touche pour commencer le jeu ");

            Console.ReadKey();
            Console.WriteLine("");

            //Hero
            Hero hero = new Hero(n, 3, 15, 0, 0);

            //Enemy Controleur
            Controleur Leur1 = new Controleur("Leur1", 2, 5, 1, 2);
            Controleur Leur2 = new Controleur("Leur2", 3, 7, 2, 3);

            //Enemy Police
            Police Keuf1 = new Police("Keuf1", 4, 9, 4, 4);
            Police Keuf2 = new Police("Keuf2", 7, 18, 6, 5);

            //Affichage Map
            Map map1 = new Map(7, 7);
            map1.Afficher(hero);
            Game game1 = new Game();
            game1.MenuMove(hero, map1);

            if (hero.X == Leur1.X && hero.Y == Leur1.Y)
            {
                Histoire.BeforeControleur();
                Battle.WithControleur(hero, Leur1);

                hero.LevelUp();
            }
            else if (hero.X == Leur2.X && hero.Y == Leur2.Y)
            {
                Histoire.BeforeControleur();
                Battle.WithControleur(hero, Leur2);

                hero.LevelUp();
            }

            else if (hero.X == Keuf1.X && hero.Y == Keuf1.Y)
            {
                Histoire.BeforePolice();
                Battle.WithPolice(hero, Keuf1);

                hero.LevelUp();
            }

            else if (hero.X == Keuf2.X && hero.Y == Keuf2.Y)
            {
                Histoire.BeforePolice();
                Battle.WithPolice(hero, Keuf2);

                hero.LevelUp();

                Histoire.TheEnd();

            }





        }






        //Recharger une partie
        public void LoadGame()
        {

        }






        //A Propos
        public void About()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"_____   _____   _____       ___   _____   _____        _____   _____    _____       ___  ___        _           ___   _____   _____   _____   _____   __   _   _____   _____  
| ____| /  ___/ /  ___|     /   | |  _  \ | ____|      |  ___| |  _  \  /  _  \     /   |/   |      | |         /   | |  _  \ | ____| |  ___| | ____| |  \ | | /  ___/ | ____| 
| |__   | |___  | |        / /| | | |_| | | |__        | |__   | |_| |  | | | |    / /|   /| |      | |        / /| | | | | | | |__   | |__   | |__   |   \| | | |___  | |__   
|  __|  \___  \ | |       / / | | |  ___/ |  __|       |  __|  |  _  /  | | | |   / / |__/ | |      | |       / / | | | | | | |  __|  |  __|  |  __|  | |\   | \___  \ |  __|  
| |___   ___| | | |___   / /  | | | |     | |___       | |     | | \ \  | |_| |  / /       | |      | |___   / /  | | | |_| | | |___  | |     | |___  | | \  |  ___| | | |___  
|_____| /_____/ \_____| /_/   |_| |_|     |_____|      |_|     |_|  \_\ \_____/ /_/        |_|      |_____| /_/   |_| |_____/ |_____| |_|     |_____| |_|  \_| /_____/ |_____|  " + "\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"             ______________________                     _____________ 
            /_\_____/|\ |__||__|   |______________]_[__|-------------|
       ____/__/|_|_| | \     --------------------------|-------------|
      |\   \_________|__\    \          0307            \|||||||||||/|
      | \            |        \                                     ||
   |  | |\___________|_________\                         [] [] [] []|| |
   |__|_|____________|______________________________________________||_|
  _|__|  ______________  |_______________________|  ______________  |__|_
 |_|__| (______________) |_______________________| (______________) |__|_|
__/______(__)_(__)_(__)_____________________________(__)_(__)_(__)______\___" + "\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(@"                  ***********
               ***** ***********
            ** ****** *** ********
           ****  ******  ** *******
           ***     ******* ** ******
           ***       **        *  **
            *|/------  -------\ ** *
             |       |=|       :===**
              |  O  |   | O   |  }|*
               |---- |   ----  |  |*
               |    |___       |\/
               |              |
               \   -----     |
                \           |
                  -__ -- -/");
            Console.WriteLine("");
            Console.WriteLine(" Jeu crée et développé par Hyun Kim ");
            Console.WriteLine("Tous droits réservés");

        }

        //Quitter le jeu
        public void Quit()
        {
            Environment.Exit(0);
        }


    }

}


