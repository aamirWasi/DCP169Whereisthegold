using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill169Gold
{
    class Program
    {
        static void Main(string[] args)
        {

            var TakeLine = Console.ReadLine();
            var space = TakeLine.Split(' ');
            int row = int.Parse(space[0]);
            int col = int.Parse(space[1]);
            var arr = new string[row,col];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //var line = Console.ReadLine();
                    //if(line.Contains("$"))
                    //{
                    //    Console.WriteLine($"{arr[i,j]}");
                    //}
                    arr[i, j] = Console.ReadLine();
                    //Console.WriteLine($"{arr[i,j]}");
                }
                //Console.WriteLine(Environment.NewLine);
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}");
                }
            }
            Console.ReadKey();
        }
    }
}
