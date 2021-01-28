using System;

namespace _02_03_Revisando_Arrays_Em_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            var nomes = new string[5];
            var letras = new char[]{ 'A', 'B', 'C' };

            Console.WriteLine(letras[0]);
            Console.WriteLine(letras[1]);
            Console.WriteLine(letras[2]);
            
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);

            for(int i = 0; i < letras.Length; i++)
            {
                Console.WriteLine(letras[i]);
            }
        }
    }
}
