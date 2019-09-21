using System;
	using System.Collections.Generic;
	
	namespace peliculajairo
	{
	    class Pelicula
	    {
	        
	        private String Titulo;
	        private Int16 Año;
	        private string Pais;
	        private string Director;
	
	        
	        public void SetTitulo(string Titulo)
	        {
	            this.Titulo = Titulo;
	        } 
	        public string GetTitulo()
	        {
	            return this.Titulo;
	        }
	        public void SetAño(Int16 Año)
	        {
	            this.Año = Año;
	        } 
	        public Int16 GetAño()
	        {
	            return this.Año;
	        }
              public void Setpais(string Pais)
	        {
	            this.Pais = Pais;
	        } 
	        public string Getpais()
	        {
	            return this.Pais;
	        }
	        public void SetDirector(string Director)
	        {
	            this.Director = Director;
	        } 
	        public String GetDirector()
	        {
	            return this.Director;
	        }
	
	        //Primer constructor
	        public Pelicula()
	        {
	
	        }
	        //Segundo constructor
	        public Pelicula(String Titulo, Int16 Año,String Pais,String Director)
	        {
	            this.Titulo = Titulo;
	            this.Año = Año;
                this.Pais=Pais;
                this.Director=Director;
	        }
	
	        //metodo imprime
            //profesor creo que solo pidio Titulo y Año,le termine agregando  el pais y los directores
	        public void imprime()
	        {
	            Console.WriteLine("Titulo: {0}\nAño: {1}\nPais:{2}\nDirector:{3}\n", this.Titulo, this.Año,this.Pais,this.Director);
	        }
	    }
	    class Program
	    {
	        static void Main(String[] args)
	        {
	            //Objeto tipo pelicula
	            Pelicula p1 = new Pelicula();
	            p1.SetTitulo("Avengers:Endgame");
	            p1.SetAño(2019);
                p1.Setpais("ESTADOS UNIDOS");
                p1.SetDirector("Anthony Russo, Joe Russo");
	
	            p1.imprime();
	            
	            Pelicula p2 = new Pelicula();
	            p2.SetTitulo("Rambo. last blood");
	            p2.SetAño(2019);
                p2.Setpais("ESTADOS UNIDOS");
                p2.SetDirector("Adrian Grunberg");

	
	            p2.imprime();
	            
	
	            
	            List<Pelicula> peliculas = new List<Pelicula>();
	            peliculas.Add(new Pelicula("aquaman", 2018,"estados unidos","James wand"));
	            peliculas.Add(new Pelicula("spider-man",2018,"ESTADOS UNIDOS","Peter Ramsey e Rothman" ));
	            peliculas.Add(new Pelicula("eso:capitulo2 ",2019,"ESTADOS UNIDOS","Andres Muschietti"));
              
	
	            
	            foreach(Pelicula p in peliculas)
	            {
	                p.imprime();
	            }
	            
	        }
	    }
	}
