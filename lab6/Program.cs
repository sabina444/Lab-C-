using lab6;
using System;
using System.Collections.Immutable;
using System.IO;

class Program
{
    static void Main()
    {
        {
            quest1();
            Console.WriteLine("---------------------------------------------");
            quest2();
        }
        
    }
    public static void quest1()
    {
        using (var sr = new StreamReader("C:\\Users\\Sabina\\Desktop\\text.txt"))
        {
            var str = sr.ReadToEnd().Split(". ");
            var sorted = str.OrderBy(x => x.Split(' ').First().Length).ToList();
            sorted.ForEach(x => Console.WriteLine(x));
        }
    }
    public static void quest2()
    {
        using (var sr = new StreamReader("text_2.txt"))
        {
            var lines = sr.ReadToEnd().Split('\n');
            var teachers = new List<Teacher>();
            foreach (var line in lines)
            {
                var data = line.Split(',');
                var teacher = new Teacher();
                teacher.Name = data[0];
                teacher.Subject = data[1];
                teacher.Experience = string.Join(null, data[2].Skip(1));
                teachers.Add(teacher);
            }
            var sorted = teachers.GroupBy(x => x.Subject);

            using (var sw = new StreamWriter("result.txt"))
            {
                foreach (var x in sorted)
                {
                    var key = x.Key;
                    sw.WriteLine(key);
                    teachers.Where(x => x.Subject == key).ToList().ForEach(x => sw.WriteLine(x.Name));
                }
            }
            using (var sw = new StreamWriter("result.txt", new FileStreamOptions { Mode = FileMode.Append, Access = FileAccess.Write }))
            {

                sw.WriteLine(teachers.Max(x => Convert.ToInt32(x.Experience.Split(' ')[0])));    
            }
        }
    }
}