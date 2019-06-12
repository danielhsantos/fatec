using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAExercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int contador = 0;

            for (int indice = 0; indice < 10; indice++)
            {
                Console.Write("Digite o " + (indice + 1) + "° número: ");
                n[indice] = Convert.ToInt32( Console.ReadLine() );
            }

            foreach(int valor in n)
            {
                if(valor % 2 == 0)
                {
                    Console.WriteLine(valor);
                    contador++;
                }
            }

            if(contador == 0)
            {
                Console.Write("Todos os números são ímpares.");
            }
            Console.Read();
        }
    }
}
