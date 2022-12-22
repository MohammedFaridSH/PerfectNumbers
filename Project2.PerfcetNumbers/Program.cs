
using System;
public class PerfectN
{
    public static void Main()
    {
        int Output, x, y;
        int LowEnd, HighEnd;

        Console.Write("Input the starting range or number : ");
        LowEnd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        HighEnd = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers within the given range : ");
        for (Output = LowEnd; Output <= HighEnd; Output++)
        {
            x = 1;
            y = 0;
            while (x < Output)
            {
                if (Output % x == 0)
                 y = y + x;
                x++;
            }
            if (y == Output)
                Console.Write("{0} ", Output);
        }
        
    }
}
