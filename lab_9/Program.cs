using lab_9;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime DateSabina = new DateTime(2004, 07, 14);
        Person Sabina = new Person("Sabina", "Nizamova", DateSabina);
        DateTime DateDima = new DateTime(2001, 06, 20);


        Person Dima = new Person("Dima", "Bannicin", DateDima);
        DateTime DateElsa = new DateTime(2010, 01, 11);
        Person Elsa = new Person("Elsa", "Nizamova", DateElsa);

        //1
        DateTime date = new DateTime(1999, 01, 11);
        Edition edition = new Edition("СОЮЗ", date, 169);
        DateTime date2 = new DateTime(1999, 01, 11);
        Edition edition2 = new Edition("СОЮЗ", date2, 169);

        Console.WriteLine($" Ссылки : {ReferenceEquals(edition, edition2)}");

        Console.WriteLine($" Хэш-код 1: {edition.GetHashCode()}");
        Console.WriteLine($" Хэш-код 2: {edition2.GetHashCode()}");

        Console.WriteLine($" == : {edition == edition2}");
        Console.WriteLine($" != : {edition != edition2}");

        //2
        try 
        {
            edition.Circulation = 12;
        }
        catch (ArgumentException error) 
        {
            Console.WriteLine(error);
        }

        //3
        Magazine magazine = new Magazine();

        Article article = new Article(Sabina, "Кошки", 12);
        Article article2 = new Article(Dima, "Собаки", 30);
        Article article3 = new Article(Elsa, "Мыши", 20);

        magazine.AddArticles(article);
        magazine.AddArticles(article2);
        magazine.AddArticles(article3);

        magazine.ListOfEditors.AddRange(new Person[] {Dima}); //добавление редактора
        Console.WriteLine(magazine.ToString()); 

        //4
        magazine.Edition = edition;
        Console.WriteLine(magazine.ToString());

        //5
        var copy = magazine.DeepCopy();
        Console.WriteLine($" Копия: {copy}");
        magazine.Name = "СССР";
        Console.WriteLine($" Изменненый оригинал: { magazine.ToString()}");
        Console.WriteLine($" Копия: {copy}");

        //6
        var answer = magazine.GetEnumerator(15);
        while (answer.MoveNext())
            Console.WriteLine($" Итератор double: {answer.Current}");

        //7
        var answer2 = magazine.GetEnumerator("Кош");
        while (answer2.MoveNext())
            Console.WriteLine($" Итератор string: { answer2.Current}");
    }
}