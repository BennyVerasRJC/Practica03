using System;

namespace Practica03_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 4;

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            int modulo = num1 % num2;

            Console.WriteLine("Suma: {0}, Resta: {1}, Multiplicación: {2}, División: {3}, Módulo: {4}.",suma,resta,multiplicacion,division,modulo);

        }
    }
}
