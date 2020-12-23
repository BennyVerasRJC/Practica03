using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            double A = 5.5;
            char C = 'R';

            double suma = N + A;
            double resta = A - N;
            int valorC = (int)C;
            Console.WriteLine("N={0}, A={1}, C={2}",N,A,C);
            Console.WriteLine("N+A= " + suma);
            Console.WriteLine("A-N= " + resta);
            Console.WriteLine("C= " + valorC);
            Console.ReadKey();

        }
    }
}
