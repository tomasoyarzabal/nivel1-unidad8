using System;

namespace ejerciciou8d
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int status = 0;
            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());
             positivonegativocero(numero, ref status);
             Console.WriteLine("El estado del valor " + numero + "es: " + status);

            
        }







        static void positivonegativocero (int a, ref int b)
        {
            
            if(a > 0){
                b = 1;
                
            }
            if(a == 0){
                b = 0;
                
            }
            else if (a < 0){
                b = (-1);
               
            }

        }
    }

}
