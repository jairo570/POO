using System;

namespace _4._2_Poo_Tarea
{
    abstract class Musico
    {
        public string nombre;
        public Musico(string n)
        {
            nombre = n;
        }
        public virtual void Afina() { }
        public string GetNombre()
        {
            return nombre;
        }
    }
    class Bajista : Musico
    {
        public string instrumento;
        public Bajista(string n, string i): base(n)
        {
            instrumento = i;
        }
	    public override void Afina()
        {
            Console.WriteLine("Afiando el {0}", instrumento);
        }
    }

        class Guitarrista : Musico
        {
            public string instrumento;

            public Guitarrista(string n, string i) :base(n)
            {
                instrumento = i;
            }

            public override void Afina()
            {
                Console.WriteLine("Afiando el {0}", instrumento);
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bajista b = new Bajista("Flea", "Bajo");
            Guitarrista g = new Guitarrista("Santana", "Guitarra");

            b.Afina();
            g.Afina();

            Console.ReadKey();
        }
    }
}
