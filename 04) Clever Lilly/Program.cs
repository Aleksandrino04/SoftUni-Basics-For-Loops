using System;

namespace _04__Clever_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMaschine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }
            }
            if (money >= washingMaschine)
            {
                Console.WriteLine($"Yes! {money-washingMaschine:f2}");
            }
            else
            {
                
                Console.WriteLine($"No! {washingMaschine-money:f2}");
            }

                
            
               

        }
    }
}
