using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islam_part3
{
    internal class BankExercise1
    {
        public static void Start()
        {
            Console.WriteLine("Введите сумму вклада:");
            double Ver=Convert.ToDouble(Console.ReadLine());

            if (Ver < 100)
            {
                Ver += Ver * 0.05;
            }
            if (Ver > 100 && Ver<200)
            {
                Ver += Ver * 0.07;
            }
            else
            {
                Ver += Ver * 0.1;
                    
            }
            Console.WriteLine($"Итоговая сумма вклада:{Ver}");
                


        }
    }
}
