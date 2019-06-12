using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAExercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            String procurado = "";
            String[] nomes = { "Asfilófio", "Bestilde", "Dezêncio", "Evangivaldo", "Fologênio", "Heliogábalo", "Mereveu", "Ocidentina", "Claysikelle", "Maiquel" };
            int indice;
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

                if (achou == true)
                {
                    break;
                }

            }while(true);

            if(achou)
            {
                Console.WriteLine("Encontrado na posição: " + indice);
            }
            else
            {
                Console.WriteLine("Nome não encontrado!");
            }

            Console.Read();
        }
    }
}
