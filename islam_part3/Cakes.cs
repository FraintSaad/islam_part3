using System;
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
            string[] cakes = new string[] { "Тортик", "Тортище", "Торт95" };
            Console.WriteLine($"В наличии есть: {string.Join(", ", cakes)}");
            int[] prices = new int[] { 1507, 3600, 200 };
            Dictionary<string, int> cakePrices = new Dictionary<string, int>();
            for (int i = 0; i < cakes.Length; i++)
            {
                cakePrices.Add(cakes[i], prices[i]);
            }
            Console.WriteLine("Муьлха торт еза?");
            string ThisCake = Console.ReadLine();
            if (cakePrices.ContainsKey(ThisCake))
            {
                Console.WriteLine($"{ThisCake} {cakePrices[ThisCake]} сом доьхуш ю.");
            }
            else
            {
                Console.WriteLine($"Тортиньо яц, нету, досвидания");
            }
        }
        }
    }

