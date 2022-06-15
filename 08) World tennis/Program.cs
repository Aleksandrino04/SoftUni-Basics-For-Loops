using System;

namespace _08__World_tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            double tournaments = double.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int pointsW = 2000;
            int pointsF = 1200;
            int pointsSF = 720;
            double tournamentsWon = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string resultTournament = Console.ReadLine();
                if (resultTournament == "W")
                {
                    totalPoints += pointsW;
                    tournamentsWon += 1;
                }
                else if (resultTournament == "F")
                {
                    totalPoints += pointsF;
                }
                else
                {
                    totalPoints += pointsSF;
                }

            }
            double averagePoints = totalPoints / (int)tournaments;
            totalPoints += startingPoints;
            double percantageWon = (tournamentsWon / tournaments) * 100;
            Console.WriteLine($" Final points: {totalPoints }");
            Console.WriteLine($"Average points: {averagePoints:f0}");
            Console.WriteLine($"{percantageWon:f2}%");



        }
    }
}
