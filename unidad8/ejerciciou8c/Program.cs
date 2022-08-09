using System;

namespace ejerciciou8c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            int acu = 0;
            int promedio;
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {    if(primo(n)){
                    con++;
                 acu+=n;
            }
                 Console.WriteLine("ingrese un numero");
                 n = int.Parse(Console.ReadLine());

            }
            promedio = acu / con;
            Console.WriteLine("el promedio de primos es " + promedio);

        }



          static bool primo (int a)
        { 
            int con = 0;
            for(int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                con++;
            }
            if(con == 2){
                return true;
            }else{
                return false;
            }

        }
    }
}
