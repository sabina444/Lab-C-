using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            quest1();
            Console.WriteLine("---------------------------------------------");
            quest2();
            Console.WriteLine("---------------------------------------------");
            quest3();
        }
        public static void quest1()
        {
            static int ReturnInt(string com = "Enter number:")
            {
                Console.WriteLine(com);
                while (true)
                {
                    try
                    {
                        return Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine($"Input Error! {com}");
                    }
                }
            }
            static void Main(string[] args)
            {
                double a, b, z1, z2;
                a = ReturnInt("Enter a: ");
                a = (a * Math.PI) / 180;
                b = ReturnInt("Enter b: ");
                b = (b * Math.PI) / 180;
                z1 = Math.Pow((Math.Cos(a) - Math.Cos(b)), 2) - Math.Pow((Math.Sin(a) - Math.Sin(b)), 2);
                z2 = -4 * Math.Pow(Math.Sin((a - b) / 2), 2) * Math.Cos(a + b);
                Console.WriteLine($"z1 = {Math.Round(z1, 3)}");
                Console.WriteLine($"z2 = {Math.Round(z2, 3)}");
            }
        }
        public static void quest2()
        {
            static int ReturnInt(string com = "Enter number:")
            {
                Console.WriteLine(com);
                while (true)
                {
                    try
                    {
                        return Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine($"Input Error! {com}");
                    }
                }
            }
            static void Main(string[] args)
            {
                int a, b, x;
                double y;
                a = ReturnInt("Enter a: ");
                b = ReturnInt("Enter b: ");
                x = ReturnInt("Enter x: ");

                if (Math.Tan(4 * x) == 90 || Math.Tan(4 * x) == 270)
                    Console.WriteLine($"Error!");

                if (a + 3 * b < 0) Console.WriteLine($"Error!");

                y = Math.Sqrt(a + 3 * b) < 3 * x ? a * Math.Pow(x, 2) + Math.Tan(4 * ((x * Math.PI) / 180))
                    : Math.Sqrt(a + Math.Abs(Math.Sin(3 * ((x * Math.PI) / 180))));

                Console.WriteLine($"y = {Math.Round(y, 3)}");
            }
        }
        public static void quest3() 
        {
            static int ReturnInt(string com = "Введите год:")
            {
                Console.WriteLine(com);
                while (true)
                {
                    try
                    {
                        return Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine($"Ошибка ввода! {com}");
                    }
                }
            }
            static void Main(string[] args)
            {
                int year;
                year = ReturnInt("Введите год: ");

                switch (year % 12)
                {
                    case 0:
                        Console.WriteLine("Год обезьяны");
                        break;
                    case 1:
                        Console.WriteLine("Год петуха");
                        break;
                    case 2:
                        Console.WriteLine("Год собаки");
                        break;
                    case 3:
                        Console.WriteLine("Год свиньи");
                        break;
                    case 4:
                        Console.WriteLine("Год обезьяны");
                        break;
                    case 5:
                        Console.WriteLine("Год коровы");
                        break;
                    case 6:
                        Console.WriteLine("Год тигра");
                        break;
                    case 7:
                        Console.WriteLine("Год зайца");
                        break;
                    case 8:
                        Console.WriteLine("Год дракона");
                        break;
                    case 9:
                        Console.WriteLine("Год змеи");
                        break;
                    case 10:
                        Console.WriteLine("Год лошади");
                        break;
                    case 11:
                        Console.WriteLine("Год овцы");
                        break;
                }
            }
        }
    }
}

