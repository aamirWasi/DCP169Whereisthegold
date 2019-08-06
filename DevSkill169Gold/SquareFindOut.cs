using System;
namespace DevSkill169Gold
{
    public class SquareFindOut
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                uint num = uint.Parse(space[0]);
                if (IsPerfactSquare(num))
                {
                    Console.WriteLine($"Case {i}: YES");
                }
                else
                {
                    Console.WriteLine($"Case {i}: NO");
                }
            }
        }
        static bool IsPerfactSquare(uint num)
        {
            double x = Math.Sqrt(num);
            return ((x - Math.Floor(x)) == 0);
        }
    }
}
