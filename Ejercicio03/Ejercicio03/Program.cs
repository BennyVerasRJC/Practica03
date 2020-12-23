using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 15;
            int Y = 10;
            double N = 2.25;
            double M = 1.75;

            Console.WriteLine("X={0}, Y={1}, N={2}, M={3}",X,Y,N,M);
            Console.WriteLine("SUMA={0}",X+Y);
            Console.WriteLine("RESTA={0}",X-Y);
            Console.WriteLine("PRODUCTO={0}",X*Y);
            Console.WriteLine("COCIENTE={0}",X/Y);
            Console.WriteLine("RESTO={0}",X%Y);

            Console.WriteLine("SUMA={0}", N + M);
            Console.WriteLine("RESTA={0}", N - M);
            Console.WriteLine("PRODUCTO={0}", N * M);
            Console.WriteLine("COCIENTE={0}", N / M);
            Console.WriteLine("RESTO={0}", N % M);

            Console.WriteLine("SUMA={0}", X + N);
            Console.WriteLine("COCIENTE={0}", Y / M);
            Console.WriteLine("RESTO={0}", Y % M);

            Console.WriteLine("DOBLE X={0}", X*2);
            Console.WriteLine("DOBLE Y={0}", Y*2);
            Console.WriteLine("DOBLE N={0}", N*2);
            Console.WriteLine("DOBLE M={0}", M*2);

            Console.WriteLine("SUMA DE TODOS={0}", X + N + Y + M);
            Console.WriteLine("SUMA DE TODOS={0}", X * N * Y * M);


        }
    }
}
