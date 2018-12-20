using System;
namespace AssemblyGame
{
    class Case
    {
        public int X;
        public int Y;
        public string Description;
        //public Monster m; 

        public Case(int x, int y, string D)
        {
            X = x;
            Y = y;
            Description = D;
            //Hero = null;
            Random r = new Random(DateTime.Now.Millisecond);
        }

    }
}
