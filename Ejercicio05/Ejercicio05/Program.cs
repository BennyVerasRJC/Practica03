using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;
            int temporal = B;

            B = C;
            C = A;
            A = D;
            D = temporal;
            Console.WriteLine("A={0}, B={1}, C={2}, D={3}",A,B,C,D);
        }
    }
}
