using System;

namespace Alumnos
{
    abstract class Alumnos
    {
       protected string Nombre;
       protected string Grado;
       protected string Carrera;
       protected string Egresado;
       
       public Alumnos(string n, string g,string c,string e)
       {
           this.Nombre=n;
           this.Grado=g;
           this.Carrera=c;
           this.Egresado=e;

       }
       public abstract void print();
       
    }

    class Licenciado : Alumnos
    {
        public Licenciado(string n,string g,string c,string e):base(n,g,c,e)
        {
          
        }
        public override void print()
        {
              Console.WriteLine("El alumno:{0} de {1} de la carrera {2} egresado de {3}\n,hara su residencia en un bufette de contadores\n",Nombre,Grado,Carrera,Egresado);
        }
    }
    class Posgrado : Alumnos
    {
        public Posgrado(string n,string g,string c,string e):base(n,g,c,e)
        {
            
        }
        public override void print()
        {
            Console.WriteLine("El alumno:{0} de {1} de la carrera {2} egresado {3}\n,hara una investigacion de como omptimizar el sistema de archivos de la compañia en donde trabaja",Nombre,Grado,Carrera,Egresado);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var O = new Licenciado("sebastian ruiz ","Licenciatura","contabilidad","uabc");
            var P= new Posgrado("Brando Perez","Posgrado","contabilidad","Instituto Tecnologico de Tijuana");
            O.print();
            P.print();
        }
    }
}
