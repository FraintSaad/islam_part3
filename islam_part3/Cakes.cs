﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class Cakes
    {
        public static void Start()
        {
            string[] cakes = new string[] { "Тортик", "Тортище", "Торт95", "тоРТило"};
            Console.WriteLine($"В наличии есть: {string.Join(", ", cakes)}");
            int[] prices = new int[] { 1507, 3600, 200, 400 };
            Console.WriteLine("Муьлха торт еза?");
            string ThisCake = Console.ReadLine();
            for (int i = 0; i < cakes.Length; i++)
            {
                if (ThisCake.ToLower() == cakes[i].ToLower())
               {
                Console.WriteLine($"{ThisCake} {prices[i]} сом доьхуш ю.");
                    return;
               }
            }
           
            Console.WriteLine($"{ThisCake} ц1е йолу торт яц");
            


        }
    }
}

