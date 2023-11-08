using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class WeatherInformation
    {
        public static void Start()
        {
            int[] temperatures = {5, 7, 1, -3, 6, 9, -5, 0, 2};
            int[] precipitation = {30, 0, 50, 30, 40, 60, 0, 20, 30};
            int sum = 0;

            for(int i=0; i<temperatures.Length; i++)
            {
                sum += temperatures[i];
            }
            int mid = sum / temperatures.Length;
            Console.WriteLine("Средняя месячная температура: " + mid);

            int hot = temperatures.Max();
            int hIndex = temperatures.ToList().IndexOf(hot);
            Console.WriteLine("Самый теплый день месяца: " + hIndex);

            int cold = temperatures.Min();
            int cIndex = temperatures.ToList().IndexOf(cold);
            Console.WriteLine("Самый теплый день месяца: " + cIndex);

            int FullPrec = precipitation.Sum();
            Console.WriteLine("Общее количество осадков за месяц: " + FullPrec);

            for(int i=0; i<precipitation.Length; i++)
            {
                sum += precipitation[i];
            }
            int centr = sum / precipitation.Length;
            int count = 0;
            for(int i = 0; i<precipitation.Length; i++)
            {
                if (precipitation[i] > centr) { count++; }
            }
            Console.WriteLine("Количество дней с осадками выше среднего: " + count);

            string freezeDays = "";
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] < 0)
                { freezeDays += i + " "; }    
                
            }
            string increasingPrecipitationDays = "";
            for (int i=1; i< precipitation.Length; i++)
            {
                if (precipitation[i] > precipitation[i-1])
                { increasingPrecipitationDays += i + " "; }    
                
            }

            Console.WriteLine($"Дни, в которых была заморозка: " + freezeDays);
             Console.WriteLine($"Дни с увеличением осадков по сравнению с предыдущим днем: " + increasingPrecipitationDays); 





        }
    }
}
