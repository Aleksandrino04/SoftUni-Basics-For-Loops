using System;

namespace _03_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double p3 = double.Parse(Console.ReadLine());
            double p4 = double.Parse(Console.ReadLine());
            double p5 = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= 199)
                {
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
                p1 = p1 / n * 100;
                p2 = p2 / n * 100;
                p3= p3/ n * 100;
                p4 = p4 / n * 100;
                p5 = p5 / n * 100;
                Console.WriteLine($"{p1:f2}%");
                Console.WriteLine($"{p2:f2}%");
                Console.WriteLine($"{p3:f2}%");
                Console.WriteLine($"{p4:f2}%");
                Console.WriteLine($"{p5:f2}%");
            }
        }
    }
}
