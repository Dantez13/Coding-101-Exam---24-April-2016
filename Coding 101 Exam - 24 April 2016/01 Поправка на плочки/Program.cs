using System;

namespace _01_Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            var workingArea = N * N;
            var benchArea = M * O;

            var workingPlaceArea = workingArea - benchArea;

            var tileArea = W * L;

            var neededTile = Math.Round(workingPlaceArea / tileArea, 2);

            var neededTime = neededTile * 0.2;

            Console.WriteLine(neededTile);
            Console.WriteLine(neededTime);
        }
    }
}
