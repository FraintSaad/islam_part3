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
            
            string[] cakes = new string[] { "Тортик", "Тортище", "Торт95"};
            Console.WriteLine($"В наличии есть: {string.Join(", ", cakes)}");
            int[] prices = new int[] { 1507, 3600, 200 };
            int choice = -1;
            {
                Console.WriteLine("Выберите торт:");
                string input = Console.ReadLine();
                choice = Convert.ToInt32(input) - 1;
            }


            if (choice <= 2 && choice >= 0)
                {
                    int price = prices[choice];
                    Console.WriteLine($"Торт: {cakes[choice]}\nЦена: {price}");
                }
                else
                {
                    Console.WriteLine("Тортиньо яц, нету, досвидания");
                }
            }
        }
    }

