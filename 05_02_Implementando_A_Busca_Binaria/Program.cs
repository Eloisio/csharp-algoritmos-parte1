using System;

namespace _05_02_Implementando_A_Busca_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var vetor = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15 };
            var buscado = 20;
            var inicio = 0;
            var fim = vetor.Length - 1;
            var indiceBuscado = -1;

            while(inicio <= fim)
            {
                var meio = (int)((inicio + fim) / 2);

                if (buscado == vetor[meio])
                {
                    indiceBuscado = meio;
                    break;
                }
                else if (buscado > vetor[meio])
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }
            }

            if (indiceBuscado == -1)
            {
                Console.WriteLine("Elemento não localizado.");
            }
            else
            {
                Console.WriteLine($"O elmento de valor { buscado } encontra-se no índice { indiceBuscado }");
            }
        }
    }
}
