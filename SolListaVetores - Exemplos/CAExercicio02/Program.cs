using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAExercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int soma = 0, media = 0;

            for (int indice = 0; indice < 8; indice++)
            {
                soma += n[indice];
            }

            media = soma / n.Length;

            Console.Write("Média = " + media);
            Console.Read();
        }
    }
}
