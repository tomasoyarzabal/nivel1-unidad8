using System;

namespace ejerciciou8a
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            int cantidad;
            int resultado;
            Console.WriteLine("ingrese el precio del articulo");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            resultado = producto(precio,cantidad);
            Console.WriteLine("el monto total a pagar es de " + resultado);
        }
        static int producto (int a, int b)
        {
            int r;
            r = a * b;
            return r;

        }
    }
}
