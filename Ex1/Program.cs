using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            do
            {
                int anoNascimento;
                Console.WriteLine("\nEm que ano você nasceu?");
                anoNascimento = int.Parse(Console.ReadLine());
                DateTime anoAtual = DateTime.Now;
                // Console.WriteLine(anoAtual);
                int idade = anoAtual.Year - anoNascimento;
                if (idade >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVocê pode votar este ano");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVocê não poderá votar este ano");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("\nDeseja calcular outro ano? (s/n)");
                resposta = Console.ReadLine().ToLower();
            } while (resposta == "s");
            
        }
    }
}
