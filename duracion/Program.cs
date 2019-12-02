using System;

namespace Duracion
{
    class Duracion{
private int Hr;
private int Mi;
private int Seg;
private int mit;


public Duracion(int H, int M, int S,int mt ){
Hr = H;
Mi = M;
Seg = S;
mit =mt;

}
public void print(){
   
    Console.WriteLine("Horas :"+Hr+" Minutos : "+Mi+" Segundos :"+Seg );
     Console.WriteLine("Minutos totales :" +((Hr*60)+Mi) );
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion Cancion = new Duracion(0,02,52,00);
            Duracion Clases = new Duracion(0,50,59,00);
            Duracion Concierto = new Duracion(3,40,40,00);
            Duracion Partido = new Duracion(1,30,00,00);
            Duracion Caricatura = new Duracion(0,40,40,00);
            Duracion Peliculas = new Duracion(2,10,00,00);
            Console.WriteLine("Cancion");
            Cancion.print();
            Console.WriteLine("Clases");
            Clases.print();
            Console.WriteLine("Concierto");
            Concierto.print();
            Console.WriteLine("Partido de futbol");
            Partido.print();
            Console.WriteLine("Caricatura");
            Caricatura.print();
            Console.WriteLine("Pelicula");
            Peliculas.print();
            
           
        }
    }
}
