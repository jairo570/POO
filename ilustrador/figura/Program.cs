﻿using System;
using System.Collections.Generic;


namespace figura
{
    abstract class Figura
    {
    protected int x,y;
    protected string color;
    public Figura(int x, int y, string c){
     this.x = x; 
     this.y = y; 
     color = c; 
    }
    abstract public void dibuja();
    public void printcolor(){
        Console.WriteLine(color);
    }

    }
    class Circulo : Figura
    {
        public Circulo(int x, int y, string c):base(x,y,c)
        {
            
        }
        public override void dibuja (){
            Console.WriteLine("Se dibuja un circulo {0}", color);
        }
    }

    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y, string c):base(x,y,c)
        {
            
        }
        public override void dibuja (){
            Console.WriteLine("Se dibuja un rectangulo{0}", color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Figura> figuras = new List<Figura>();
           figuras.Add(new Circulo(12, 13, "Verde"));
           figuras.Add(new Rectangulo(12, 13, "Rojo"));
           figuras.Add(new Rectangulo(12, 13, "Azul"));
           figuras.Add(new Circulo(12, 13, "Rojo"));
           
          foreach(var item in figuras)
          {
          item.dibuja();
          Circulo c = new Circulo(12,13,"Verde");
          c.dibuja();
          
          }
        }
    }
}