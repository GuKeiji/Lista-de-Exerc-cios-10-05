using System;

namespace Ex2
{
    class Program
    {
        // int quantidadeLitros;
        // string tipoCombustível;
        // double valorA;
        // double valorG;
        static void Main(string[] args)
        {
            int quantidadeLitros;
            string tipoCombustível;
            Console.WriteLine("Quantos litros foram vendidos?");
            quantidadeLitros = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o tipo do combustível? A-Álcool; G-Gasolina");
            tipoCombustível = Console.ReadLine().ToLower();
            if (tipoCombustível == "a")
            {
                double valorA = CalcularA(quantidadeLitros);
                Console.WriteLine($"Você vai pagar R${valorA}");
            }
            else if (tipoCombustível == "g")
            {
                double valorG = CalcularG(quantidadeLitros);
                Console.WriteLine($"Você vai pagar R${valorG}");
            }
        }

        static double CalcularA(int quantidadeLitros)
        {
            double valorAlcool = 4.9;
            if (quantidadeLitros <= 20)
            {
                double valorTotal = quantidadeLitros * valorAlcool;
                double desconto = valorTotal * 3 / 100;
                double valorA = valorTotal - desconto;
                return valorA;
            }
            else
            {
                double valorTotal = quantidadeLitros * valorAlcool;
                double desconto = valorTotal * 5 / 100;
                double valorA = valorTotal - desconto;
                return valorA;
            }
        }
        static double CalcularG(int quantidadeLitros)
        {
            double valorGasolina = 5.30;
            if (quantidadeLitros <= 20)
            {
                double valorTotal = quantidadeLitros * valorGasolina;
                double desconto = valorTotal * 4 / 100;
                double valorG = valorTotal - desconto;
                return valorG;
            }
            else
            {
                double valorTotal = quantidadeLitros * valorGasolina;
                double desconto = valorTotal * 6 / 100;
                double valorG = valorTotal - desconto;
                return valorG;
            }
        }
    }
}
