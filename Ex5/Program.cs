using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10");
            int i2 = 1;
            // bool check = true;
            for (var i = 1; i <= 11; i++)
            {
                if (i == 11)
                {
                    // if (i2 <= 9)
                    // {
                        i2++;
                        i = 1;
                    // }
                }
                int resultado = i2 * i;
                Console.WriteLine($"{i2} x {i} = {resultado}");
                if (resultado == 100)
                {
                    break;
                }
            }
        }
    }
}
