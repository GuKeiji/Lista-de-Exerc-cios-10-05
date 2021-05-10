using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            string[] nomes = null;
            string outroNome = "";
            nomes = new string[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome {(i + 1)}");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Digite um nome");
            outroNome = Console.ReadLine();
            for (var i = 0; i < 10; i++)
            {
                if (outroNome == nomes[i])
                {
                    texto = "ACHEI";
                    break;
                }
                else
                {
                    texto = "NÃO ACHEI";
                }
            }
            Console.WriteLine("\n" + texto);
        }
    }
}
