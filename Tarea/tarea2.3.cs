using System;


namespace _2._3this
{
    class Dino
    {
        protected string n;

        public Dino(string n)
        {
            this.n = n;
        }

        public void Imprimir()
        {
            Console.WriteLine("El " + n + " es un carnivoro");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dino d = new Dino("Velociraptor");
            d.Imprimir();
        }
    }
}
