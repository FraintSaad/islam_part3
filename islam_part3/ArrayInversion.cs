using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class ArrayInversion
    {
        public static void Start()
        {
            int[] chisla = { 12, 4, 3, -2, 1, 9, 0 };
            int second = chisla[1];

            for (int i = chisla.Length - 1; i >= 0; --i)
            {
                Console.Write ($"{chisla[i]} ");
            }

            Console.WriteLine();

            for(int i=0; i < chisla.Length;++i)
            {
                chisla[i] *= second;

            }
            foreach (int element in chisla)
            {
                Console.Write(element + " ");
                
            }
            Console.ReadKey();

        }
    }
}
