using System;

namespace ConsoleApp
{
    class Program
    {
        static double f(double x)
        {
            double r = 2;
            double y = 0;

            if (x < -6)
                y = 2;

            if (x >= -6 && x <= -2)
                y = x / 4.0 + 0.5;

            if (x > -2 && x <= 0)
                y = 2 - Math.Sqrt(r * r - (x + 2) * (x + 2));

            if (x > 0 && x <= 2)
                y = Math.Sqrt(r * r - x * x);

            if (x > 2)
                y = -x + 2;

            return y;
        }
        static void Main(string[] args)
        {
            double xn = -7;
            double xk = 3;
            double dx = 1;
            Console.WriteLine("Значение x \tЗначение y");

            while (xn != xk + 1)
            {
                double x = xn;
                Console.WriteLine("{0,10}   |{1,10}", x, Math.Round(f(x), 2));
                xn += dx;
            }
        }
    }
}
