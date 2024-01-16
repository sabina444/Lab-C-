namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> str = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                str.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Список 1 = {string.Join(' ', str)}");
            str.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Измененный список 1 = {string.Join(' ', str)}");


            List<int> str2 = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                str2.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Список 2 = {string.Join(' ', str2)}");

            for (int i = 0, j = 0; i < str.Count; i++)
            {
                if (i >= 2 && i <= 4)
                {
                    str[i] = str2[j];
                    j++;
                }
            }

            Console.WriteLine($"Новый список 1 = {string.Join(' ', str)}");
            Console.WriteLine($"Количество элементов в первом списке = {str.Count}");
            Console.WriteLine($"Максимум элементов в первом списке = {str.Max()}");
            Console.WriteLine($"Минимум элементов в первом списке = {str.Min()}");

            int[] array = new int[str2.Count];

            for (int i = 0;i < str2.Count; i++)
            {
                array[i] = str2[i];
            }

            Console.WriteLine($"Массив второго списка = {string.Join(" ", array)}");

            str2.RemoveAt(1);
            Console.WriteLine($"Измененный список 2 = {string.Join(' ', str2)}");
        }
    }
}