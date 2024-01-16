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
            Console.Write("Введите количество элементов массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            int count = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-10, 10);
                if (array[i] < 0 && i % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Вывод массива: {string.Join(' ', array)}");
            Console.WriteLine($"Количество отрицательных элементов массива с четными номерами = {count}");

            //array = array.Reverse().ToArray(); тоже возвращает перевернутый массив

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                (array[j], array[i]) = (array[i], array[j]);
            }

            Console.WriteLine($"Перевернутый массив: {string.Join(' ', array)}");

            if (array.Contains(0))
                for (int i = 0; i < n; i++)
                {
                    if (array[i] == 0)
                        break;
                    else
                        sum += array[i];
                }
            Console.WriteLine($"Сумма элементов массива, расположенных до последнего нулевого элемента = {sum}");
        }
        public static void quest2()
        {
            Console.Write("Введите количество элементов массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();
            int max = 0;
            Console.WriteLine("Массив = ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-10, 10);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, array[i, i]);
            }

            Console.WriteLine($"Максимальный элемент, расположенный на главной диагонали матрицы = {max}");
            Console.WriteLine("Измененный массив (поменять местами 1 и 2 строки матрицы) = ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                        (array[i, j], array[i + 1, j]) = (array[i + 1, j], array[i, j]);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void quest3()
        {
            Random rnd = new Random();
            int[][] array = new int[5][];
            array[0] = new int[5];
            array[1] = new int[3];
            array[2] = new int[8];
            array[3] = new int[4];
            array[4] = new int[6];
            Console.WriteLine("Массив = ");
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(-500, 500);
                    sum += array[i][j];
                    Console.Write($"{array[i][j]}\t");
                }
                Console.Write($"\nСумма элементов в {i} строке = {sum}");
                Console.WriteLine();
                sum = 0;
            }
        }
    }
}
