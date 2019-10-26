using System;

namespace Musico
{

    
    class Musico 
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre=n;

        }
       
        public void Saludo()
        {
        Console.WriteLine("Hola,soy {0}",nombre);
        }

        public void Afina()
        {
            Console.WriteLine("{0},Afina su instrumento  ",nombre);
        }
        
        

    }

    class Bajista:Musico
    {
       private string bajo;
       public Bajista(string no,string bajo):base(no)
       {
       this.bajo=bajo;
       } 

       public void Afina1 ()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,bajo);
       }
       public void toca ()
       {
           Console.WriteLine("{0} esta usando el bajo {1}",nombre,bajo);
       }
        
    }
    class guitarrista:Musico
    {
       private string gitarra;
       public guitarrista(string no,string gitarra):base(no)
       {
       this.gitarra=gitarra;
       } 

       public void Afina2 ()
       {
           Console.WriteLine("{0} esta afinando su gitarra {1}",nombre,gitarra);
       }
       public void toca2 ()
       {
           Console.WriteLine("{0} esta usando su guitarra {1}",nombre,gitarra);
       }
        
    }
    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            guitarrista juan=new guitarrista("juan","Lucille de BB KING");
            
            tom.Saludo();
            tom.Afina();
            
            flea.Saludo();
            flea.Afina1();
            flea.toca();
            juan.Saludo();
            juan.Afina2();
            juan.toca2();

        }
    }
}
