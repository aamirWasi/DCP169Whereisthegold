using System;
public class DCP187BelovedUncle
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int num = Fibonacci(count);
        Console.WriteLine(num);
    }

    private static int Fibonacci(int v)
    {
        if (v == 0)
            return 1;
        else if (v == 1)
            return 1;
        else
        {
            return Fibonacci(v - 1) + Fibonacci(v - 2);
        }
    }
}
