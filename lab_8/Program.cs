
using lab_8;
class Program
{
    static void Main(string[] args)
    {
        var set = new Set();
        var set2 = new Set();
        set.ShowSet();
        Console.WriteLine(set[1]); 
        Console.WriteLine($" Объединение множеств: {set + set2}");
        Console.WriteLine($" Пересечение множеств: {set * set2}");
        Console.WriteLine($" Разность множеств: {set / set2}");
        Console.WriteLine($" Сравнение множеств(>): {set > set2}");
        Console.WriteLine($" Сравнение множеств(<): {set < set2}");
        Console.WriteLine($" Увеличение значений элементов множества на 1: {set++}");
    }
}