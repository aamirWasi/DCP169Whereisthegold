using System;
namespace DevSkill169Gold
{
    public class Bicycle
    {
        static void Main(string[] args)
        {
            UInt64 cycleFirstPrice = 0, cycleSecondPrice = 0, cycleFirstCost = 0, cycleSecondCost = 0;
            UInt64 totalCostFirstCycle = 0;
            UInt64 totalCostSecondCycle = 0;
            string[] arr, arr2;

            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                int cycle = int.Parse(Console.ReadLine());
                string line = Console.ReadLine();
                string line2 = Console.ReadLine();
                arr = line.Split(' ');
                arr2 = line2.Split(' ');
                cycleFirstPrice = UInt64.Parse(arr[0]);
                cycleFirstCost = UInt64.Parse(arr[1]);
                totalCostFirstCycle = cycleFirstPrice + cycleFirstCost;
                cycleSecondPrice = UInt64.Parse(arr2[0]);
                cycleSecondCost = UInt64.Parse(arr2[1]);
                totalCostSecondCycle = cycleSecondPrice + cycleSecondCost;
                if (totalCostFirstCycle < totalCostSecondCycle)
                    Console.WriteLine($"Case {t}: {cycleFirstPrice} {cycleFirstCost}");
                else
                    Console.WriteLine($"Case {t}: {cycleSecondPrice} {cycleSecondCost}");
            }
        }
    }
}
