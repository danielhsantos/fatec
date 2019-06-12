using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAExercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            String procurado = "";
            String[] nomes = { "Asfilófio", "Bestilde", "Dezêncio", "Evangivaldo", "Fologênio", "Heliogábalo", "Mereveu", "Ocidentina", "Claysikelle", "Maiquel" };
            int indice, tentativas = 1;
            bool achou = false;

            do
            {
                Console.Write("Informe um nome:");
                procurado = Console.ReadLine();

                for (indice = 0; indice < nomes.Length; indice++)
                {
                    if (procurado == nomes[indice])
                    {
                        achou = true;
                        break;
                    }
                }

                if (achou == true || tentativas >= 5)
                {
                    break;
                }

                tentativas++;

            } while (true);

            if (achou)
            {
                Console.WriteLine("Encontrado na posição: " + indice);
                Console.WriteLine("Encontrado na tentativa: " + tentativas);
            }
            else
            {
                Console.WriteLine("Nome não encontrado!");
            }

            Console.Read();
        }
    }
}
