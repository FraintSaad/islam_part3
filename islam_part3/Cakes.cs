using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class Cakes
    {
        public static void Start()
        {
            Console.WriteLine("В магазине три торта: Тортик, стоит 1507 рублей, Тортище, стоит 3600 рублей, Торт95, стоит 200 рублей");
            string[] cakes = new string[] { "Тортик", "Тортище", "Торт95", "Тортовик"};
            int[] prices = new int[] { 1507, 3600, 200, 600 };
            int choice = -1;
            do
            {
                Console.WriteLine("Введите номер торта (1-3):");
                string input = Console.ReadLine();
                try
                {
                    choice = Convert.ToInt32(input) - 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод!");
                }
                if (choice < 0 || choice >= cakes.Length)
                {
                    Console.WriteLine("Тортиньо яц, нету, досвидания");
                }
            } while (choice < 0 || choice >= cakes.Length);
         
                if (choice <= 3)
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

