using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = null;
            numeros = new int[15];

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o numero {(i + 1)}º");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 14; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
