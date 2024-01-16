using lab_7;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateSabina = new DateTime(2004, 07, 14);
            Person Sabina = new Person("Sabina", "Nizamova", DateSabina);
            Console.WriteLine(Sabina.name);
            Console.WriteLine(Sabina.ToString());
            Console.WriteLine(Sabina.ToShortString());
            Console.WriteLine("Введите размер строк и столбцов. В качестве разделителей используйте на выбор: пробел, ~, &");

            string str = Console.ReadLine();
            string[] s = str.Split(new char[] { ' ', '~', '&' });
            int nrow = Convert.ToInt32(s[0]);
            int ncolumn = Convert.ToInt32(s[1]);

            Article[] a1 = new Article[nrow * ncolumn];
            Article[,] a2 = new Article[nrow, ncolumn];
            Article[][] a3 = new Article[nrow][];

            for (int i = 0; i < nrow * ncolumn; i++)
            {
                a1[i] = new Article();
                //Console.WriteLine(a1[i]);
            }

            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    a2[i, j] = new Article();
                    //Console.Write(a2[i,j]);
                }
                //Console.WriteLine();
            }

            int temp = 0;
            for (int i = 1; i <= nrow; i++)
            {
                if (temp + i < nrow * ncolumn)
                {
                    a3[i - 1] = new Article[i];
                    temp += i;
                }
                else
                {
                    a3[i] = new Article[nrow * ncolumn - temp];
                }
            }

            foreach (var row in a3)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    row[i] = new Article();
                    //Console.WriteLine(a3);
                }
            }

            Magazine w = new Magazine();
            Console.WriteLine(w.ToShortString());
            Console.WriteLine(w[Frequency.Weekly]);
            Console.WriteLine(w[Frequency.Monthly]);
            Console.WriteLine(w[Frequency.Yearly]);
            w.titleMagazine = "Кролики";
            w.frequency = Frequency.Weekly;
            w.dateMagazine = new DateTime(2005, 3, 15);
            w.circulationMagazine = 56;
            w.listArticle[0] = new Article(Sabina, "История кроликов", 5);
            DateTime V = new DateTime(1901, 3, 18);
            Person Vanya = new Person("Иван", "Иванов", V);
            w.listArticle[1] = new Article(Vanya, "История игрушек", 8);
            w.AddArticles(w.listArticle[0], w.listArticle[1]);
            Console.WriteLine(w.ToString());

            int time1 = Environment.TickCount;
            Console.WriteLine(a1[250000]);
            Console.WriteLine(a1[160000]);
            Console.WriteLine(a1[90000]);
            Console.WriteLine(a1[40000]);
            Console.WriteLine(a1[10000]);

            int time2 = Environment.TickCount;
            Console.WriteLine(time2 - time1);

            int time3 = Environment.TickCount;
            Console.WriteLine(a2[500, 500]);
            Console.WriteLine(a2[400, 400]);
            Console.WriteLine(a2[300, 300]);
            Console.WriteLine(a2[200, 200]);
            Console.WriteLine(a2[100, 100]);

            int time4 = Environment.TickCount;
            Console.WriteLine(time4 - time3);

            int time5 = Environment.TickCount;
            Console.WriteLine(a3[500][500]);
            Console.WriteLine(a3[400][400]);
            Console.WriteLine(a3[300][300]);
            Console.WriteLine(a3[200][200]);
            Console.WriteLine(a3[100][100]);
            int time6 = Environment.TickCount;
            Console.WriteLine(time6 - time5);
        }
    }
}
