using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] valores = null;
            valores = new float[10];
            float menor = 0;
            float maior = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome do {(i + 1)}º valor");
                valores[i] = float.Parse(Console.ReadLine());
                if(i == 0)
                {
                    menor = valores[i];
                    maior = valores[i];
                }
                if(valores[i] > maior)
                {
                    maior = valores[i];
                }
                if(valores[i] < menor)
                {
                    menor = valores[i];
                }
            }
            Console.WriteLine($"O menor valor é {menor}, e o maior valor é {maior}");
        }
    }
}
