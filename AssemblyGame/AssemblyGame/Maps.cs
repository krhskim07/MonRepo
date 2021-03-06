﻿using System;
namespace AssemblyGame
{
    class Map
    {
        public int Largeur;
        public int Longueur;
        //public int NbCase;
        //public string Nom;
        public Case[,] Plateau;
        //public int MaxPlateau;

        public Map(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
            Plateau = new Case[largeur, longueur];

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    Plateau[i, j] = new Case(i, j, "mappy");
                }
            }
        }

        public string GetDescription(int x, int y)
        {
            string s = Plateau[x, y].Description;
            return s;
        }

        public void Afficher(Hero hero, Controleur controleur1)
        {
            for (int i = 0; i < Largeur; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Longueur; j++)
                {
                    if (hero.X == j && hero.Y == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[ P ]");
                    }
                    else if (controleur1.X == j && controleur1.Y == i)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("[ C ]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("[ X ]");
                    }
                }
            }
        }
    }
}