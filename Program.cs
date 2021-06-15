using System;

namespace lanchonete_prova_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array_descricao = new string[6];
            int[,] array_valores = new int[6, 3];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite o nome do ingrediente: ");
                array_descricao[i] = Console.ReadLine();

                Console.WriteLine("Digite a quantidade mínima exigida: ");
                array_valores[i, 1] = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite a quantidade em estoque: ");
                    array_valores[i, 0] = int.Parse(Console.ReadLine());
                    if (array_valores[i, 0] < array_valores[i, 1])
                    {
                        Console.WriteLine("Valor incorreto.");
                    }
                } while (array_valores[i, 0] < array_valores[i, 1]);

                Console.WriteLine("Digite o valor unitário: ");
                array_valores[i, 2] = int.Parse(Console.ReadLine());
            }
        }
    }
}
