using System;

namespace StackInt
{
  class Stack<G>
    {
        
     private G[] elements;
     readonly int m_size;
     private int Stack_Pointer=0;
    
     
     public Stack():this(100)
     {
     }

    
     public Stack(int size)
     {
         
         m_size=size;
         
         elements=new G[m_size];
     }

     
     public void Push(G element)
     {
         
         if(Stack_Pointer>=m_size)
         {
            throw new StackOverflowException();
         }
         else{
         
         elements[Stack_Pointer]=element;
         
         Stack_Pointer++;
         }
     }  

     
     public G Pop()
     {
         
         Stack_Pointer--;
         
         if(Stack_Pointer>=0)
         {
         
         return elements[Stack_Pointer];
         }
         else{
             Stack_Pointer=0;
             throw new InvalidOperationException("Error de  apilar ");
         }
     }

    }



    class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> numeros= new Stack<int>(6); 
            
            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);
            numeros.Push(4);
            numeros.Push(5);
          

           
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
            Console.WriteLine(numeros.Pop());
            
          
          
    
        }
    }
}