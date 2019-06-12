using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAExercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[10];
            int contadorA = 0, contadorB = 0;

            Console.WriteLine("Leirura Vetor A");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o " + (i + 1) + "° número: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nLeitura Vetor B");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o " + (i + 1) + "° número: ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    C[i] = A[contadorA];
                    contadorA++;
                }
                else
                {
                    C[i] = B[contadorB];
                    contadorB++;                
                }
            }

            Console.WriteLine("\nVetor A");
            foreach(int valor in A)
            {
                Console.Write(valor + " ");
            }

            Console.WriteLine("\nVetor B");
            foreach (int valor in B)
            {
                Console.Write(valor + " ");
            }

            Console.WriteLine("\nVetor C");
            foreach (int valor in C)
            {
                Console.Write(valor + " ");
            }
            Console.Read();
        }
    }
}
