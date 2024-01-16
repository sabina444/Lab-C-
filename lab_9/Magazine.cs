using System.Collections;
using System.Drawing;

namespace lab_9
{
    class Magazine : Edition, IEnumerable, IRateAndCopy
    {
        private Frequency _frequency; // информация о периодичности выхода журнала
        private ArrayList _listArticle; // список статей в журнале
        private ArrayList _listOfEditors; // список редакторов
       
        public Frequency Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }
        public ArrayList ListArticle
        {
            get => _listArticle;
            set => _listArticle = value;
        }
        public ArrayList ListOfEditors
        {
            get => _listOfEditors;
            set => _listOfEditors = value;
        }
        public double Average //среднее значение рейтинга в списке статей
        {
            get
            {
                double Sum = 0;
                for (int i = 0; i < ListArticle.Count; i++) //
                {
                    var article = ListArticle[i] as Article;
                    Sum += article.Rating;
                }
                return Sum;
            }
        }
        public Edition Edition 
        {
            get => new Edition(Name, Date, Circulation);
            set 
            {
                Name = value.Name;
                Date = value.Date;
                Circulation = value.Circulation;
            }  
        }
        public double Rating { get; set; }
        public Magazine(string titleMagazine, Frequency frequency, DateTime dateMagazine, int сirculationMagazine) :base (titleMagazine, dateMagazine, сirculationMagazine)
        {
            Frequency = frequency;
            ListArticle = new ArrayList();
            ListOfEditors = new ArrayList();
        }
        public Magazine()
        {
            Name = "Название журнала";
            Frequency = Frequency.Weekly;
            Date = new DateTime();
            Circulation = 0;
            ListArticle = new ArrayList();
            ListOfEditors = new ArrayList();
        }

        public bool this[Frequency frequency]
        {
            get
            {
                return Frequency == frequency;
            }
        }
        public void AddArticles(params Article[] args)
        {
            ListArticle.AddRange(args);
        }
        public override string ToString()
        {
            string s = Name + " " + Frequency + " " + Date + " "
                                 + Circulation + "\n";
            
            for (int i = 0; i < ListArticle.Count; i++)
            {
                s += ListArticle[i] + "\n";
            }
            for (int i = 0; i < ListOfEditors.Count; i++)
            {
                s += ListOfEditors[i] + "\n";
            }
            return s;
        }
        public virtual string ToShortString()
        {
            return Name + " " + Frequency + " " + Date + " "
                 + Circulation + " " + Average;
        }
        public void AddEditors(params Person[] args) 
        {
            ListOfEditors.AddRange(args);
        }
        public override object DeepCopy()
        {
            Magazine magazine = new Magazine(Name, Frequency, Date, Circulation);
            return magazine;
        }
        public IEnumerator GetEnumerator()
        {
            return _listArticle.GetEnumerator();
        }
        public IEnumerator<Article> GetEnumerator(double item)
        {
            for (int i = 0; i < ListArticle.Count; i++) 
            {
                var article = ListArticle[i] as Article; 
                if (article.Rating > item)
                {
                    yield return article;
                }
            }
        }
        public IEnumerator<Article> GetEnumerator(string item)
        {
            for (int i = 0; i < ListArticle.Count; i++)
            {
                var article = ListArticle[i] as Article;
                if (article.Title.Contains(item))
                {
                    yield return article;
                }
            }
        }
       
    }
}

