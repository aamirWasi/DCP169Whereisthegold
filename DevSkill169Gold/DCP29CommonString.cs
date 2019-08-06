using System;
using System.Collections.Generic;
using System.Linq;

namespace DevSkill169Gold
{
    public class DCP29CommonString
    {
        static String Findstem(String[] arr)
        {
            int n = arr.Length;
            String s = arr[0];
            int len = s.Length;
            String res = "";

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j <= len; j++)
                { 
                    String stem = s.Substring(i, j - i);
                    int k = 1;
                    for (k = 1; k < n; k++)
                        if (!arr[k].Contains(stem))
                            break;
                    if (k == n && res.Length < stem.Length)
                        res = stem;
                }
            }
            return res;
        }
        public static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                String[] arr = line.Split(' ');
                String stems = Findstem(arr);
                Console.WriteLine($"Case {t}: {stems.Count()}");
            }
        }
    }
}
