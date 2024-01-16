namespace lab_7
{
    class Magazine
    {
        private string TitleMagazine; //название журнала
        private Frequency Frequency; // информация о периодичности выхода журнала
        private DateTime DateMagazine; // дата выхода журнала
        private int СirculationMagazine; // тираж журнала
        private Article[] ListArticle; // список статей в журнале

        private int Size { get; set; }// текущее количество статей
        public Magazine(string _titleMagazine, Frequency _frequency, DateTime _dateMagazine, int _сirculationMagazine, Article[] _listArticle)
        {
            TitleMagazine = _titleMagazine;
            Frequency = _frequency;
            DateMagazine = _dateMagazine;
            СirculationMagazine = _сirculationMagazine;
            ListArticle = _listArticle;
        }
        public Magazine()
        {
            TitleMagazine = "Название журнала";
            Frequency = Frequency.Weekly;
            DateMagazine = new DateTime();
            СirculationMagazine = 0;
            ListArticle = new Article[100];
            ListArticle[0] = new Article();
            Size = 1;
        }
        public string titleMagazine
        {
            get => TitleMagazine;
            set => TitleMagazine = value;
        }
        public Frequency frequency
        {
            get => Frequency;
            set => Frequency = value;
        }
        public DateTime dateMagazine
        {
            get => DateMagazine;
            set =>
            DateMagazine = value;
        }
        public int circulationMagazine
        {
            get => СirculationMagazine;
            set => СirculationMagazine = value;
        }
        public Article[] listArticle
        {
            get => ListArticle;
            set => ListArticle = value;
        }
        public double average //среднее значение рейтинга в списке статей
        {
            get
            {
                double Sum = 0;
                for (int i = 0; i < Size; i++)
                {
                    Sum += ListArticle[i].Rating;
                }
                return Sum;
            }
        }
        public bool this[Frequency Frequency]
        {
            get
            {
                return Frequency == frequency;
            }
        }
        public void AddArticles(params Article[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                ListArticle[Size] = args[i];
                Size++;
            }
        }
        public override string ToString()
        {
            string s = TitleMagazine + " " + Frequency + " " + DateMagazine + " "
                                 + СirculationMagazine + " ";
            for (int i = 0; i < Size; i++)
            {
                 s += ListArticle[i] + "\n";
            }
            return s;
        }
        public virtual string ToShortString()
        {
            return TitleMagazine + " " + Frequency + " " + DateMagazine + " "
                 + СirculationMagazine + " " + average;
        }
    }
}
