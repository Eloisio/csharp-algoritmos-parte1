using System;

namespace _04_02_Implementando_O_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var vetor = new int[]{ 4, 1, 5, 3, 2, 9, 7, 6, 8 };

            for (int i = 0; i < vetor.Length; i++)
            {
                var menor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }

                if (menor != i)
                {
                    var auxiliar = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = auxiliar;
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{ vetor[i] } ");
            }
        }
    }
}
