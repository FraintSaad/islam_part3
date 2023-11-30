using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class ReviewAnalyzer
    {

        public static void Start()
        {

            string[] positive = { "хороший", "замечательный", "понравился", "доволен" };
            string[] negative = { "плохой", "недоволен", "некачественный", "ужасный", "неприятно", "подвело" };
            int reviewsCount = 3;
            List<string> reviews = new List<string>();

            for (int i = 0; i < reviewsCount; i++)
            {
                Console.Write($"Введите отзыв номер {i + 1}: ");
                string review = Console.ReadLine();

                AnalyzeSentiment(review);
            }

            void AnalyzeSentiment(string review)
            {
                string[] words = review.Split(" ");
                bool isPositive = false;
                bool isNegative = false;

                foreach (var word in positive)
                {
                    if (review.Contains(word))
                    {
                        isPositive = true;
                        break;
                    }
                }

                foreach (var word in negative)
                {
                    if (review.Contains(word))
                    {
                        isNegative = true;
                        break;
                    }
                }
                if (isPositive==true)
                {
                    Console.WriteLine("Отзыв положительный");
                }
                else if (isNegative==true)
                {
                    Console.WriteLine("Отзыв негативный");
                }
                else { Console.WriteLine("Отзыв нейтральный"); }
            }
        }
    } 
}
