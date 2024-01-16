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
        }
            public static void quest1()
        {
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();
            Console.WriteLine("Полученные строки: ");
            string[] b = a.Split(' ');

            Console.WriteLine(string.Join(' ', b.Reverse()));  

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(string.Join('\0', b[i].Reverse().ToArray()) + " ");    
            }
            Console.WriteLine();
        }
        public static void quest2()
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();
            int K = input.Split(' ').Max(x => x.Length);
            Console.WriteLine($"Полученная K = {--K}");
            char[] a = input.ToCharArray();
            Console.WriteLine("Строка до шифрования: ");
            Console.WriteLine(a);

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == '.')
                    break;
                if (a[i] >= 65 && a[i] <= 90)
                {
                    a[i] = (char)(((a[i] - 65 + K) % 26) + 65);

                }

                if (a[i] >= 97 && a[i] <= 122)
                {
                    a[i] = (char)(((a[i] - 97 + K) % 26) + 97);
                }
            }
            Console.WriteLine("Строка после шифрования: ");
            Console.WriteLine(a);
        }
    }
}