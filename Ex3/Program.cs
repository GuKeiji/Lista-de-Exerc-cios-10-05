using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quantidade;
            float precoUnitario;
            float desconto;
            float total;
            float totalPagar;
            Console.WriteLine("Insira o nome do produto");
            nome = Console.ReadLine();
            Console.WriteLine($"Insira a quantidade de produto {nome}");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira o preço unitário de {nome}");
            precoUnitario = float.Parse(Console.ReadLine());

            if (quantidade <= 5)
            {
                total = quantidade * precoUnitario;
                desconto = precoUnitario * 2 / 100;
                totalPagar = total - desconto;
                Console.WriteLine($"Total: R${total}\nDesconto: {desconto}%\nTotal a pagar: R${totalPagar}");
            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                total = quantidade * precoUnitario;
                desconto = precoUnitario * 3 / 100;
                totalPagar = total - desconto;
                Console.WriteLine($"Total: R${total}\nDesconto: {desconto}%\nTotal a pagar: R${totalPagar}");
            }
            else
            {
                total = quantidade * precoUnitario;
                desconto = precoUnitario * 5 / 100;
                totalPagar = total - desconto;
                Console.WriteLine($"Total: R${total}\nDesconto: {desconto}%\nTotal a pagar: R${totalPagar}");
            }
        }
    }
}
