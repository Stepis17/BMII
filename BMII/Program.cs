using System;

namespace BMII
{
    class Program
    {
        static void Main(string[] args)
        {
            double vyska;
            double hmotnost;
            double count;

            Console.Clear();
            Console.WriteLine(" výpočet BMI");
            Console.WriteLine("--------------");
            Console.ReadLine();

            Console.WriteLine(" zadej hmotnost ");
            double.TryParse(Console.ReadLine(), out hmotnost);
            Console.ReadLine();

            Console.WriteLine(" set vysku ");
            double.TryParse(Console.ReadLine(), out vyska);
            Console.ReadLine();

            count = (hmotnost) / (vyska / 100)* (vyska / 100);
            Console.WriteLine();
            Console.WriteLine($"your BMI is {count} ");
            Console.ReadLine();









        }
    }
}