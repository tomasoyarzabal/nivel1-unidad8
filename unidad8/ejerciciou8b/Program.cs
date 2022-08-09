using System;

namespace ejerciciou8b
{
    class Program
    {
        static void Main(string[] args)
        {
           int n;
           int conP = 0;
           for(int x = 0; x < 5; x++)
           {
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if(par(n))
            conP++;
           }
           Console.WriteLine("La cantidad de pares es " + conP);
        }


        static bool par (int a)
        {
            if(a  % 2 == 0)
                return true;
            
            else
                return false;
            
        }    
    }
}
