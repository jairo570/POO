using System;

namespace publicacion
{
    abstract class publicacion
    {
       
       protected string Nombre;
       protected string Mensaje;
       protected string amigo;
       protected string comentario;
       protected string link;
       
      
       
       
       public publicacion( string n,string m,string a,string c,string l)
       {
           
           this.Nombre=n;
           this.Mensaje=m;
           this.amigo=a;
           this.comentario=c;
           this.link=l;
           

       }
       public abstract void print();
       
    }

    class Estado : publicacion
    {
        public Estado(string n,string m,string a,string c,string l):base(n,m,a,c,l)
        {
          
        }
        public override void print()
        {
              Console.WriteLine("publicado por: {0} mensaje :{1} reacciono  a la publicacion: {2} comento : {3} link {4} \n (estado)esta en su cumpleaños feliz y alegre\n",Nombre,Mensaje,amigo,comentario,link);
        }
    }
    class Publicacion_fotos : publicacion
    {
        public Publicacion_fotos(string n,string m,string a,string c,string l):base(n,m,a,c,l)
        {
            
        }
        public override void print()
        {
            Console.WriteLine(" publicado por: {0} foto: {1} reacciono: {2} comento: {3} link : {4}\n,(foto)saliendo del gym\n",Nombre,Mensaje,amigo,comentario,link);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var O = new Estado("juan ramirez","alegre","juan","que bueno que estas bien","faceclon.www");
            var P= new Publicacion_fotos("Brando Perez","selfie","brenda","sales bien en la foto","faceclon.www");
            O.print();
            P.print();
        }
    }
}
