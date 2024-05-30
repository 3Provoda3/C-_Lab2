using System;

class Program
{
    static void Main(string[] args)
    {
        double a = -Math.PI / 2, b = -3 * Math.PI / 2, dx = Math.PI / 10;

        Console.WriteLine("x\t|\ty\n------------------------");

        for (double x = a; x >= b; x -= dx)
        {
            double y;
            try
            {
                y = x * x * Math.Cos(x);
            }
            catch (Exception e)
            {
                Console.WriteLine($"x = {x:F2}\t|\t{e.Message}");
                continue;
            }
            Console.WriteLine($"{x:F2}\t|\t{y:F2}");
        }
    }
}
