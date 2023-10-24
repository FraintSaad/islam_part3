using System.Security.Cryptography;

namespace islam_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В магазине три торта: Тортик, стоит 1507 рублей, Тортище, стоит 3600 рублей, Торт95, стоит 200 рублей");
            Console.WriteLine("1.Тортик");
            int Тортик = 1507;
            Console.WriteLine("2.Тортище"); 
            int Тортище = 3600;
            Console.WriteLine("3.Торт95");
            int Торт95 = 200;
            int Тортиньо = 0;
            Console.WriteLine("Муьлха торт еза хьуна?");
            int a=Convert.ToInt32(Console.ReadLine());
            int choice = 0;
            switch (a)
            {
                case 1:
                    choice = Тортик;
                    Console.WriteLine("Тортик");
                    Console.WriteLine($"Тортиках {choice} сом доьху");
                    break;
                case 2:
                    choice = Тортище;
                    Console.WriteLine("Тортище");
                    Console.WriteLine($"Тортищах {choice} сом доьху");
                    break;
                case 3:
                    choice = Торт95;
                    Console.WriteLine("Торт95");
                    Console.WriteLine($"Торт95 {choice} соьманах ю");
                    break;
                    case 4:
                    choice = Тортиньо;
                    Console.WriteLine("Тортиньо");
                    Console.WriteLine("Тортиньо йац, нету, давай досвидания");
                    break;
            }



        }
    }
}