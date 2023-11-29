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
            Console.WriteLine("Введите три отзыва");
    
            for (int i = 0; i < reviewsCount; i++)
            {
                Console.Write($"Введите отзыв номер {i + 1}: ");
                string review = Console.ReadLine();

                AnalyzeSentiment(review);
            }
           
             void AnalyzeSentiment(string review)
             {
                string[] words = review.Split(" ");
                foreach (var word in words)
                {
                    if (positive.Contains(word))
                    {

                        Console.WriteLine("Положительный отзыв");
                    }
                    else if (negative.Contains(word))
                    {
                        Console.WriteLine("Негативный отзыв");
                    }

                }

             }
        }
}   }
