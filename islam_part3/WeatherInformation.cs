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
            int[] precipitation = {30, 0, 30, 50, 40, 60, 80, 20, 30};
            int sumTemp = 0;

            for(int i=0; i<temperatures.Length; i++)
            {
                sumTemp += temperatures[i];
            }
            int mid = sumTemp / temperatures.Length;
            Console.WriteLine("Средняя месячная температура: " + mid);

            var temperaturesList = temperatures.ToList();
            int hot = temperaturesList.Max();
            int hIndex = temperaturesList.IndexOf(hot);
            Console.WriteLine("Самый теплый день месяца: " + hIndex);

            int cold = temperatures.Min();
            int cIndex = temperaturesList.IndexOf(cold);
            Console.WriteLine("Самый теплый день месяца: " + cIndex);

            int FullPrec = precipitation.Sum();
            Console.WriteLine("Общее количество осадков за месяц: " + FullPrec);

            int sumPer = 0;
            for(int i=0; i<precipitation.Length; i++)
            {
                sumPer += precipitation[i];
            }
            int centr = sumPer / precipitation.Length;
            int count = 0;
            for(int i = 0; i<precipitation.Length; i++)
            {
                if (precipitation[i] > centr) { count++; }
            }
            Console.WriteLine("Количество дней с осадками выше среднего: " + count);

            string freezeAndIncreasingPrecipitation = "";
            
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] < 0 && precipitation[i] > precipitation[i - 1])
                { 
                    freezeAndIncreasingPrecipitation += i + " ";
                }

            }

            Console.WriteLine($"Дни, в которых была заморозка и увеличение осадков: " + freezeAndIncreasingPrecipitation);

        }
    }
}
