using System;
namespace DevSkill169Gold
{

    public class DCP166POSSystem
    {
        static void Main(string[] args)
        {
            //var roundedA = Math.Round(1.1, 0); // Output: 1
            //Console.WriteLine(roundedA);
            //var roundedB = Math.Round(1.5, 0, MidpointRounding.AwayFromZero); // Output: 2
            //Console.WriteLine(roundedB);
            //var roundedC = Math.Round(1.9, 0); // Output: 2
            //Console.WriteLine(roundedC);
            //var roundedD = Math.Round(2.5, 0); // Output: 2
            //Console.WriteLine(roundedD);
            //var roundedE = Math.Round(2.5, 0, MidpointRounding.AwayFromZero); // Output: 3
            //Console.WriteLine(roundedE);
            //var roundedF = Math.Round(3.49, 0, MidpointRounding.AwayFromZero); // Output: 3
            //Console.WriteLine(roundedF);
            UInt64 T = UInt64.Parse(Console.ReadLine());
            for (UInt64 t = 1; t <= T; t++)
            {
                UInt64 purchased = UInt64.Parse(Console.ReadLine());
                UInt64 sum = 0;
                UInt64 s = 0;
                for (UInt64 i = 0; i < purchased; i++)
                {
                    s = 0;
                    string line = Console.ReadLine();
                    string[] space = line.Split(' ');
                    double p_first = double.Parse(space[0]);
                    //uint item = (int)Math.Round(uint.Parse(space[1]),0,MidpointRounding.AwayFromZero);
                    UInt64 item = UInt64.Parse(space[1]);
                    s += (UInt64)Math.Ceiling(p_first * item);
                    //s += p_first * (int)Math.Round(item, 0, MidpointRounding.AwayFromZero);
                    sum = (UInt64)(sum + s);
                }
                UInt64 taka = UInt64.Parse(Console.ReadLine());
                double r_taka = taka - sum;
                var roundTk = Math.Round(r_taka, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"Case {t}: {roundTk}");
            }
        }
    }
}
