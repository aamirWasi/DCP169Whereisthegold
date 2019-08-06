using System;
namespace DevSkill169Gold
{
    public class DCP106TazzCricket
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                int numofOut = int.Parse(Console.ReadLine());
                string line = Console.ReadLine();
                var arr = line.Split(' ');
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += int.Parse(arr[i]);
                }
                Console.WriteLine($"Case {t}: {sum}");
            }
        }
    }
}
