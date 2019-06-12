using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = {10, 20, 30, 40, 50};

            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine(n[indice] * 2);
            }
            Console.Read();
        }
    }
}
