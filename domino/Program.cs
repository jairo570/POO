using System;

namespace Domino
{
    class Ficha{
        private readonly int ficha1;
        private readonly int ficha2;
        public Ficha(int superior, int inferior){
            ficha1 = superior;
            ficha2 = inferior;
        }
        public static int operator +(Ficha x, Ficha y)
        => x.ficha1 + x.ficha2 + y.ficha1 + y.ficha2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ficha x= new Ficha (1,0);
            
            Ficha y= new Ficha (4,2);
            Console.WriteLine(x + y);
        }
    }
}
