using System;

namespace empresa
{

    class Persona
    {
        public string nombre;
        public string apellido;
        public string puesto;
        public string empresa;

        public Persona()
        {
            nombre = "Jaziel";
            apellido = "Perez";
            puesto = "Supervisor";
            empresa ="fdfdgd";
        }
    }

class Anonymous {
   
   public static void anonimiza( Persona p)
    {
            p.nombre = "xxxxxxxxxxx";
                
    }
    public static void anonimiza1( Persona p1)
    {
            
            p1.apellido = "xxxxxxxxxxx"; 
                 
    }
    public static void anonimiza2( Persona p2)
    {
            
            p2.puesto = "xxxxxxxxxxx"; 
                 
    }
   
    public static void cambia(ref Persona p )
      {
          p = new Persona();
          p.nombre = "new";
          p = new Persona ();
          p.apellido ="new";
          p = new Persona();
          p.puesto ="new";
          p = new Persona();
          p.empresa ="new";
          

         
       }

    class Program
    {
        static void duplica( ref int x )
        {
            x = x * 2;
        }    

        static int suma(int x, int y)
        {
            return x+y;
        }    
        static void suma(int x, int y, out int resultado) 
        {
            resultado = x + y;
        }    


        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int r = suma(a,b);
            int r2;
            suma(a,b,out r2);


       //     duplica(ref a);
            Console.WriteLine(r);
            Console.WriteLine(r2);

         Persona p = new Persona();
         Console.WriteLine(p.nombre);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         Persona p1 = new Persona ();
         Console.WriteLine(p.apellido);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         Persona p2 = new Persona ();
         Console.WriteLine(p.puesto);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         
         

         
         

        }
    }
 
 }}
